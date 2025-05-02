using mega_sena;
using mega_sena.Core;
using mega_sena.Entity;

List<MegaSena> lstMegaSena = MegaSenaResults.ReadMegaSenaXLSX();

CycleResults objCycleResults = new CycleResults();
List<Cycle> lstCycle = objCycleResults.GetCycleList(lstMegaSena);
