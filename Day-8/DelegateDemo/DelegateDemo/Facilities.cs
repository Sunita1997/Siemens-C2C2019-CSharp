using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate string FacilityInvoker(int number);
    class Facilities
    {
        public string GetMarker(int count)
        {
            return $"got {count} markers";
        }
        public string GetRemote(int count)
        {
            return $"got {count} remotes";
        }
    }
}
