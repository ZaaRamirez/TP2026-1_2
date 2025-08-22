public class Cuadrado
{
    //Atributos (lados)
    public float Lado { get; set; }
    //Constructor (asignar valor de lados)
    public Cuadrado(float lado)
    {
        Lado = lado;
    }
    //Metodos(muestre perimetro, muestre area)
    public void Perimetro()
    {
        float perimetro = 4 * Lado;
        Console.WriteLine($"Perimetro{perimetro}");
    }
    public void Area()
    {
        float area = Lado * Lado;
        Console.WriteLine($"Area:{area}");
    }
}
