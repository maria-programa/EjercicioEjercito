using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface ICaracteristicas
    {
        IBlindaje blindaje { get; set; }
        IVelocidad velocidad { get; set; }
        IPotenciaFuego potencia { get; set; }
        int Precio {  get; set; }


    }
}
