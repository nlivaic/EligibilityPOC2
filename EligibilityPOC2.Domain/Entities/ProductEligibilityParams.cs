using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibilityPOC2.Entities {
    public class ProductEligibilityParams {
        public int ProductId { get; set; }
        public String EligibilityName { get; set; }
        public String ParamName { get; set; }
        public String ParamValue { get; set; }
        public int RuleSet { get; set; }
    }
}
