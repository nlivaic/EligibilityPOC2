using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibilityPOC2.Entities {
    public class ProductData {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int Type { get; set; }
    }
}
