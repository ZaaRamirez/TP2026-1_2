public class Rectangulo
{
    //Atributos
    public double Base { get; set; }
    public double Altura { get; set; }

    //Constructor
    public Rectangulo(double base_, double altura)
    { 
        Base = base_;
        Altura = altura;
    }

    //Metodos

    public virtual double CalcularArea()
    {
        return Base * Altura;
        /*Console.Write("Area:");
        Console.WriteLine(area);*/
    }

    public virtual double Perimetro()
    {
        return 2 * (Base + Altura);
        //Console.WriteLine($"Perimetro rectangulo es:{perimetro}");
    }

}
