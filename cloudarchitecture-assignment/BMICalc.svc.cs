using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace cloudarchitecture_assignment
{
    public class Service1 : BMICalc
    {

        public string BMIResult(double height, double weight, string gender)
        {
            double BMI = weight / Math.Pow(height / 100.0, 2); //calculate the BMI and store as double

            if (gender == "female") //if user is female, display result based on these values
            {
                if (BMI < 19)
                {
                    return "you are underweight";
                }
                if (BMI >= 19 & BMI <= 24)
                {
                    return "you are a normal weight";
                }
                if (BMI > 24)
                {
                    return "you are overweight";
                }

            } else //if user is male, display result based on these values
            {
                if (BMI < 20)
                {
                    return "you are underweight";
                }
                if (BMI >= 20 & BMI <= 25)
                {
                    return "you are a normal weight";
                }
                if (BMI > 25)
                {
                    return "you are overweight";
                }
            }
            return null; //if user doesnt specify wether they are male or female, return null;

        }


    }
}
