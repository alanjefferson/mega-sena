using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using mega_sena.Entity;

namespace mega_sena.Core
{
	public static class MegaSenaResults
	{
		public static List<MegaSena> ReadMegaSenaXLSX()
		{
            List<MegaSena> lstMegaSena = new List<MegaSena>();

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open("C:\\mega-sena\\Mega-Sena.xlsx", false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                int rowNumber = 0;

                foreach (Row r in sheetData.Elements<Row>())
                {
                    int colNumber = 0;
                    MegaSena objMegaSena = new MegaSena();

                    if (rowNumber > 0)
                    {
                        foreach (Cell c in r.Elements<Cell>())
                        {
                            objMegaSena = MegaSenaFormat.LinhaConcurso(colNumber, c.InnerText, objMegaSena);
                            colNumber++;
                        }
                    }

                    if (rowNumber > 0)
                    {
                        //Console.WriteLine(string.Format("Reading - Concurso: {0}", objMegaSena.Concurso));
                        lstMegaSena.Add(objMegaSena);
                    }

                    rowNumber++;
                }
            }
            
            return lstMegaSena;
		}
	}
}
