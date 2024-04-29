using EFCode.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace EFCode
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _config = builder.Build();
        }


        /*public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<Appdbcontext>(
            options => options.UseSqlServer(_config.GetConnectionString("Mydbconn")));

            services.AddMvc().AddXmlSerializerFormatters();
            //services.AddTransient<IEmployeeRepository, MockEmployeeRepository>();
        }
        */
    }
}
