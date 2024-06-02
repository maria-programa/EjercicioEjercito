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
                    elemento.potencia = new NoDispara();
                    elemento.velocidad = new SeMueve() { Velocidad = 4.5 };
                    elemento.Precio = 4200;
                    break;

                case TipoElementos.Tanque:
                    elemento.blindaje = new EstaBlindado() { Blindaje = 4.8};
                    elemento.potencia = new Dispara() { PotenciaFuego = 9.8 };
                    elemento.velocidad = new SeMueve() { Velocidad = 7.3 };
                    elemento.Precio = 15600;
                    break;
                    
                case TipoElementos.TransporteRapido:
                    elemento.blindaje = new NoEstaBlindado();
                    elemento.potencia = new NoDispara();
                    elemento.velocidad = new SeMueve() { Velocidad = 12 };
                    elemento.Precio = 1600;
                    break;

                case TipoElementos.Infanteria:
                    elemento.blindaje = new NoEstaBlindado();
                    elemento.potencia = new Dispara() { PotenciaFuego = 7 };
                    elemento.velocidad = new SeMueve() { Velocidad = 6 };
                    elemento.Precio = 250;
                    break;

                case TipoElementos.Ametrallador:
                    elemento.blindaje = new NoEstaBlindado();
                    elemento.potencia = new Dispara() { PotenciaFuego = 10 };
                    elemento.velocidad = new SeMueve() { Velocidad = 4 };
                    elemento.Precio = 400;
                    break;

                case TipoElementos.Sanitario:
                    elemento.blindaje = new EstaBlindado() { Blindaje = 5 };
                    elemento.potencia = new NoDispara();
                    elemento.velocidad = new SeMueve() { Velocidad = 7 };
                    elemento.Precio = 500;
                    break;

                case TipoElementos.CanonAntiaereo:
                    elemento.blindaje = new NoEstaBlindado();
                    elemento.potencia = new Dispara() { PotenciaFuego = 22 };
                    elemento.velocidad = new SeMueve() { Velocidad = 1 };
                    elemento.Precio = 1100;
                    break;

                case TipoElementos.Torpedero:
                    elemento.blindaje = new EstaBlindado() { Blindaje = 2 };
                    elemento.potencia = new Dispara() { PotenciaFuego = 19 };
                    elemento.velocidad = new SeMueve() { Velocidad = 3 };
                    elemento.Precio = 1350;
                    break;

                case TipoElementos.Canon:
                    elemento.blindaje = new NoEstaBlindado();
                    elemento.potencia = new Dispara() { PotenciaFuego = 14 };
                    elemento.velocidad = new NoSeMueve();
                    elemento.Precio = 1100;
                    break;

                default: return null;
            }
            return elemento;
        }
    }
}
