using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1061719.Clases
{
    internal sealed class Control : IServicioScoped
    {
        private readonly IEnumerable<IServicioSingleton> _consolas;
        Guid IServicios.Id { get; } = Guid.NewGuid();

        public string PerteneceA() => "Joycon - NS";

        public Control(IEnumerable<IServicioSingleton> consolas)
        {
            _consolas = consolas;
        }

        public void consola()
        {
            Console.WriteLine(_consolas);
        }

    }
    internal sealed class Control2 : IServicioScoped
    {
        private readonly IEnumerable<IServicioSingleton> _consolas;
        Guid IServicios.Id { get; } = Guid.NewGuid();

        public string PerteneceA() => "DualShock - PS5";

        public Control2(IEnumerable<IServicioSingleton> consolas)
        {
            _consolas = consolas;
        }

        public void consola()
        {
            Console.WriteLine(_consolas);
        }

    }
}
