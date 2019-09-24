using Autofac;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class SingleService
    {
        public static int ServiceFirst { get; set; }
        
        public SingleService(TrancientService service)
        {
            ServiceFirst++;
        }
    }
}