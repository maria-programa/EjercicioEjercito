﻿using System;
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



        public void Add(ICaracteristicas elemento)
        {
            caracteristicas.Add(elemento);
            numElementos++;
            //potenciaFuegoTotal += elemento.PotenciaFuego;
            //blindajeTotal += elemento.Blindaje;
            //velocidadTotal += elemento.Velocidad;
            precioTotal += elemento.Precio;
        }
        public double CapacidadMilitar()
        {           
            return ((potenciaFuegoTotal * velocidadTotal) / 2) / (100 - blindajeTotal);
        }
        public int ElementosTotales()
        {
            return numElementos;
        }


        public int Precio { get { return precioTotal; } set { } }

        public IBlindaje blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IVelocidad velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPotenciaFuego potencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
