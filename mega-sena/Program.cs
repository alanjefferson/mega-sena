using mega_sena;
using mega_sena.Core;

List<MegaSena> lstMegaSena = MegaSenaResults.ReadMegaSenaXLSX();

Console.WriteLine(string.Format("Quantidade de Concursos: {0}", lstMegaSena.Count));