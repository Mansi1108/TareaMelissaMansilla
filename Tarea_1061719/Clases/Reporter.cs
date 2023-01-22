using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1061719.Clases
{
    internal sealed class Reporter
    {

        private readonly IServicioSingleton _singletonService;

        public Reporter(IServicioSingleton singletonService) => (_singletonService) =
            (singletonService);

        public void ReportDetails(string lifetimeDetails)
        {
            Console.WriteLine(lifetimeDetails);

            LogService(_singletonService, "Se realizo singleton");
        }

        private static void LogService<T>(T service, string message)
        where T : IServicios =>
        Console.WriteLine(
            $"    {typeof(T).Name}: {service.Id} ({message})");
    }
}
