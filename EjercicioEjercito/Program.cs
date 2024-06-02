
using EjercicioEjercito;
using System.Runtime.CompilerServices;

//-OPCION1 A PINRELILLO
//IFabricaElementos MiFabrica = new Fabrica();
//IColeccionable MiEjercito = new Coleccion();


//ICaracteristicas TanqueSombra = MiFabrica.DameElemento(TipoElementos.Tanque);
//TanqueSombra = new SuperPiloto(new Desierto(new SuperBomba(TanqueSombra)));

//MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.TransporteMX));
//MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Sanitario));
//MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Ametrallador));
//MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.TransporteMX));
//MiEjercito.Add(TanqueSombra);

//Console.WriteLine($"El ejercito tiene {MiEjercito.ElementosTotales()} elementos");
//Console.WriteLine($"Su potencia de fuego es de {MiEjercito.PotenciaFuegoTotal()}");
//Console.WriteLine($"Su blindaje es de {MiEjercito.BlindajeTotal()}");
//Console.WriteLine($"La velocidad total es {MiEjercito.VelocidadTotal()}");
//Console.WriteLine($"Se ha gastado en total {MiEjercito.PrecioTotal()} euros");
//Console.WriteLine($"Tiene una Capacidad Militar de {MiEjercito.CapacidadMilitar()}");


//-OPCION2 MEDIANTE CONSOLA

IMenuable MiMenu = new MenuUno();

do { MiMenu.DameMenu(); } while (true);

