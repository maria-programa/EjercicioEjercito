using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Unidad : ICaracteristicas
    {
        public double Velocidad { get ; set ; }
        public double Blindaje { get ; set ; }
        public double PotenciaFuego { get ; set; }
        public int Precio { get ; set ; }

        public double CapacidadMilitar()
        {
            return ((PotenciaFuego * Velocidad) / 2) / (100 - Blindaje);
        }
    }
}