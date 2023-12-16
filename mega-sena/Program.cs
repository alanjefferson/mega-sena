using mega_sena;
using mega_sena.Core;
using mega_sena.Entity;

List<MegaSena> lstMegaSena = MegaSenaResults.ReadMegaSenaXLSX();
List<Cycle> lstCycleV2 = CycleResults.GetCycleListV2(lstMegaSena);
//List<Cycle> lstCycle = CycleResults.GetCycleList(lstMegaSena);
