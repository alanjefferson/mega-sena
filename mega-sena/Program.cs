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
//PredictNextDraw.GeneratePredictions(lstMegaSena);
//AnalyzeFirstRemainingNumber.Analyze(lstMegaSena);

// Analyze how many draws until one of the 3 remaining is picked
AnalyzeDrawsUntilRemainingPicked.Analyze(lstMegaSena);
