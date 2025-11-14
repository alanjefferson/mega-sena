using mega_sena.Entity;
using System.Text;

namespace mega_sena.Core
{
    public static class CycleResultsWriter
    {
        private static readonly string OutputFolder = "Output";
        
        public static void WriteCycleToCSV(Cycle objCycle, DateTime? endCycleDate = null, int lastNumber = 0, bool isLastCycle = false)
        {
            EnsureOutputFolderExists();
            
            string fileName = GenerateFileName(endCycleDate, lastNumber, isLastCycle);
            string filePath = Path.Combine(OutputFolder, fileName);
            
            var csvContent = new StringBuilder();
            
            // CSV Header
            csvContent.AppendLine("Number,Times,LastDrawn");
            
            int cycleTimeNumbersSum = 0;
            
            // Data rows
            for (int i = 0; i < 60; i++)
            {
                string lastDrawnFormatted = objCycle.CycleNumbers[i].LastDrawn?.ToString("dd/MM/yyyy") ?? "";
                csvContent.AppendLine($"{objCycle.CycleNumbers[i].Number},{objCycle.CycleNumbers[i].Times},{lastDrawnFormatted}");
                cycleTimeNumbersSum += objCycle.CycleNumbers[i].Times;
            }
            
            // Add summary rows
            int averageTimes = cycleTimeNumbersSum / 60;
            csvContent.AppendLine();
            csvContent.AppendLine($"Average Times per Number,{averageTimes}");
            csvContent.AppendLine();

            // Add cycle date information
            string startDateFormatted = objCycle.StartCycle?.ToString("dd/MM/yyyy") ?? "N/A";
            string endDateFormatted = isLastCycle ? "In Progress" : (endCycleDate?.ToString("dd/MM/yyyy") ?? "N/A");

            csvContent.AppendLine($"Cycle Start Date,{startDateFormatted}");
            csvContent.AppendLine($"Cycle End Date,{endDateFormatted}");

            // Write to file
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
            
            // Console feedback
            string cycleInfo = isLastCycle 
                ? $"Cycle End: --, Concurso: {lastNumber}" 
                : $"Cycle End: {endCycleDate}, Concurso: {lastNumber}";
            
            Console.WriteLine($"{cycleInfo} - Output saved to: {fileName}");
        }
        
        private static void EnsureOutputFolderExists()
        {
            if (!Directory.Exists(OutputFolder))
            {
                Directory.CreateDirectory(OutputFolder);
            }
        }
        
        private static string GenerateFileName(DateTime? endCycleDate, int lastNumber, bool isLastCycle)
        {
            if (isLastCycle)
            {
                return $"Cycle_InProgress_Concurso_{lastNumber}.csv";
            }
            
            string dateStr = endCycleDate?.ToString("yyyyMMdd") ?? "Unknown";
            return $"Cycle_{dateStr}_Concurso_{lastNumber}.csv";
        }
    }
}

