using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public int ApertmentId { get; set; }
        public int BuildingId { get; set; }
        public string UserName { get; set; }
    }
}
