using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class Coleccion : IColeccionable, ICaracteristicas
    {
        public List<ICaracteristicas> caracteristicas = new List<ICaracteristicas>();
        int numElementos = 0;
        double potenciaFuegoTotal = 0;
        double blindajeTotal = 0;
        double velocidadTotal = 0;
        int precioTotal = 0;
        double capacidadMilitarTotal = 0;



        public void Add(ICaracteristicas elemento)
        {
            caracteristicas.Add(elemento);
            numElementos++;
            potenciaFuegoTotal += elemento.PotenciaFuego;
            blindajeTotal += elemento.Blindaje;
            velocidadTotal += elemento.Velocidad;
            precioTotal += elemento.Precio;
            capacidadMilitarTotal += elemento.CapacidadMilitar();
        }
        public double CapacidadMilitar()
        {
            return capacidadMilitarTotal;
        }
        public int ElementosTotales()
        {
            return numElementos;
        }
        public double Velocidad { get { return velocidadTotal; } set { } }
        public double Blindaje { get { return blindajeTotal; } set { } }
        public double PotenciaFuego { get { return potenciaFuegoTotal; } set { } }
        public int Precio { get { return precioTotal; } set { } }
    }
}
