using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MyBiz.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Professionid { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }

        public Profession Profession { get; set; }
    }
}
