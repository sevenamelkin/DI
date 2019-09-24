using System.Security.Cryptography.X509Certificates;
using static ConsoleApp1.Program;
using static ConsoleApp1.ScopeService;
using Autofac;

namespace ConsoleApp1
{
    public class Service4
    {
        public static int ServiceFour { get; set; }

        public Service4(ScopeService scopeService, SingleService singleService)
        {
            ServiceFour++;
        }
    }
}