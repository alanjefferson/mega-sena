using System.Collections.Generic;

namespace mega_sena.Models
{
    /// <summary>
    /// Represents a complete 6-number betting prediction for Mega-Sena,
    /// including the rationale/strategy behind the number selection.
    /// </summary>
    public class Prediction
    {
        public List<int> Numbers { get; set; } = new List<int>();
        public string Rationale { get; set; } = string.Empty;
    }
}

