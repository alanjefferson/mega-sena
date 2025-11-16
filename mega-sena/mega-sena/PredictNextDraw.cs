using mega_sena.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mega_sena
{
    public static class PredictNextDraw
    {
        public static void GeneratePredictions(List<MegaSena> lstMegaSena)
        {
            // Get current cycle state from CSV file
            var currentCycle = GetCurrentCycleStateFromCSV();

            Console.WriteLine("\n=== PREDICTION FOR NEXT DRAWS ===");
            Console.WriteLine("Based on historical analysis when 3 numbers remain\n");

            Console.WriteLine("Current Cycle Status:");
            Console.WriteLine($"Numbers remaining: {string.Join(", ", currentCycle.RemainingNumbers)}");
            Console.WriteLine();

            // Get numbers grouped by frequency
            var numbersByFrequency = currentCycle.CycleNumbers
                .Where(cn => cn.Drawn)
                .GroupBy(cn => cn.Times)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Select(cn => cn.Number).ToList());

            Console.WriteLine("Current Frequency Distribution:");
            foreach (var group in numbersByFrequency.OrderByDescending(g => g.Key))
            {
                Console.WriteLine($"  {group.Key} times: {string.Join(", ", group.Value.OrderBy(n => n))}");
            }
            Console.WriteLine();

            // Generate 3 prediction scenarios (one for each remaining number)
            foreach (int remainingNum in currentCycle.RemainingNumbers)
            {
                Console.WriteLine($"=== SCENARIO: If number {remainingNum} is drawn ===");

                var predictions = GeneratePredictionSet(currentCycle, remainingNum);

                for (int i = 0; i < predictions.Count; i++)
                {
                    Console.WriteLine($"\nStrategy #{i + 1}: {predictions[i].Rationale}");
                    Console.WriteLine($"  Complete 6-number bet: {string.Join("-", predictions[i].Numbers.OrderBy(n => n))}");
                    Console.WriteLine($"  Breakdown: [{remainingNum}] + [{string.Join(", ", predictions[i].Numbers.Where(n => n != remainingNum).OrderBy(n => n))}]");
                }

                Console.WriteLine();
            }

            // Summary: Best bets across all scenarios
            Console.WriteLine("=== RECOMMENDED BETS SUMMARY ===");
            Console.WriteLine("Top 3 recommended complete bets:\n");

            int betNumber = 1;
            foreach (int remainingNum in currentCycle.RemainingNumbers.OrderByDescending(n => n))
            {
                var prediction = GeneratePredictionByFrequencyRange(currentCycle, remainingNum, 2, 4,
                    $"Mid-range frequency (2-4 times) with remaining number {remainingNum}");

                Console.WriteLine($"Bet #{betNumber}: {string.Join("-", prediction.Numbers.OrderBy(n => n))}");
                Console.WriteLine($"  Strategy: {prediction.Rationale}");
                Console.WriteLine();
                betNumber++;
            }

            Console.WriteLine("=== END OF PREDICTIONS ===\n");
        }
        
        private static List<Prediction> GeneratePredictionSet(CycleState cycle, int includedRemainingNumber)
        {
            var predictions = new List<Prediction>();
            
            // Prediction 1: Focus on frequency 3 (most common in analysis)
            predictions.Add(GeneratePredictionByFrequency(cycle, includedRemainingNumber, 3, 
                "Most common: Numbers drawn 3 times (22.7% probability)"));
            
            // Prediction 2: Focus on frequency 2-4 range (62.5% combined)
            predictions.Add(GeneratePredictionByFrequencyRange(cycle, includedRemainingNumber, 2, 4,
                "Mid-range: Mix of numbers drawn 2-4 times (62.5% combined probability)"));
            
            // Prediction 3: Balanced approach with average frequency ~3
            predictions.Add(GenerateBalancedPrediction(cycle, includedRemainingNumber,
                "Balanced: Average frequency ~3.08 based on historical data"));
            
            return predictions;
        }
        
        private static Prediction GeneratePredictionByFrequency(CycleState cycle, int includedNum, int targetFreq, string rationale)
        {
            var candidates = cycle.CycleNumbers
                .Where(cn => cn.Drawn && cn.Times == targetFreq)
                .OrderBy(cn => Guid.NewGuid()) // Randomize
                .Take(5)
                .Select(cn => cn.Number)
                .ToList();
            
            // If not enough, fill with nearby frequencies
            if (candidates.Count < 5)
            {
                var additional = cycle.CycleNumbers
                    .Where(cn => cn.Drawn && !candidates.Contains(cn.Number) && Math.Abs(cn.Times - targetFreq) <= 1)
                    .OrderBy(cn => Math.Abs(cn.Times - targetFreq))
                    .ThenBy(cn => Guid.NewGuid())
                    .Take(5 - candidates.Count)
                    .Select(cn => cn.Number);
                
                candidates.AddRange(additional);
            }
            
            candidates.Add(includedNum);
            
            return new Prediction { Numbers = candidates, Rationale = rationale };
        }
        
        private static Prediction GeneratePredictionByFrequencyRange(CycleState cycle, int includedNum, int minFreq, int maxFreq, string rationale)
        {
            var candidates = cycle.CycleNumbers
                .Where(cn => cn.Drawn && cn.Times >= minFreq && cn.Times <= maxFreq)
                .OrderBy(cn => Guid.NewGuid())
                .Take(5)
                .Select(cn => cn.Number)
                .ToList();
            
            candidates.Add(includedNum);
            
            return new Prediction { Numbers = candidates, Rationale = rationale };
        }
        
        private static Prediction GenerateBalancedPrediction(CycleState cycle, int includedNum, string rationale)
        {
            // Try to get a mix that averages to ~3
            var freq2 = cycle.CycleNumbers.Where(cn => cn.Drawn && cn.Times == 2).OrderBy(cn => Guid.NewGuid()).Take(2).Select(cn => cn.Number).ToList();
            var freq3 = cycle.CycleNumbers.Where(cn => cn.Drawn && cn.Times == 3).OrderBy(cn => Guid.NewGuid()).Take(2).Select(cn => cn.Number).ToList();
            var freq4 = cycle.CycleNumbers.Where(cn => cn.Drawn && cn.Times == 4).OrderBy(cn => Guid.NewGuid()).Take(1).Select(cn => cn.Number).ToList();
            
            var candidates = new List<int>();
            candidates.AddRange(freq2);
            candidates.AddRange(freq3);
            candidates.AddRange(freq4);
            
            // Fill if needed
            while (candidates.Count < 5)
            {
                var additional = cycle.CycleNumbers
                    .Where(cn => cn.Drawn && !candidates.Contains(cn.Number) && cn.Times >= 2 && cn.Times <= 4)
                    .OrderBy(cn => Guid.NewGuid())
                    .FirstOrDefault();
                
                if (additional != null)
                    candidates.Add(additional.Number);
                else
                    break;
            }
            
            candidates.Add(includedNum);
            
            return new Prediction { Numbers = candidates.Take(6).ToList(), Rationale = rationale };
        }
        
        private static CycleState GetCurrentCycleStateFromCSV()
        {
            var state = new CycleState();
            state.CycleNumbers = new List<CycleNumber>();
            state.RemainingNumbers = new List<int>();

            // Find the in-progress CSV file
            string outputFolder = "Output";
            var inProgressFile = Directory.GetFiles(outputFolder, "*InProgress*.csv").FirstOrDefault();

            if (inProgressFile == null)
            {
                Console.WriteLine("No in-progress cycle found!");
                return state;
            }

            var lines = File.ReadAllLines(inProgressFile);

            // Read the first 60 lines (skip header)
            for (int i = 1; i <= 60 && i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length >= 2)
                {
                    int number = int.Parse(parts[0]);
                    int times = int.Parse(parts[1]);

                    state.CycleNumbers.Add(new CycleNumber
                    {
                        Number = number,
                        Times = times,
                        Drawn = times > 0
                    });
                }
            }

            // Find the "0 times" line to get remaining numbers
            foreach (var line in lines)
            {
                if (line.StartsWith("0 times:"))
                {
                    var numbersStr = line.Split(':')[1].Trim();
                    var numbers = numbersStr.Split(',').Select(s => int.Parse(s.Trim())).ToList();
                    state.RemainingNumbers = numbers;
                    break;
                }
            }

            return state;
        }
    }
    
    public class CycleState
    {
        public List<CycleNumber> CycleNumbers { get; set; } = new List<CycleNumber>();
        public List<int> RemainingNumbers { get; set; } = new List<int>();
    }

    public class Prediction
    {
        public List<int> Numbers { get; set; } = new List<int>();
        public string Rationale { get; set; } = string.Empty;
    }
}

