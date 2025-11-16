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
//PredictNextDraw.GeneratePredictions(lstMegaSena);
//AnalyzeFirstRemainingNumber.Analyze(lstMegaSena);

// Test with 3 remaining numbers (current cycle)
AnalyzeRemainingNumbers.Analyze(lstMegaSena, 3);

