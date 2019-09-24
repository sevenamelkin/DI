using Autofac;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class TrancientService
    {
        public int SecondScopeValue { get; set; }

        public TrancientService()
        {
            var scopeService = Container.Resolve<ScopeService>();
            scopeService.ServiceSecond++;
            SecondScopeValue = scopeService.ServiceSecond;
        }

        public int ServiceThree { get; set; }
    }
}