using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumerOfSoap.MyMathService;

namespace ConsumerOfSoap
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            Console.WriteLine("Addition:" + client.Add(5, 5));
            Console.WriteLine("Minus: " + client.Minus(5, 5));
            Console.WriteLine("Divide: " + client.Divide(10, 5));
            Console.WriteLine("Multiply " + client.Multiply(15, 5));

            Console.ReadLine();
        }
    }
}
