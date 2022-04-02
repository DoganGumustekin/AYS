using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Apartment : IEntity //daire
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public int FloorLocation { get; set; } //bulunduğu kat
        public string Description { get; set; } //daire özellikleri, kalınabilecek max kişi sayısı, kaç+kaç vs.
    }
}
