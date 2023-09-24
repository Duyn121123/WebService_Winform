using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalService" in both code and config file together.
    [ServiceContract]
    public interface ICalService
    {
        [OperationContract]
        // Khai báo hàm cần viết tại đây
       double Add(double a, double b);
        [OperationContract]
        double Sub(double a, double b);

    }

}
