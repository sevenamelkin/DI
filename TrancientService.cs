using Autofac;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class TrancientService
    {
        public int SecondValue { get; set; }

        public TrancientService()
        {
            ServiceThree++;
            Container.Resolve<ScopeService>();
            SecondValue = ServiceThree;
        }

        public static int ServiceThree { get; set; }
    }
}