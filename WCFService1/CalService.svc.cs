using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalService.svc or CalService.svc.cs at the Solution Explorer and start debugging.
    public class CalService : ICalService
    {
       
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a,double b)
        { return a - b; }

    }
}
