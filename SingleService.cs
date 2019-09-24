using Autofac;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class SingleService
    {
        public SingleService()
        {
            var trancientService = Container.Resolve<TrancientService>();
            trancientService.ServiceThree++;
        }
        public int ServiceFirst { get; set; }
    }
}