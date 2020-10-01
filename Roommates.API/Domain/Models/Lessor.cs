using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roommates.API.Domain.Models
{
    public class Lessor
    {
        public int lessorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Dni { get; set; }
        public string Telephone { get; set; }
        public string sexo { get; set; }
        public string dateBirthday { get; set; }
    }
}
