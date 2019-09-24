using System;
using Autofac;
using static ConsoleApp1.Service4;
using static ConsoleApp1.TrancientService;
using static  ConsoleApp1.ScopeService;

namespace ConsoleApp1
{
    class Program
    {
        public static IContainer Container { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine($"First value =  {ServiceScope.ToString()}");
            RegisterService();

             Container.Resolve<Service4>();
            
             Container.Resolve<TrancientService>();

             Container.Resolve<SingleService>();

             Container.Resolve<ScopeService>();
             
            Console.WriteLine($"Second Value = {ServiceScope.ToString()}");

        }

        private static void RegisterService()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Service4>();

            builder.RegisterType<SingleService>().SingleInstance();

            builder.RegisterType<TrancientService>().InstancePerDependency();
            
            builder.RegisterType<ScopeService>().InstancePerLifetimeScope();

            Container = builder.Build();
        }
    }
}
