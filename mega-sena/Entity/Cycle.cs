﻿namespace mega_sena.Entity
{
	public class Cycle
	{
		private DateTime? endCycle;
		private List<CycleNumber>? cycleNumbers;
		
		public DateTime? EndCycle { get => endCycle; set => endCycle = value; }
		public List<CycleNumber> CycleNumbers { get => cycleNumbers == null ? new List<CycleNumber>() : cycleNumbers; set => cycleNumbers = value; }
	}
}