using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roommates.API.Domain.Models
{
    public class Reservation
    {
        public int Id { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public int price { set; get; }
    }
}
