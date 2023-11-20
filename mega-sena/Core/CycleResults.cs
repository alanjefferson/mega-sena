using mega_sena.Entity;

namespace mega_sena
{
	public static class CycleResults
	{
	
		public static List<Cycle>  GetCycleList(List<MegaSena> lstMegaSena)
		{
			Cycle objCycle = new Cycle();
			List<Cycle> lstCycle = new List<Cycle>();
			DateTime? endCycleDate = new DateTime?();
			int lastNumber = 0;

			foreach (MegaSena obj in lstMegaSena)
			{
				if (
					objCycle.Number01 == true && objCycle.Number02 == true && objCycle.Number03 == true && objCycle.Number04 == true && objCycle.Number05 == true &&
					objCycle.Number06 == true && objCycle.Number07 == true && objCycle.Number08 == true && objCycle.Number09 == true && objCycle.Number10 == true &&
					objCycle.Number11 == true && objCycle.Number12 == true && objCycle.Number13 == true && objCycle.Number14 == true && objCycle.Number15 == true &&
					objCycle.Number16 == true && objCycle.Number17 == true && objCycle.Number18 == true && objCycle.Number19 == true && objCycle.Number20 == true &&
					objCycle.Number21 == true && objCycle.Number22 == true && objCycle.Number23 == true && objCycle.Number24 == true && objCycle.Number25 == true &&
					objCycle.Number26 == true && objCycle.Number27 == true && objCycle.Number28 == true && objCycle.Number29 == true && objCycle.Number30 == true &&
					objCycle.Number31 == true && objCycle.Number32 == true && objCycle.Number33 == true && objCycle.Number34 == true && objCycle.Number35 == true &&
					objCycle.Number36 == true && objCycle.Number37 == true && objCycle.Number38 == true && objCycle.Number39 == true && objCycle.Number40 == true &&
					objCycle.Number41 == true && objCycle.Number42 == true && objCycle.Number43 == true && objCycle.Number44 == true && objCycle.Number45 == true &&
					objCycle.Number46 == true && objCycle.Number47 == true && objCycle.Number48 == true && objCycle.Number49 == true && objCycle.Number50 == true &&
					objCycle.Number51 == true && objCycle.Number52 == true && objCycle.Number53 == true && objCycle.Number54 == true && objCycle.Number55 == true &&
					objCycle.Number56 == true && objCycle.Number57 == true && objCycle.Number58 == true && objCycle.Number59 == true && objCycle.Number60 == true
					)
				{
					objCycle.EndCycle = endCycleDate;
					lstCycle.Add(objCycle);
					objCycle = new Cycle();
					Console.WriteLine(string.Format("Cycle End: {0}, Concurso: {1}", endCycleDate, lastNumber));
				}

				if (obj.Bola1 == 1 || obj.Bola2 == 1 || obj.Bola3 == 1 || obj.Bola4 == 1 || obj.Bola5 == 1 || obj.Bola6 == 1) objCycle.Number01 = true;
				if (obj.Bola1 == 2 || obj.Bola2 == 2 || obj.Bola3 == 2 || obj.Bola4 == 2 || obj.Bola5 == 2 || obj.Bola6 == 2) objCycle.Number02 = true;
				if (obj.Bola1 == 3 || obj.Bola2 == 3 || obj.Bola3 == 3 || obj.Bola4 == 3 || obj.Bola5 == 3 || obj.Bola6 == 3) objCycle.Number03 = true;
				if (obj.Bola1 == 4 || obj.Bola2 == 4 || obj.Bola3 == 4 || obj.Bola4 == 4 || obj.Bola5 == 4 || obj.Bola6 == 4) objCycle.Number04 = true;
				if (obj.Bola1 == 5 || obj.Bola2 == 5 || obj.Bola3 == 5 || obj.Bola4 == 5 || obj.Bola5 == 5 || obj.Bola6 == 5) objCycle.Number05 = true;
				if (obj.Bola1 == 6 || obj.Bola2 == 6 || obj.Bola3 == 6 || obj.Bola4 == 6 || obj.Bola5 == 6 || obj.Bola6 == 6) objCycle.Number06 = true;
				if (obj.Bola1 == 7 || obj.Bola2 == 7 || obj.Bola3 == 7 || obj.Bola4 == 7 || obj.Bola5 == 7 || obj.Bola6 == 7) objCycle.Number07 = true;
				if (obj.Bola1 == 8 || obj.Bola2 == 8 || obj.Bola3 == 8 || obj.Bola4 == 8 || obj.Bola5 == 8 || obj.Bola6 == 8) objCycle.Number08 = true;
				if (obj.Bola1 == 9 || obj.Bola2 == 9 || obj.Bola3 == 9 || obj.Bola4 == 9 || obj.Bola5 == 9 || obj.Bola6 == 9) objCycle.Number09 = true;
				if (obj.Bola1 == 10 || obj.Bola2 == 10 || obj.Bola3 == 10 || obj.Bola4 == 10 || obj.Bola5 == 10 || obj.Bola6 == 10) objCycle.Number10 = true;

				if (obj.Bola1 == 11 || obj.Bola2 == 11 || obj.Bola3 == 11 || obj.Bola4 == 11 || obj.Bola5 == 11 || obj.Bola6 == 11) objCycle.Number11 = true;
				if (obj.Bola1 == 12 || obj.Bola2 == 12 || obj.Bola3 == 12 || obj.Bola4 == 12 || obj.Bola5 == 12 || obj.Bola6 == 12) objCycle.Number12 = true;
				if (obj.Bola1 == 13 || obj.Bola2 == 13 || obj.Bola3 == 13 || obj.Bola4 == 13 || obj.Bola5 == 13 || obj.Bola6 == 13) objCycle.Number13 = true;
				if (obj.Bola1 == 14 || obj.Bola2 == 14 || obj.Bola3 == 14 || obj.Bola4 == 14 || obj.Bola5 == 14 || obj.Bola6 == 14) objCycle.Number14 = true;
				if (obj.Bola1 == 15 || obj.Bola2 == 15 || obj.Bola3 == 15 || obj.Bola4 == 15 || obj.Bola5 == 15 || obj.Bola6 == 15) objCycle.Number15 = true;
				if (obj.Bola1 == 16 || obj.Bola2 == 16 || obj.Bola3 == 16 || obj.Bola4 == 16 || obj.Bola5 == 16 || obj.Bola6 == 16) objCycle.Number16 = true;
				if (obj.Bola1 == 17 || obj.Bola2 == 17 || obj.Bola3 == 17 || obj.Bola4 == 17 || obj.Bola5 == 17 || obj.Bola6 == 17) objCycle.Number17 = true;
				if (obj.Bola1 == 18 || obj.Bola2 == 18 || obj.Bola3 == 18 || obj.Bola4 == 18 || obj.Bola5 == 18 || obj.Bola6 == 18) objCycle.Number18 = true;
				if (obj.Bola1 == 19 || obj.Bola2 == 19 || obj.Bola3 == 19 || obj.Bola4 == 19 || obj.Bola5 == 19 || obj.Bola6 == 19) objCycle.Number19 = true;
				if (obj.Bola1 == 20 || obj.Bola2 == 20 || obj.Bola3 == 20 || obj.Bola4 == 20 || obj.Bola5 == 20 || obj.Bola6 == 20) objCycle.Number20 = true;

				if (obj.Bola1 == 21 || obj.Bola2 == 21 || obj.Bola3 == 21 || obj.Bola4 == 21 || obj.Bola5 == 21 || obj.Bola6 == 21) objCycle.Number21 = true;
				if (obj.Bola1 == 22 || obj.Bola2 == 22 || obj.Bola3 == 22 || obj.Bola4 == 22 || obj.Bola5 == 22 || obj.Bola6 == 22) objCycle.Number22 = true;
				if (obj.Bola1 == 23 || obj.Bola2 == 23 || obj.Bola3 == 23 || obj.Bola4 == 23 || obj.Bola5 == 23 || obj.Bola6 == 23) objCycle.Number23 = true;
				if (obj.Bola1 == 24 || obj.Bola2 == 24 || obj.Bola3 == 24 || obj.Bola4 == 24 || obj.Bola5 == 24 || obj.Bola6 == 24) objCycle.Number24 = true;
				if (obj.Bola1 == 25 || obj.Bola2 == 25 || obj.Bola3 == 25 || obj.Bola4 == 25 || obj.Bola5 == 25 || obj.Bola6 == 25) objCycle.Number25 = true;
				if (obj.Bola1 == 26 || obj.Bola2 == 26 || obj.Bola3 == 26 || obj.Bola4 == 26 || obj.Bola5 == 26 || obj.Bola6 == 26) objCycle.Number26 = true;
				if (obj.Bola1 == 27 || obj.Bola2 == 27 || obj.Bola3 == 27 || obj.Bola4 == 27 || obj.Bola5 == 27 || obj.Bola6 == 27) objCycle.Number27 = true;
				if (obj.Bola1 == 28 || obj.Bola2 == 28 || obj.Bola3 == 28 || obj.Bola4 == 28 || obj.Bola5 == 28 || obj.Bola6 == 28) objCycle.Number28 = true;
				if (obj.Bola1 == 29 || obj.Bola2 == 29 || obj.Bola3 == 29 || obj.Bola4 == 29 || obj.Bola5 == 29 || obj.Bola6 == 29) objCycle.Number29 = true;
				if (obj.Bola1 == 30 || obj.Bola2 == 30 || obj.Bola3 == 30 || obj.Bola4 == 30 || obj.Bola5 == 30 || obj.Bola6 == 30) objCycle.Number30 = true;

				if (obj.Bola1 == 31 || obj.Bola2 == 31 || obj.Bola3 == 31 || obj.Bola4 == 31 || obj.Bola5 == 31 || obj.Bola6 == 31) objCycle.Number31 = true;
				if (obj.Bola1 == 32 || obj.Bola2 == 32 || obj.Bola3 == 32 || obj.Bola4 == 32 || obj.Bola5 == 32 || obj.Bola6 == 32) objCycle.Number32 = true;
				if (obj.Bola1 == 33 || obj.Bola2 == 33 || obj.Bola3 == 33 || obj.Bola4 == 33 || obj.Bola5 == 33 || obj.Bola6 == 33) objCycle.Number33 = true;
				if (obj.Bola1 == 34 || obj.Bola2 == 34 || obj.Bola3 == 34 || obj.Bola4 == 34 || obj.Bola5 == 34 || obj.Bola6 == 34) objCycle.Number34 = true;
				if (obj.Bola1 == 35 || obj.Bola2 == 35 || obj.Bola3 == 35 || obj.Bola4 == 35 || obj.Bola5 == 35 || obj.Bola6 == 35) objCycle.Number35 = true;
				if (obj.Bola1 == 36 || obj.Bola2 == 36 || obj.Bola3 == 36 || obj.Bola4 == 36 || obj.Bola5 == 36 || obj.Bola6 == 36) objCycle.Number36 = true;
				if (obj.Bola1 == 37 || obj.Bola2 == 37 || obj.Bola3 == 37 || obj.Bola4 == 37 || obj.Bola5 == 37 || obj.Bola6 == 37) objCycle.Number37 = true;
				if (obj.Bola1 == 38 || obj.Bola2 == 38 || obj.Bola3 == 38 || obj.Bola4 == 38 || obj.Bola5 == 38 || obj.Bola6 == 38) objCycle.Number38 = true;
				if (obj.Bola1 == 39 || obj.Bola2 == 39 || obj.Bola3 == 39 || obj.Bola4 == 39 || obj.Bola5 == 39 || obj.Bola6 == 39) objCycle.Number39 = true;
				if (obj.Bola1 == 40 || obj.Bola2 == 40 || obj.Bola3 == 40 || obj.Bola4 == 40 || obj.Bola5 == 40 || obj.Bola6 == 40) objCycle.Number40 = true;

				if (obj.Bola1 == 41 || obj.Bola2 == 41 || obj.Bola3 == 41 || obj.Bola4 == 41 || obj.Bola5 == 41 || obj.Bola6 == 41) objCycle.Number41 = true;
				if (obj.Bola1 == 42 || obj.Bola2 == 42 || obj.Bola3 == 42 || obj.Bola4 == 42 || obj.Bola5 == 42 || obj.Bola6 == 42) objCycle.Number42 = true;
				if (obj.Bola1 == 43 || obj.Bola2 == 43 || obj.Bola3 == 43 || obj.Bola4 == 43 || obj.Bola5 == 43 || obj.Bola6 == 43) objCycle.Number43 = true;
				if (obj.Bola1 == 44 || obj.Bola2 == 44 || obj.Bola3 == 44 || obj.Bola4 == 44 || obj.Bola5 == 44 || obj.Bola6 == 44) objCycle.Number44 = true;
				if (obj.Bola1 == 45 || obj.Bola2 == 45 || obj.Bola3 == 45 || obj.Bola4 == 45 || obj.Bola5 == 45 || obj.Bola6 == 45) objCycle.Number45 = true;
				if (obj.Bola1 == 46 || obj.Bola2 == 46 || obj.Bola3 == 46 || obj.Bola4 == 46 || obj.Bola5 == 46 || obj.Bola6 == 46) objCycle.Number46 = true;
				if (obj.Bola1 == 47 || obj.Bola2 == 47 || obj.Bola3 == 47 || obj.Bola4 == 47 || obj.Bola5 == 47 || obj.Bola6 == 47) objCycle.Number47 = true;
				if (obj.Bola1 == 48 || obj.Bola2 == 48 || obj.Bola3 == 48 || obj.Bola4 == 48 || obj.Bola5 == 48 || obj.Bola6 == 48) objCycle.Number48 = true;
				if (obj.Bola1 == 49 || obj.Bola2 == 49 || obj.Bola3 == 49 || obj.Bola4 == 49 || obj.Bola5 == 49 || obj.Bola6 == 49) objCycle.Number49 = true;
				if (obj.Bola1 == 50 || obj.Bola2 == 50 || obj.Bola3 == 50 || obj.Bola4 == 50 || obj.Bola5 == 50 || obj.Bola6 == 50) objCycle.Number50 = true;

				if (obj.Bola1 == 51 || obj.Bola2 == 51 || obj.Bola3 == 51 || obj.Bola4 == 51 || obj.Bola5 == 51 || obj.Bola6 == 51) objCycle.Number51 = true;
				if (obj.Bola1 == 52 || obj.Bola2 == 52 || obj.Bola3 == 52 || obj.Bola4 == 52 || obj.Bola5 == 52 || obj.Bola6 == 52) objCycle.Number52 = true;
				if (obj.Bola1 == 53 || obj.Bola2 == 53 || obj.Bola3 == 53 || obj.Bola4 == 53 || obj.Bola5 == 53 || obj.Bola6 == 53) objCycle.Number53 = true;
				if (obj.Bola1 == 54 || obj.Bola2 == 54 || obj.Bola3 == 54 || obj.Bola4 == 54 || obj.Bola5 == 54 || obj.Bola6 == 54) objCycle.Number54 = true;
				if (obj.Bola1 == 55 || obj.Bola2 == 55 || obj.Bola3 == 55 || obj.Bola4 == 55 || obj.Bola5 == 55 || obj.Bola6 == 55) objCycle.Number55 = true;
				if (obj.Bola1 == 56 || obj.Bola2 == 56 || obj.Bola3 == 56 || obj.Bola4 == 56 || obj.Bola5 == 56 || obj.Bola6 == 56) objCycle.Number56 = true;
				if (obj.Bola1 == 57 || obj.Bola2 == 57 || obj.Bola3 == 57 || obj.Bola4 == 57 || obj.Bola5 == 57 || obj.Bola6 == 57) objCycle.Number57 = true;
				if (obj.Bola1 == 58 || obj.Bola2 == 58 || obj.Bola3 == 58 || obj.Bola4 == 58 || obj.Bola5 == 58 || obj.Bola6 == 58) objCycle.Number58 = true;
				if (obj.Bola1 == 59 || obj.Bola2 == 59 || obj.Bola3 == 59 || obj.Bola4 == 59 || obj.Bola5 == 59 || obj.Bola6 == 59) objCycle.Number59 = true;
				if (obj.Bola1 == 60 || obj.Bola2 == 60 || obj.Bola3 == 60 || obj.Bola4 == 60 || obj.Bola5 == 60 || obj.Bola6 == 60) objCycle.Number60 = true;

				endCycleDate = obj.DataDoSorteio;
				lastNumber = obj.Concurso;

				if (lstMegaSena.Last().Concurso == obj.Concurso)
					PrintLeftNumbers(objCycle);
				
			}

			return lstCycle;
		}

		private static void PrintLeftNumbers(Cycle objCycle)
		{
			if (!objCycle.Number01) Console.WriteLine("01"); //TO-DO: Get the least raflle numbers inside the cycle
			if (!objCycle.Number02) Console.WriteLine("02");
			if (!objCycle.Number03) Console.WriteLine("03");
			if (!objCycle.Number04) Console.WriteLine("04");
			if (!objCycle.Number05) Console.WriteLine("05");
			if (!objCycle.Number06) Console.WriteLine("06");
			if (!objCycle.Number07) Console.WriteLine("07");
			if (!objCycle.Number08) Console.WriteLine("08");
			if (!objCycle.Number09) Console.WriteLine("09");
			if (!objCycle.Number10) Console.WriteLine("10");
			if (!objCycle.Number11) Console.WriteLine("11");
			if (!objCycle.Number12) Console.WriteLine("12");
			if (!objCycle.Number13) Console.WriteLine("13");
			if (!objCycle.Number14) Console.WriteLine("14");
			if (!objCycle.Number15) Console.WriteLine("15");
			if (!objCycle.Number16) Console.WriteLine("16");
			if (!objCycle.Number17) Console.WriteLine("17");
			if (!objCycle.Number18) Console.WriteLine("18");
			if (!objCycle.Number19) Console.WriteLine("19");
			if (!objCycle.Number20) Console.WriteLine("20");
			if (!objCycle.Number21) Console.WriteLine("21");
			if (!objCycle.Number22) Console.WriteLine("22");
			if (!objCycle.Number23) Console.WriteLine("23");
			if (!objCycle.Number24) Console.WriteLine("24");
			if (!objCycle.Number25) Console.WriteLine("25");
			if (!objCycle.Number26) Console.WriteLine("26");
			if (!objCycle.Number27) Console.WriteLine("27");
			if (!objCycle.Number28) Console.WriteLine("28");
			if (!objCycle.Number29) Console.WriteLine("29");
			if (!objCycle.Number30) Console.WriteLine("30");
			if (!objCycle.Number31) Console.WriteLine("31");
			if (!objCycle.Number32) Console.WriteLine("32");
			if (!objCycle.Number33) Console.WriteLine("33");
			if (!objCycle.Number34) Console.WriteLine("34");
			if (!objCycle.Number35) Console.WriteLine("35");
			if (!objCycle.Number36) Console.WriteLine("36");
			if (!objCycle.Number37) Console.WriteLine("37");
			if (!objCycle.Number38) Console.WriteLine("38");
			if (!objCycle.Number39) Console.WriteLine("39");
			if (!objCycle.Number40) Console.WriteLine("40");
			if (!objCycle.Number41) Console.WriteLine("41");
			if (!objCycle.Number42) Console.WriteLine("42");
			if (!objCycle.Number43) Console.WriteLine("43");
			if (!objCycle.Number44) Console.WriteLine("44");
			if (!objCycle.Number45) Console.WriteLine("45");
			if (!objCycle.Number46) Console.WriteLine("46");
			if (!objCycle.Number47) Console.WriteLine("47");
			if (!objCycle.Number48) Console.WriteLine("48");
			if (!objCycle.Number49) Console.WriteLine("49");
			if (!objCycle.Number50) Console.WriteLine("50");
			if (!objCycle.Number51) Console.WriteLine("51");
			if (!objCycle.Number52) Console.WriteLine("52");
			if (!objCycle.Number53) Console.WriteLine("53");
			if (!objCycle.Number54) Console.WriteLine("54");
			if (!objCycle.Number55) Console.WriteLine("55");
			if (!objCycle.Number56) Console.WriteLine("56");
			if (!objCycle.Number57) Console.WriteLine("57");
			if (!objCycle.Number58) Console.WriteLine("58");
			if (!objCycle.Number59) Console.WriteLine("59");
			if (!objCycle.Number60) Console.WriteLine("60");
		}
	}
}
