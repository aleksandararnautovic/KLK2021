using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Product
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime ExpityData { get; set; }
    }
}
