namespace SorteioCopa.Models
{
    public class PotePais
    {
        public int Id { get; set; }
        public int IdPote { get; set; }
        public int IdPais { get; set; }
        public paises paises { get; set; }
        public potes potes { get; set; }

    }
}
