using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace cloudarchitecture_assignment
{
    [ServiceContract]
    public interface BMICalc
    {
        //Defining the methods that can be used within the main code.
        [OperationContract]
        string BMIResult(double height, double weight, string gender);

    }

}
