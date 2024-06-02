using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    internal class MenuUno : IMenuable
    {
        public void DameMenu()
        {
            IFabricaElementos MiFabrica02 = new Fabrica();
            IColeccionable MiEjercito02 = new Coleccion();

            string[] opciones = { "MX-7899", "Tanque de ataque Sombras-VB98", "TAXIN-66", "Infanteria Basica", "Ametrallador", "Sanitario", "Cañon antiaereo", "Torpedero Movil", "Cañon", "¿Quiere saber los datos importantes hasta ahora?" };
            int presupuesto;
            int opcion;
            int entrada;
            int mejora;

            Console.WriteLine("Buenos días general. Configure su ejercito.\n");
            Console.WriteLine("¿Con cuánto presupuesto contamos hoy?\n");
            presupuesto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPor favor, seleccione las opciones que guste.\n");

            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + opciones[i]);
            }
            Console.WriteLine("0. Salir\n");
            do
            {
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\nAdios");
                        Environment.Exit(0);
                        break;
                    case > 0 and < 10:
                        Escribe((TipoElementos)opcion);
                        break;
                    case 10:
                        Datos();
                        break;
                }
            } while (opcion != 0);


            void Escribe(TipoElementos tipo)
            {
                ICaracteristicas MiUnidad = MiFabrica02.DameElemento(tipo);
                if (presupuesto > MiUnidad.Precio)
                {
                    Console.WriteLine($"\n{tipo}");

                    Console.WriteLine("\n¿Dese añadirle alguna mejora?\n1.- Si\n2.- No\n");
                    entrada = Int32.Parse(Console.ReadLine());

                    if (entrada == 1)
                    {
                        Console.WriteLine("\nElija la mejora:\n1.- Super Piloto\n2.- Movimiento por Desierto\n3.- Super Bomba\n");
                        mejora = Int32.Parse(Console.ReadLine());
                        switch (mejora)
                        {
                            case 1:
                                MiUnidad = new SuperPiloto(MiUnidad);
                                Mejora(MiUnidad);
                                break;
                            case 2:
                                MiUnidad = new Desierto(MiUnidad);
                                Mejora(MiUnidad);
                                break;
                            case 3:
                                MiUnidad = new SuperBomba(MiUnidad);
                                Mejora(MiUnidad);
                                break;
                        }
                    }
                    else
                    {
                        MiEjercito02.Add(MiUnidad);
                        presupuesto -= MiUnidad.Precio;
                        Console.WriteLine($"\nLe quedan {presupuesto} euros para gastar\n");
                        Console.WriteLine("Continue\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nParece que no dispone del presupuesto necesario.\n");
                }
            }

            void Mejora(ICaracteristicas MiUnidad)
            {
                MiEjercito02.Add(MiUnidad);
                Console.WriteLine("\nSu unidad ha sido mejorada");
                presupuesto -= MiUnidad.Precio;
                Console.WriteLine($"\nLe quedan {presupuesto} euros para gastar\n");
            }

            void Datos()
            {
                Console.WriteLine($"\nEl ejercito tiene {MiEjercito02.ElementosTotales()} elementos \nSu potencia de fuego es de {MiEjercito02.PotenciaFuegoTotal()} \n" +
                    $"Su blindaje es de {MiEjercito02.BlindajeTotal()}\n" +
                    $"La velocidad total es {MiEjercito02.VelocidadTotal()} \nSe ha gastado en total {MiEjercito02.PrecioTotal()} euros \nTiene una Capacidad Militar de {MiEjercito02.CapacidadMilitar()}\n");
            }
        }
    }
}
