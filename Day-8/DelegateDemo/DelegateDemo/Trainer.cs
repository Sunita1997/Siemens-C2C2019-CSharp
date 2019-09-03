using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Trainer
    {
        Assistant assistant;
        public Trainer() { }
        public Trainer(Assistant assistant)
        {
            this.assistant = assistant;
        }
        public Assistant Assistant
        {
            get { return assistant; }
            set { assistant = value; }
        }
        public string GetFacility()
        {
            Facilities facilities
                = new Facilities();
            FacilityInvoker facility = new FacilityInvoker(facilities.GetRemote);

            return assistant.ProvideFacility(facility, 2);
        }
    }
}
