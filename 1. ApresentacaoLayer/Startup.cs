using DataLayer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _1._ApresentacaoLayer
{
	public class StartupDefault
	{
		public IConfiguration Configuration { get; }

		public StartupDefault(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public virtual void ConfigureServices(IServiceCollection services)
		{
			DefaultConfigureServices(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}

		private static void DefaultConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}
	}

	public class StartupDevelopment : StartupDefault
	{
		public StartupDevelopment(IConfiguration configuration): base(configuration)
		{
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			services.AddDbContext<DBContexto>
				(options => options.UseSqlServer(@"Data Source=(LocalDb)\MsSQLLocalDb;Initial Catalog=dev_clinica_medica;User ID=clinicaweb;Password=cl1n1c4m3d1c4"));
		}
	}

	public class StartupProduction : StartupDefault
	{
		private const string CONEXAO_AZURE = "Server=tcp:msilva.database.windows.net,1433;Initial Catalog=clinica_medica;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

		public StartupProduction(IConfiguration configuration) : base(configuration)
		{
		}

		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			services.AddDbContext<DBContexto>
				(options => options.UseSqlServer(CONEXAO_AZURE));
		}
	}

	public class Startup : StartupDefault
	{
		public Startup(IConfiguration configuration) : base(configuration)
		{
		}

		public override void ConfigureServices(IServiceCollection services)
		{
			base.ConfigureServices(services);
			services.AddDbContext<DBContexto>
				(options => options.UseSqlServer(@"Data Source=(LocalDb)\MsSQLLocalDb;Initial Catalog=dev_clinica_medica;User ID=clinicaweb;Password=cl1n1c4m3d1c4"));
		}
	}
}