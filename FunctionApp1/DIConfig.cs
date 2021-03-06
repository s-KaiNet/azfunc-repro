﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AzureFunctions.Autofac.Configuration;

namespace FunctionApp1
{
    public class DIConfig
    {
        public DIConfig()
        {
            DependencyInjection.Initialize(builder =>
            {
                builder.RegisterType<Greeter>().As<IGreet>();
            });
        }
    }
}
