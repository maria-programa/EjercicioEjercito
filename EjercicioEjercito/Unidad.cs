using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Unidad : ICaracteristicas
    {
        public int Precio { get; set; }
        public IBlindaje blindaje { get; set; }
        public IVelocidad velocidad { get; set; }
        public IPotenciaFuego potencia { get; set; }
    }

    public class SuperPiloto : ICaracteristicas
    {
        ICaracteristicas Piloto;
        public SuperPiloto(ICaracteristicas piloto)
        {
            this.Piloto = piloto;
        }

        public IBlindaje blindaje { get { return this.Piloto.blindaje; } set { } }
        public IVelocidad velocidad { get { return new SeMueve() { Velocidad = this.Piloto.velocidad.Velocidad * 1.1 }; } set { } }
        public IPotenciaFuego potencia { get { return this.Piloto.potencia; } set { } }
        public int Precio { get { return this.Piloto.Precio; } set { } }
    }

    class MasBlindajeDecorador : ICaracteristicas
    {
        ICaracteristicas AModificar;

        public MasBlindajeDecorador(ICaracteristicas aux)
        {
            this.AModificar = aux;
        }

        public IBlindaje blindaje { get { return new EstaBlindado() { Blindaje = this.AModificar.blindaje.Blindaje * 2 }; } set { } }
        public IVelocidad velocidad { get { return this.AModificar.velocidad; } set { } }
        public IPotenciaFuego potencia { get { return this.AModificar.potencia; } set { } }
        public int Precio { get { return this.AModificar.Precio; } set { } }
    }

    public class Desierto : ICaracteristicas
    {
        ICaracteristicas MovimientoDesierto;
        public Desierto(ICaracteristicas desierto)
        {
            this.MovimientoDesierto = desierto;
        }

        public IBlindaje blindaje { get { return this.MovimientoDesierto.blindaje; } set { } }
        public IVelocidad velocidad { get { return new SeMueve() { Velocidad = this.MovimientoDesierto.velocidad.Velocidad * 0.8 }; } set { } }
        public IPotenciaFuego potencia { get { return this.MovimientoDesierto.potencia; } set { } }
        public int Precio { get { return this.MovimientoDesierto.Precio; } set { } }
    }
    public class SuperBomba : ICaracteristicas
    {
        ICaracteristicas Bomba;
        public SuperBomba(ICaracteristicas bomba)
        {
            this.Bomba = bomba;
        }

        public IBlindaje blindaje { get { return this.Bomba.blindaje; } set { } }
        public IVelocidad velocidad { get { return this.Bomba.velocidad; } set { } }
        public IPotenciaFuego potencia { get { return new Dispara() { PotenciaFuego = this.Bomba.potencia.PotenciaFuego * 10 }; } set { } }
        public int Precio { get { return this.Bomba.Precio; } set { } }
    }
}