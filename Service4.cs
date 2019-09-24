using static ConsoleApp1.Program;
using Autofac;

namespace ConsoleApp1
{
    public class Service4
    {
        public int FirstScopeValue { get; set; }

        public Service4()
        {
            var scopeService = Container.Resolve<ScopeService>();
            scopeService.ServiceSecond++;
            var singleService = Container.Resolve<SingleService>();
            singleService.ServiceFirst++;
            FirstScopeValue = scopeService.ServiceSecond;
        }
    }
}