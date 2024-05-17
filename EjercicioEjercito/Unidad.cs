using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Unidad : ICaracteristicas
    {
        public int Precio { get ; set ; }
        public IBlindaje blindaje { get; set; }
        public IVelocidad velocidad { get; set; }
        public IPotenciaFuego potencia { get; set; }

     
    }
}