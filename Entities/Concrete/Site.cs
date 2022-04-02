using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Site : IEntity //site
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public int NumberOfBuilding { get; set; } //bina sayısı
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
