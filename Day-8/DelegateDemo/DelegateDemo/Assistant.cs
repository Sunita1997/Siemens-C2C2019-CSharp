using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Assistant
    {
        public string ProvideFacility(FacilityInvoker facilityInvoker, int args)
        {
            string returnValue = facilityInvoker.Invoke(args);
            return returnValue;
        }
    }
}
