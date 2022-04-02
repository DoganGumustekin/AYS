using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment : IEntity //ödeme
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BuildingId { get; set; }
        public int ApartmentId { get; set; }
        public int PaymentAmount { get; set; } //ödeme miktarı
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; }
    }
}
