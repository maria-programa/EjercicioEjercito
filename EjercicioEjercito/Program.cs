
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
        case 1:
            Escribe(TipoElementos.TransporteMX);
            break;
        case 2:
            Escribe(TipoElementos.Tanque);
            break;
        case 3:
            Escribe(TipoElementos.TransporteRapido);
            break;
        case 4:
            Escribe(TipoElementos.Infanteria);
            break;
        case 5:
            Escribe(TipoElementos.Ametrallador);
            break;
        case 6:
            Escribe(TipoElementos.Sanitario);
            break;
        case 7:
            Escribe(TipoElementos.CanonAntiaereo);
            break;
        case 8:
            Escribe(TipoElementos.Torpedero);
            break;
        case 9:
            Escribe(TipoElementos.Canon);
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
                    MiEjercito02.Add(MiUnidad);
                    Console.WriteLine("\nSu unidad ha sido mejorada");
                    presupuesto -= MiUnidad.Precio;
                    Console.WriteLine($"\nLe quedan {presupuesto} euros para gastar\n");
                    break;
                case 2:
                    MiUnidad = new Desierto(MiUnidad);
                    MiEjercito02.Add(MiUnidad);
                    Console.WriteLine("\nSu unidad ha sido mejorada");
                    presupuesto -= MiUnidad.Precio;
                    Console.WriteLine($"\nLe quedan {presupuesto} euros para gastar\n");
                    break;
                case 3:
                    MiUnidad = new SuperBomba(MiUnidad);
                    MiEjercito02.Add(MiUnidad);
                    Console.WriteLine("\nSu unidad ha sido mejorada");
                    presupuesto -= MiUnidad.Precio;
                    Console.WriteLine($"\nLe quedan {presupuesto} euros para gastar\n");
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

void Datos()
{
    Console.WriteLine($"\nEl ejercito tiene {MiEjercito02.ElementosTotales()} elementos \nSu potencia de fuego es de {MiEjercito02.PotenciaFuegoTotal()} \n" +
        $"Su blindaje es de {MiEjercito02.BlindajeTotal()}\n" +
        $"La velocidad total es {MiEjercito02.VelocidadTotal()} \nSe ha gastado en total {MiEjercito02.PrecioTotal()} euros \nTiene una Capacidad Militar de {MiEjercito02.CapacidadMilitar()}\n");
}


