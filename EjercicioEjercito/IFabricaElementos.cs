﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface IFabricaElementos
    {
        ICaracteristicas DameElemento(TipoElementos tipo);
    }
}
