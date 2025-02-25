using EterLibrary.Application.Services;
using EterLibrary.Domain.Interfaces;
using EterLibrary.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EterPharmaPro.Infrastructure
{
	public static class DependencyInjection
	{
		private static ServiceProvider _serviceProvider;

		public static void ConfigureServices()
		{
			var services = new ServiceCollection();


			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

			services.AddScoped<UserService>();


			_serviceProvider = services.BuildServiceProvider();
		}

		public static T GetService<T>()
		{
			return _serviceProvider.GetRequiredService<T>();
		}
	}
}
