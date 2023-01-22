using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1061719
{
    public interface IServicioSingleton : IServicios
    {
        ServiceLifetime IServicios.serviceLifetime => ServiceLifetime.Singleton;
        string Nombre();
    }
}
