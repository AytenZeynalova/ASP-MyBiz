using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MyBiz.Models
{
    public class Slider
    {
        public int ID { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string BtnText { get; set; }
        public string BtnUrl { get; set; }
        public string Image { get; set; }
    }
}
