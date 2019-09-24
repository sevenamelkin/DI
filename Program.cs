using System;
using Autofac;
using static ConsoleApp1.Service4;

namespace ConsoleApp1
{
    class Program
    {
        public static IContainer Container { get; private set; }

        static void Main(string[] args)
        {
            RegisterService();

            var service1 = Container.Resolve<SingleService>();

            var service2 = Container.Resolve<TrancientService>();

            var service3 = Container.Resolve<ScopeService>();

            var service4 = Container.Resolve<Service4>();
            
            Console.WriteLine($"First value = {service4.FirstValue.ToString()}");
            Console.WriteLine($"Second value = {service2.SecondValue.ToString()}");
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
