using MusicInstrumentsApp.Models;
using System.Xml.Serialization;

namespace MusicInstrumentsApp
{
    // XML требует отдельный корневой класс
    [XmlRoot("MusicCatalog")]
    public class XmlCatalogWrapper
    {
        [XmlArray("Instruments")]
        [XmlArrayItem("Instrument")]
        public List<XmlInstrument> Instruments { get; set; } = new();

        public MusicCatalog ToCatalog() => new()
        {
            Instruments = Instruments.Select(i => new Instrument
            {
                Id = i.Id,
                Name = i.Name,
                Price = i.Price,
                InStock = i.InStock,
                Category = new Category { Id = i.Category.Id, Name = i.Category.Name },
                Manufacturer = new Manufacturer
                {
                    Id = i.Manufacturer.Id,
                    Name = i.Manufacturer.Name,
                    Country = i.Manufacturer.Country
                }
            }).ToList()
        };
    }

    public class XmlInstrument
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Price { get; set; }
        public bool InStock { get; set; }
        public XmlCategory Category { get; set; } = new();
        public XmlManufacturer Manufacturer { get; set; } = new();
    }

    public class XmlCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }

    public class XmlManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Country { get; set; } = "";
    }

    // JSON обёртка для корневого объекта
    public class JsonRootWrapper
    {
        public MusicCatalog? MusicCatalog { get; set; }
    }
}