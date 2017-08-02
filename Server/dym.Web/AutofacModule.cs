using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using dym.Repository;
using dym.IRepository;
using System.Reflection;

namespace dym.Web
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

            AssemblyName assemblyName = new AssemblyName("dym.Repository");
            Assembly.Load(assemblyName).GetTypes().Where(x => x.GetTypeInfo().IsClass && !x.GetTypeInfo().IsAbstract && !x.GetTypeInfo().IsInterface).ToList().ForEach(
                _t => {
                    builder.RegisterType(_t).As(_t.GetInterfaces());
                }
            );
        }
    }
}
