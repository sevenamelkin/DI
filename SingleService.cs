using Autofac;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class SingleService
    {
        public SingleService()
        {
            ServiceFirst++;
            Container.Resolve<TrancientService>();
        }
        public static int ServiceFirst { get; set; }
    }
}