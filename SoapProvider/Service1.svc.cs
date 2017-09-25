using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SharedCalculator;
using Math = SharedCalculator.Math;

namespace SoapProvider
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double Add(double a, double b)
        {
            Math MathA = new Math(a, b);
            return MathA.Calculation("+");
        }

        public double Minus(double a, double b)
        {
            Math MathA = new Math(a, b);
            return MathA.Calculation("-");
        }

        public double Multiply(double a, double b)
        {
            Math MathA = new Math(a, b);
            return MathA.Calculation("*");
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                Math MathA = new Math(a, b);
                return MathA.Calculation("/");
            }
        }
    }
}
