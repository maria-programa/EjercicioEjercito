using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface IColeccionable
    {
        int ElementosTotales();
        double CapacidadMilitar();
        public void Add(ICaracteristicas elemento);
    }
}
