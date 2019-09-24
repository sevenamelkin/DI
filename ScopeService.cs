using Autofac.Core;

namespace ConsoleApp1
{
    public class ScopeService
    {
        public static int ServiceScope { get; set; }

        public ScopeService()
        {
            ServiceScope++;
        }
    }
}