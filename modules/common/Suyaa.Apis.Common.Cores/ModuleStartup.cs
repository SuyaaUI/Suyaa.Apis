﻿using Microsoft.Extensions.DependencyInjection;
using Suyaa.Microservice;
using Suyaa.Microservice.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Suyaa.Apis.Common.Cores
{
    public class ModuleStartup : IModuleStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddModulerIoc<ModuleStartup>();
            //services.AddModuler<Entities.ModuleStartup>();
        }
    }
}
