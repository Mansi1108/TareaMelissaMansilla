using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1061719.Clases
{
    internal sealed class Consola : IServicioSingleton
    {
        Guid IServicios.Id { get; } = Guid.NewGuid();
        public string Nombre() => "Nintendo Switch";
    }

    internal sealed class Consola2 : IServicioSingleton
    {
        Guid IServicios.Id { get; } = Guid.NewGuid();
        public string Nombre() => "Playstation";
    }
}
