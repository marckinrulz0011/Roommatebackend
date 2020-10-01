using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roommates.API.Domain.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public int NLikes { get; set; }
        public int NViews { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
