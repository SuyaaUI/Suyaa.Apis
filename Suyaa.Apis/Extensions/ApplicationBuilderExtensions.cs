using Microsoft.AspNetCore.Builder;
using Suyaa.Apis.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyaa.Apis.Extensions
{
    /// <summary>
    /// 应用程序构建帮助
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// 使用Api集合
        /// </summary>
        /// <param name="app"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseApis(this IApplicationBuilder app, string path) => app.UseMiddleware<ApisMiddleware>(new object[] { path });
    }
}
