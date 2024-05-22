
using EjercicioEjercito;
using System.Runtime.CompilerServices;

//-OPCION1
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


//-OPCION2

IFabricaElementos MiFabrica02 = new Fabrica();
IColeccionable MiEjercito02 = new Coleccion();

string[] opciones = { "MX-7899", "Tanque de ataque Sombras-VB98", "TAXIN-66", "Infanteria Basica", "Ametrallador", "Sanitario", "Cañon antiaereo", "Torpedero Movil", "Cañon", "¿Quiere saber los datos importantes hasta ahora?" };
int opcion;

Console.WriteLine("Buenos días general. Configure su ejercito. Por favor, seleccione las opciones que guste. \n");


for (int i = 0; i < opciones.Length; i++)
{
    Console.WriteLine(i + 1 + ". " + opciones[i]);
}
Console.WriteLine("0. Salir");
do
{
    opcion = Int32.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 0:
            Console.WriteLine("Adios");
            Environment.Exit(0);
            break;
        case 1:
            Escribe(TipoElementos.TransporteMX);
            Console.WriteLine("MX-7899");
            break;
        case 2:
            Escribe(TipoElementos.Tanque);
            Console.WriteLine("Tanque de ataque Sombras-VB98");
            break;
        case 3:
            Escribe(TipoElementos.TransporteRapido);
            Console.WriteLine("TAXIN-66");
            break;
        case 4:
            Escribe(TipoElementos.Infanteria);
            Console.WriteLine("Infanteria Basica");
            break;
        case 5:
            Escribe(TipoElementos.Ametrallador);
            Console.WriteLine("Ametrallador");
            break;
        case 6:
            Escribe(TipoElementos.Sanitario);
            Console.WriteLine("Sanitario");
            break;
        case 7:
            Escribe(TipoElementos.CanonAntiaereo);
            Console.WriteLine("Cañon antiaereo");
            break;
        case 8:
            Escribe(TipoElementos.Torpedero);
            Console.WriteLine("Torpedero Movil");
            break;
        case 9:
            Escribe(TipoElementos.Canon);
            Console.WriteLine("Cañon");
            break;
        case 10:
            Datos();
            break;
    }
} while (opcion != 0);


void Escribe(TipoElementos tipo)
{
    ICaracteristicas MiUnidad = MiFabrica02.DameElemento(tipo);
    MiEjercito02.Add(MiUnidad);
}

void Datos()
{
    Console.WriteLine($"El ejercito tiene {MiEjercito02.ElementosTotales()} elementos \nSu potencia de fuego es de {MiEjercito02.PotenciaFuegoTotal()} \nSu blindaje es de {MiEjercito02.BlindajeTotal()}\n" +
        $"La velocidad total es {MiEjercito02.VelocidadTotal()} \nSe ha gastado en total {MiEjercito02.PrecioTotal()} euros \nTiene una Capacidad Militar de {MiEjercito02.CapacidadMilitar()}");
}
//-OPCION2
//IFabricaElementos MiFabrica = new Fabrica();
//IColeccionable MiEjercito = new Coleccion();
//string[] opciones = {"Salir",
//                    "Cantidad de elementos que tiene cada ejercito",
//                    "Potencia de fuego total de nuestro ejercito",
//                    "Blindaje total de nuestro ejercito",
//                    "Capacidad de movimiento total de nuestro ejercito",
//                    "Dinero total gastado",
//                    "Capacidad militar total de nuestro ejercito",
//                    "Insertar unidad"};
//string[] tipos = { "MX-7899", "Tanque de ataque Sombras-VB98", "TAXIN-66", "Infanteria Basica", "Ametrallador", "Sanitario", "Cañon antiaereo", "Torpedero Movil", "Cañon" };
//int opcion, unidad,presupuesto;

//Console.WriteLine("HOLA GENERAL MACMAPKERSON" + "\n" + "\t" + "¡VAMOS A CREAR UN EJERCITO!" + "\n" + "\n" + "¿Cuanto presupuesto tenemos?");
//presupuesto = Int32.Parse(Console.ReadLine());


//do
//{
//    for (int i = 0; i < opciones.Length; i++)
//    {
//        Console.WriteLine(i + ". " + opciones[i] + "\n");
//    }
//    Console.WriteLine("Elija la opcion que quieras");
//    opcion = Int32.Parse(Console.ReadLine());
//    switch (opcion)
//    {
//        case 0:
//            Console.WriteLine("Adios");
//            Environment.Exit(0);
//            break;
//        case 1://-Cantidad total de unidades en el ejercito
//                Console.WriteLine($"La cantidad total de unidades es: {MiEjercito.ElementosTotales()}");
//            break;
//        case 2://-Potencia de fuego total de nuestro ejercito
//            Console.WriteLine($"La potencia de fuego total es: {MiEjercito.PotenciaFuegoTotal()}");
//            break;
//        case 3://-Blindaje total de nuestro ejercito
//            Console.WriteLine($"El blindaje total es: {MiEjercito.BlindajeTotal()}");
//            break;
//        case 4://-Capacidad de movimiento total de nuestro ejercito
//            Console.WriteLine($"La capacidad de movimiento total es: {MiEjercito.VelocidadTotal()}");
//            break;
//        case 5://-Dinero total gastado
//            Console.WriteLine($"El dinero total gastado es: {MiEjercito.PrecioTotal()}");
//            break;
//        case 6://-Capacidad militar total de nuestro ejercito
//            Console.WriteLine($"La capacidad militar del ejercito es: {MiEjercito.CapacidadMilitarTotal()}");
//            break;
//        case 7:
//            Console.WriteLine("Elige la unidad que quieres añadir"+"\n");
//            for (int i = 0; i < tipos.Length; i++)
//            {
//                Console.WriteLine(i + ". " + tipos[i] + "\n");
//            }
//            unidad = Int32.Parse(Console.ReadLine());
//            switch (unidad)
//            {
//                case 0://-MX-7899
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.TransporteMX).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.TransporteMX));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.TransporteMX).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 1://-Tanque de ataque Sombras-VB98
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.Tanque).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Tanque));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.Tanque).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 2://-TAXIN-66
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.TransporteRapido).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.TransporteRapido));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.TransporteRapido).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 3://-Infanteria Basica
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.Infanteria).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Infanteria));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.Infanteria).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 4://-Ametrallador
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.Ametrallador).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Ametrallador));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.Ametrallador).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    };
//                    break;
//                case 5://-Sanitario
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.Sanitario).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Sanitario));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.Sanitario).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 6://-Cañon antiaereo
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.CanonAntiaereo).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.CanonAntiaereo));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.CanonAntiaereo).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 7://-Torpedero Movil
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.Torpedero).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Torpedero));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.Torpedero).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//                case 8://-Cañon
//                    if ((presupuesto - MiFabrica.DameElemento(TipoElementos.Canon).Precio) >= 0)
//                    {
//                        MiEjercito.Add(MiFabrica.DameElemento(TipoElementos.Canon));
//                        Console.WriteLine("Unidad insertada");
//                        presupuesto -= MiFabrica.DameElemento(TipoElementos.Canon).Precio;
//                        Console.WriteLine($"Te queda para gastar: {presupuesto} ");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Presupuesto insuficiente");
//                    }
//                    break;
//            }
//            break;
//    }
//}while(opcion != 0);