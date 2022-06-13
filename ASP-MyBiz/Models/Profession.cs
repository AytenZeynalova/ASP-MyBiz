using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MyBiz.Models
{
    public class Profession
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Team> Teams { get; set; }
    }
}
