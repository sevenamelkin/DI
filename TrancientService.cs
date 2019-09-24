using Autofac;
using static ConsoleApp1.Program;
using static ConsoleApp1.ScopeService;

namespace ConsoleApp1
{
    public class TrancientService
    {
        public static int ServiceThree { get; set; }
        
        public TrancientService(ScopeService scopeService)
        {
            ServiceThree++;
        }
    }
}