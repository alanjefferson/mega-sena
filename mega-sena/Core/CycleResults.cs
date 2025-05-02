using mega_sena.Entity;

namespace mega_sena
{
	public class CycleResults
	{
		int numRef = 60;

		public CycleResults(int num = 0) 
		{
			if(num > 0)
				numRef = num;
		}

		public List<Cycle> GetCycleList(List<MegaSena> lstMegaSena)
		{
			Cycle objCycle = new Cycle();
			objCycle.CycleNumbers = createCycleNumbers();

			List<Cycle> lstCycle = new List<Cycle>();
			DateTime? endCycleDate = new DateTime?();
			int lastNumber = 0;

			foreach (MegaSena obj in lstMegaSena)
			{
				if (allNumberHasBeenDrawn(objCycle))
				{
					objCycle.EndCycle = endCycleDate;
					lstCycle.Add(objCycle);

					PrintCycleNumbersTimes(objCycle, endCycleDate, lastNumber);

					Cycle newObjCycle = CreateNewCycleWithLastNumbersDate(objCycle);
					objCycle = newObjCycle;
				}

				FlagCountUpdateDateNumbers(objCycle, obj);

				endCycleDate = obj.DataDoSorteio;
				lastNumber = obj.Concurso;

				if (lstMegaSena.Last().Concurso == obj.Concurso)
				{
					Console.WriteLine(string.Format("Cycle End: --, Concurso: {0}", lastNumber));
					PrintCycleNumbersTimes(objCycle);
				}

			}

			return lstCycle;
		}

		private List<CycleNumber> createCycleNumbers()
		{
			List<CycleNumber> lstCycleNumber = new List<CycleNumber>();

			for (int i = 1; i <= numRef; i++)
			{
				CycleNumber objCycleNumber = new CycleNumber();
				objCycleNumber.Number = i;
				lstCycleNumber.Add(objCycleNumber);
			}

			return lstCycleNumber;
		}

		private bool allNumberHasBeenDrawn(Cycle objCycle)
		{
			foreach (CycleNumber item in objCycle.CycleNumbers)
				if (!item.Drawn)
					return false;

			return true;
		}

		private void FlagCountUpdateDateNumbers(Cycle objCycle, MegaSena obj)
		{
			for (int i = 1; i <= numRef; i++)
			{
				if (obj.Bola1 == i || obj.Bola2 == i || obj.Bola3 == i || obj.Bola4 == i || obj.Bola5 == i || obj.Bola6 == i)
				{
					objCycle.CycleNumbers[i - 1].Drawn = true;
					objCycle.CycleNumbers[i - 1].Times++;
					objCycle.CycleNumbers[i - 1].LastDrawn = obj.DataDoSorteio;
				}
			}
		}

		private void PrintCycleNumbersTimes(Cycle objCycle, DateTime? endCycleDate = null, int lastNumber = 0)
		{
			int clycleTimeNumbersMedium = 0;

			if(endCycleDate != null && lastNumber > 0)
				Console.WriteLine(string.Format("Cycle End: {0}, Concurso: {1}", endCycleDate, lastNumber));

			for (int i = 0; i < 60; i++)
			{
				Console.WriteLine(string.Format("{0} {1} {2}", objCycle.CycleNumbers[i].Number, objCycle.CycleNumbers[i].Times, objCycle.CycleNumbers[i].LastDrawn?.ToString("dd/MM/yyyy")));
				clycleTimeNumbersMedium = clycleTimeNumbersMedium + objCycle.CycleNumbers[i].Times;
			}

			Console.WriteLine(string.Format("clycleTimeNumbersMedium: {0}", (clycleTimeNumbersMedium / 60)));
		}

		private Cycle CreateNewCycleWithLastNumbersDate(Cycle objCycle)
		{
			Cycle newObjCycle = new Cycle();
			newObjCycle.CycleNumbers = createCycleNumbers();

			for (int i = 0; i < numRef; i++)
				newObjCycle.CycleNumbers[i].LastDrawn = objCycle.CycleNumbers[i].LastDrawn;

			return newObjCycle;
		}
	}
}