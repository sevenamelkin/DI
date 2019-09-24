using System;
using Autofac;

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

            Console.WriteLine($"First Scope Value = {service4.FirstScopeValue.ToString()}");
            Console.WriteLine($"Second Scope Value = {service2.SecondScopeValue.ToString()}");
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
