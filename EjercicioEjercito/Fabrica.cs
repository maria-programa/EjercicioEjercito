using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class Fabrica : IFabricaElementos
    {
        public ICaracteristicas DameElemento(TipoElementos tipo)
        {
            ICaracteristicas elemento = new Unidad();
            switch (tipo)
            {
                case TipoElementos.TransporteMX:
                    elemento.blindaje = new EstaBlindado() { Blindaje = 1.4 };
                    elemento.potencia = new NoDispara() { PotenciaFuego = 0 };
                    elemento.velocidad = new SeMueve() { Velocidad = 4.5 };
                    elemento.Precio = 4200;
                    break;

                case TipoElementos.Tanque:
                    elemento.blindaje = new EstaBlindado() { Blindaje = 4.8};
                    //elemento = new Unidad()
                    //{
                    //    blindaje = new EstaBlindado() { Blindaje = 4.8 },
                    //    potencia = new Dispara() { PotenciaFuego = 9.8 },
                    //    velocidad = new SeMueve() { Velocidad = 7.3 },
                    //    Precio = 15600
                    break;

                case TipoElementos.TransporteRapido:
                    elemento = new Unidad()
                    {
                        blindaje = new NoEstaBlindado() { Blindaje = 0 },
                        potencia = new NoDispara() { PotenciaFuego = 0 },
                        velocidad = new SeMueve() { Velocidad = 12 },
                        Precio = 1600
                    }; break;

                case TipoElementos.Infanteria:
                    elemento = new Unidad()
                    {
                        blindaje = new NoEstaBlindado() { Blindaje = 0 },
                        potencia = new Dispara() { PotenciaFuego = 7 },
                        velocidad = new SeMueve() { Velocidad = 6 },
                        Precio = 250
                    }; break;

                case TipoElementos.Ametrallador:
                    elemento = new Unidad()
                    {
                        blindaje = new NoEstaBlindado() { Blindaje = 1.4 },
                        potencia = new Dispara() { PotenciaFuego = 0 },
                        velocidad = new SeMueve() { Velocidad = 4.5 },
                        Precio = 400
                    }; break;

                case TipoElementos.Sanitario:
                    elemento = new Unidad()
                    {
                        blindaje = new EstaBlindado() { Blindaje = 1.4 },
                        potencia = new NoDispara() { PotenciaFuego = 0 },
                        velocidad = new SeMueve() { Velocidad = 4.5 },
                        Precio = 500
                    }; break;

                case TipoElementos.CanonAntiaereo:
                    elemento = new Unidad()
                    {
                        blindaje = new NoEstaBlindado() { Blindaje = 1.4 },
                        potencia = new Dispara() { PotenciaFuego = 0 },
                        velocidad = new SeMueve() { Velocidad = 4.5 },
                        Precio = 1100
                    }; break;

                case TipoElementos.Torpedero:
                    elemento = new Unidad()
                    {
                        blindaje = new EstaBlindado() { Blindaje = 1.4 },
                        potencia = new Dispara() { PotenciaFuego = 0 },
                        velocidad = new SeMueve() { Velocidad = 4.5 },
                        Precio = 1350
                    }; break;
                case TipoElementos.Canon:
                    elemento = new Unidad()
                    {
                        blindaje = new NoEstaBlindado() { Blindaje = 1.4 },
                        potencia = new NoDispara() { PotenciaFuego = 0 },
                        velocidad = new NoSeMueve() { Velocidad = 4.5 },
                        Precio = 1100
                    }; break;

                default: return null;
            }
            return elemento;
        }
    }
}
