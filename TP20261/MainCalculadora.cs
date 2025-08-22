//Calculadora basica

Console.WriteLine("Ingresa el primer numero a operar:");
double num1 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ingresa el segundo numero a operar:");
double num2 = double.Parse(Console.ReadLine() ?? "");

Calculadora calcu1 = new Calculadora(num1,num2);
Calculadora calcu2 = new Calculadora(1, 2);
Calculadora sumaCalcu = calcu1 + calcu2;

Console.WriteLine($"Suma de calculadoras: {sumaCalcu.N1},{sumaCalcu.N2}");

//Seleccion de calculadora
/*Console.WriteLine("Selecciona la calculadora a utilizar:\n1- Calculadora basica\n 2- Calculadora cientifica");
int opCalcu = int.Parse(Console.ReadLine() ?? "");

switch (opCalcu)
{ 
    case 1:
        //Instanciar objeto calculadora
        Calculadora calcuB = new Calculadora(num1, num2);
        //Seleccion de operaciones
        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1 Sumar");
        Console.WriteLine("2 Restar");
        Console.WriteLine("3 Multiplicar");
        Console.WriteLine("4 Dividir");
        Console.WriteLine($"primer numero{calcuB.N1}");
        Console.WriteLine($"primer numero{calcuB.N2}");

        int opcion = int.Parse(Console.ReadLine() ?? "");

        switch (opcion)
        {
            case 1:
                calcuB.Sumar();
                calcuB.Sumar(5);
                calcuB.Sumar(6,6);
                break;
            case 2:
                calcuB.Restar();
                break;
            case 3:
                calcuB.Multiplicar();
                break;
            case 4:
                calcuB.Divide();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        break;
    case 2:
        //Instanciar calculadora cientifica
        CalculadoraCientifica calcuC = new CalculadoraCientifica(num1, num2);

        //Seleccion de operaciones
        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1 Sumar");
        Console.WriteLine("2 Restar");
        Console.WriteLine("3 Multiplicar");
        Console.WriteLine("4 Dividir");
        Console.WriteLine("5 Factorial");
        Console.WriteLine("6 Raiz cuadrada");
        Console.WriteLine("7 Logaritmo");
        calcuC.MensajeCalculadora();
        int opcionC = int.Parse(Console.ReadLine() ?? "");

        switch (opcionC)
        {
            case 1:
                calcuC.Sumar();
                break;
            case 2:
                calcuC.Restar();
                break;
            case 3:
                calcuC.Multiplicar();
                break;
            case 4:
                calcuC.Divide();
                break;
            case 5:
                Console.WriteLine($"Resultado:{calcuC.Factorial()}");
                break;
            case 6:
                Console.WriteLine($"Resultado:{calcuC.RaizCuadrada()}");
                break;
            case 7:
                Console.WriteLine($"Resultado:{calcuC.Logaritmo()}");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}*/