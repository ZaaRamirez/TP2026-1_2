//Cuadrado hereda de rectangulo
public class Cuadrado : Rectangulo
{
    //Lado es tanto la base como la altura
    //Constrcutor propio para el cuadrado

    public Cuadrado(double lado) : base(lado, lado)
    {  
    }

    //Metodos, sobreecribir los heredados de rectangulo
    /*public override double CalcularArea()
    {
        return Base * Base;
    }

    public override double Perimetro()
    {
        return 4 * Base;
    }*/
}
