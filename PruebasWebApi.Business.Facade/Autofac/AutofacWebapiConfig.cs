﻿using Autofac;
using Autofac.Integration.WebApi;
using PruebasWebApi.Buseniess.Logc;
using PruebasWebApi.DataAcces.Dao;
using PruebasWebApi.DataAcces.Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace PruebasWebApi.Business.Facade.Autofac
{
    public class AutofacWebapiConfig
    {

        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            builder.RegisterType<UserBL>()
            .As<IUserBL>()
            .InstancePerRequest();

            builder.RegisterType<RedisDao>()
              .As<IDao>()
              .InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}