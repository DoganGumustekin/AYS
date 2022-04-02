using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Building : IEntity //bina
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int NumberOfApartment { get; set; } //daire sayısı
        public int NumberOfFloors { get; set; } //kat sayısı
        public string Description { get; set; }
    }
}
