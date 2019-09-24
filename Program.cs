using System;
using Autofac;

namespace ConsoleApp1
{
    class Program
    {
        public static IContainer Container { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RegisterService();

            var service1 = Container.Resolve<SingleService>();

            var service2 = Container.Resolve<TrancientService>();

            var service3 = Container.Resolve<LifeTimeService>();
            

            service1.ServiceFirst = 1;
            service2.ServiceSecond = 1;
            service3.ServiceThree = 1;

            var service11 = Container.Resolve<SingleService>();
            var service22 = Container.Resolve<TrancientService>();
            var service33 = Container.Resolve<LifeTimeService>();

            service11.ServiceFirst++;
            service22.ServiceSecond++;
            service33.ServiceThree++;

            Console.WriteLine($"Singleton = {service1.ServiceFirst.ToString()} and {service11.ServiceFirst.ToString()}");
            Console.WriteLine($"Trancient = {service2.ServiceSecond.ToString()} and {service22.ServiceSecond.ToString()}");
            Console.WriteLine($"LifeTime = {service3.ServiceThree.ToString()} and {service33.ServiceThree.ToString()}");
        }

        private static void RegisterService()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SingleService>().SingleInstance();

            builder.RegisterType<TrancientService>().InstancePerDependency();

            builder.RegisterType<LifeTimeService>().InstancePerLifetimeScope();

            Container = builder.Build();
        }
    }
}
