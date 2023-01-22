using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1061719.Clases
{
    internal sealed class Juegos : IServicioTransient
    {
        Guid IServicios.Id { get; } = Guid.NewGuid();
        public string NombreJuego() => "Fortnite";

        private readonly IEnumerable<IServicioTransient> _juego;

        public Juegos(IEnumerable<IServicioTransient> juego)
        {
            _juego = juego;
        }

        public void Imprimir()
        {
            Console.WriteLine(_juego);
        }
    }

}
