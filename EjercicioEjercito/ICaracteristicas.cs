using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface ICaracteristicas
    {
        double Velocidad { get; set; }
        double Blindaje { get; set; }
        double PotenciaFuego { get; set; }
        int Precio {  get; set; }
        double CapacidadMilitar();

    }
}
