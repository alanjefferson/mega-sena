using mega_sena;
using mega_sena.Core;
using mega_sena.Entity;

List<MegaSena> lstMegaSena = MegaSenaResults.ReadMegaSenaXLSX();

CycleResults objCycleResults = new CycleResults();
List<Cycle> lstCycle = objCycleResults.GetCycleList(lstMegaSena);

// Run analysis
//AnalyzeOneTimeNumbers.Analyze();
//AnalyzeCycleDuration.Analyze();
//AnalyzeThreeNumbersRemaining.Analyze(lstMegaSena);
//AnalyzeDrawsUntilRemainingPicked.Analyze(lstMegaSena);
//AnalyzeFirstRemainingNumber.Analyze(lstMegaSena);
//AnalyzeRemainingNumbers.Analyze(lstMegaSena, 3);

// Test generic predictions - works with any number of remaining numbers!
Console.WriteLine("========================================");
Console.WriteLine("TESTING GENERIC PREDICTIONS");
Console.WriteLine("========================================\n");

// Generate predictions for current cycle (whatever the remaining count is)
PredictNextDraw.GeneratePredictions(lstMegaSena);

