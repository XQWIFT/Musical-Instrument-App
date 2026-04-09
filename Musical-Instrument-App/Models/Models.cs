namespace MusicInstrumentsApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }

    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Country { get; set; } = "";
    }

    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Price { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; } = new();
        public Manufacturer Manufacturer { get; set; } = new();
    }

    public class MusicCatalog
    {
        public List<Instrument> Instruments { get; set; } = new();
    }
}