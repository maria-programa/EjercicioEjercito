using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class Coleccion : IColeccionable
    {
        public List<ICaracteristicas> caracteristicas = new List<ICaracteristicas>();
        public int numElementos = 0;
        public double potenciaFuegoTotal = 0;
        public double blindajeTotal = 0;
        public double velocidadTotal = 0;
        public int precioTotal = 0;


        public void Add(ICaracteristicas elemento)
        {
            caracteristicas.Add(elemento);
            numElementos++;
            potenciaFuegoTotal += elemento.potencia.PotenciaFuego;
            blindajeTotal += elemento.blindaje.Blindaje;
            velocidadTotal += elemento.velocidad.Velocidad;
            precioTotal += elemento.Precio;
        }

        public double BlindajeTotal()
        {
            return blindajeTotal;
        }

        public double CapacidadMilitar()
        {
            return ((potenciaFuegoTotal * velocidadTotal) / 2) / (100 - blindajeTotal);
        }
        public int ElementosTotales()
        {
            return numElementos;
        }

        public double PotenciaFuegoTotal()
        {
            return potenciaFuegoTotal;
        }

        public int PrecioTotal()
        {
            return precioTotal;
        }

        public double VelocidadTotal()
        {
            return velocidadTotal;
        }
    }
}
