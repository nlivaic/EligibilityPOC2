using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibilityPOC2.Entities {
    public interface IEligibility {
        bool IsEligible();
        void AddEligibility();
    }
}
