public class Calculadora
{
    //Atributos
    public double N1 { get; set; }
    public double N2 { get; set; }

    //Atributo privado
    private double Resultado;
    private string Mensaje = "Mensaje privado";
    
    //Constructor
    public Calculadora(double num1, double num2)
    {
        N1 = num1;
        N2 = num2;
    }
    //Metodos

    public virtual double Sumar()
    {
        Resultado = N1 + N2;
        Console.WriteLine($"La suma es:{Resultado}");
        return Resultado;
    }
    // Sobrecarga de funcion sumar
    public double Sumar(double num3)
    {
        Resultado = N1 + N2 + num3;
        Console.WriteLine($"La suma es:{Resultado}");
        return Resultado;
    }

    public double Sumar(double num3, double num4)
    {
        Resultado = N1 + N2 + num3 +num4;
        Console.WriteLine($"La suma es:{Resultado}");
        return Resultado;
    }

    //Sobrecarga del operado +
    
    public static Calculadora operator + (Calculadora c1, Calculadora c2)
    {
        return new Calculadora(c1.N1+c2.N1,c1.N2+c2.N2);
    }

    public void Restar()
    {
        Resultado = N1 - N2;
        Console.WriteLine($"La suma es:{Resultado}");
    }
    public void Multiplicar()
    {
        Resultado = N1 * N2;
        Console.WriteLine($"La suma es:{Resultado}");
    }

    public void Divide()
    {
        if (N2 == 0)
        {
            Console.WriteLine($"No se puede divir entre 0");
        }
        else 
        {
            Resultado = N1 / N2;
            Console.WriteLine($"La suma es:{Resultado}");
        }
            
    }

    //Metodo privado

    protected string MostrarMensaje()
    {
        Console.WriteLine(Mensaje);
        return Mensaje;
    }
}
