using System;
using DataLayer.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace _1._ApresentacaoLayer
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IWebHost host = CreateWebHostBuilder(args).Build();
			using (IServiceScope scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;

				try
				{
					var context = services.GetRequiredService<DBContexto>();
					DbInitializer.Initialize(context);
				}
				catch (Exception ex)
				{
					var logger = services.GetRequiredService<ILogger<Program>>();
					logger.LogError(ex, "Erro ao preencher dados padrão no database.");
				}
			}

			host.Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
