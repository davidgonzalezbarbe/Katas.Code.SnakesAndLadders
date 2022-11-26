using Microsoft.Extensions.DependencyInjection;

namespace SnakesAndLadders.Console.DI
{
    public static class Injector
    {
        static IServiceProvider _proveedor;

        public static void GenerarProveedor(IServiceCollection serviceCollection)
        {
            _proveedor = serviceCollection.BuildServiceProvider();
        }

        public static T GetService<T>()
        {
            return _proveedor.GetService<T>();
        }
    }
}
