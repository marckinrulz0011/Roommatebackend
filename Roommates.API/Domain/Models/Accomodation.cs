using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roommates.API.Domain.Models
{
    public class Accomodation
    {
        public int Id { set; get; }
        public string Addres { set; get; }
        public string Description { set; get; }
        public int NBedrooms { set; get; }
        public int NBathrooms { set; get; }
        public int NSquareMeter { set; get;}
        public int NKitchen { get; set; }
        public int NRoom { get; set;}
        public int Price { set; get; }
    }
}
