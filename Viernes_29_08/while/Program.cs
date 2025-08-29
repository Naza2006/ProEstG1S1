/* Leer un numero hasta que sea negativo, mostrar la suma de todos los numeros positivos*/
int num, suma = 0;
string entrada;
Console.WriteLine("Dime un #: ");
entrada = Console.ReadLine();
num = Convert.ToInt32(entrada);

while (num >= 0)
{
    suma += num;
    Console.Write("Dime un #: ");
    entrada = Console.ReadLine();
    num = Convert.ToInt32(entrada);
}

Console.WriteLine("La suma es: " + suma);