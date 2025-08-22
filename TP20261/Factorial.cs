//Calculo del factorial
Console.WriteLine("Ingresa el numero del factorial:");
int f = int.Parse(Console.ReadLine()??"");

if (f > 1)
{
    for (int i = f - 1; i >= 1; i--)
    {
        f = f * i;
    }
    Console.WriteLine($"Factorial es:{f}");
}
else if (f==1 || f==0)
{
    Console.WriteLine("Factorial = 1");
}
else
{
    Console.WriteLine("No se puede calcular");
}