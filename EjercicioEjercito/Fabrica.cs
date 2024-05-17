using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class Fabrica : IFabricaElementos
    {
        public ICaracteristicas DameElemento(TipoElementos tipo)
        {
            ICaracteristicas elemento = null;
            switch (tipo)
            {
                case TipoElementos.TransporteMX: elemento = new Unidad() { Blindaje = 1.4, Velocidad = 4.5, PotenciaFuego = 0, Precio = 4200 }; break;
                case TipoElementos.Tanque: elemento = new Unidad() { Blindaje = 4.8, Velocidad = 7.3, PotenciaFuego = 9.8, Precio = 15600 }; break;
                case TipoElementos.TransporteRapido: elemento = new Unidad() { Blindaje = 0, Velocidad = 12, PotenciaFuego = 0, Precio = 1600 }; break;
                case TipoElementos.Infanteria: elemento = new Unidad() { Blindaje = 0, Velocidad = 6, PotenciaFuego = 7, Precio = 250 }; break;
                case TipoElementos.Ametrallador: elemento = new Unidad() { Blindaje = 0, Velocidad = 4, PotenciaFuego = 10, Precio = 400 }; break;
                case TipoElementos.Sanitario: elemento = new Unidad() { Blindaje = 5, Velocidad = 7, PotenciaFuego = 0, Precio = 500 }; break;
                case TipoElementos.CanonAntiaereo: elemento = new Unidad() { Blindaje = 0, Velocidad = 1, PotenciaFuego = 22, Precio = 1100 }; break;
                case TipoElementos.Torpedero: elemento = new Unidad() { Blindaje = 2, Velocidad = 3, PotenciaFuego = 19, Precio = 1350 }; break;
                case TipoElementos.Canon: elemento = new Unidad() { Blindaje = 0, Velocidad = 0, PotenciaFuego = 14, Precio = 1100 }; break;
                default: return null;
            }
            return elemento;
        }
    }
}
