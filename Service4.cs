using System.Security.Cryptography.X509Certificates;
using static ConsoleApp1.Program;
using Autofac;

namespace ConsoleApp1
{
    public class Service4
    {
        public static int ServiceFour { get; set; }
        public int FirstValue { get; set; }

        public Service4()
        {
            ServiceFour++;
             Container.Resolve<ScopeService>();
             Container.Resolve<SingleService>();
             FirstValue = ServiceFour;
        }
    }
}