Console.WriteLine("Programa utilizando switch");

Console.Write("Inserta un numero del 1 al 3: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine("Tu carrera es: Medicina.");
        break;
    case "2":
        Console.WriteLine("Tu carrera es: Sistemas. ");
        break;
    case "3":
        Console.WriteLine("Tu carrera es: Odonto");
        break;
    default:
        Console.WriteLine("Ingrese un valor entre el 1 y el 3");
        break;

}


