using Autofac.Core;

namespace ConsoleApp1
{
    public class ScopeService
    {
        public static int ServiceSecond { get; set; }

        public ScopeService()
        {
            ServiceSecond++;
        }
    }
}