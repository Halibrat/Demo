using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ConsultingDemo.Business.Abstract;
using ConsultingDemo.Business.Concrete;
using ConsultingDemo.DataAccess.Abstract;
using ConsultingDemo.DataAccess.Concrete.EntityFramework;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Business.DependecyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<STIManager>().As<ISTIService>().SingleInstance();
            builder.RegisterType<EfSTIDal>().As<ISTIDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();  

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector() 
                }).SingleInstance();
        }
    }
}
