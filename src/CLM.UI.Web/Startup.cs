using CLMData.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CLMData.Interface.Services;
using CLMService.Service;
using CLMData.Interface.Repository;
using CLMData.Repository;

namespace CLM.UI.Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<CLMContext>(
			options => options.UseSqlServer(
			Configuration.GetConnectionString("DefaultConnection")));
			// Add application services.
			
			services.AddMvc();
			services.AddScoped<IMedicoRepository, MedicoRepository>();
			services.AddScoped<IPacienteRepository, PacienteRepository>();
			services.AddScoped<IMedicoService, MedicoService>();
			services.AddScoped<IPacienteService, PacienteService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseAuthentication();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
