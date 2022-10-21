using System.ComponentModel.DataAnnotations;

namespace Stock_trading.Models
{
    public class Aksje
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Enavn Navn { get; set; }

        public double Pris { get; set; }

        public double Antall { get; set; }
    }
    public enum Enavn
    {
        Apple,
        Amazon,
        Microsoft,
        Meta,
        Netflix
    }
}
