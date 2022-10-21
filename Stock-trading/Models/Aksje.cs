using System.ComponentModel.DataAnnotations;

namespace Stock_trading.Models
{
    public class Aksje
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Navn { get; set; }
        public enum ENavn { Apple, Amazon, Microsoft, Meta, Netflix }

        public double Pris { get; set; }

        public double Antall { get; set; }
    }
}
