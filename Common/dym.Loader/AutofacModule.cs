using System;
using System.Linq;
using Autofac;
using System.Reflection;

namespace dym.Loader
{
    public class AutofacModule : Autofac.Module
    {
        //注意以下写法
        //builder.RegisterType<GuidTransientAppService>().As<IGuidTransientAppService>();
        //builder.RegisterType<GuidScopedAppService>().As<IGuidScopedAppService>().InstancePerLifetimeScope();
        //builder.RegisterType<GuidSingletonAppService>().As<IGuidSingletonAppService>().SingleInstance();

        protected override void Load(ContainerBuilder builder)
        {
            // The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            // It was then registered with Autofac using the Populate method in ConfigureServices.

            //builder.Register(c => new ValuesService(c.Resolve<ILogger<ValuesService>>()))
            //    .As<IValuesService>()
            //    .InstancePerLifetimeScope();
            // builder.RegisterType<BaseRepository>().As<IBaseRepository>();
            Const.AppSettings.IocDll.ForEach(d=> {
                AssemblyName assemblyName = new AssemblyName(d);
                Assembly.Load(assemblyName).GetTypes().Where(x => x.GetTypeInfo().IsClass && !x.GetTypeInfo().IsAbstract && !x.GetTypeInfo().IsInterface).ToList().ForEach(
                    _t =>
                    {
                        builder.RegisterType(_t).As(_t.GetInterfaces());
                    }
                );
            });
        }
    }
}
