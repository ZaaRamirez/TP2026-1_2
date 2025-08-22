//Programa estructurado
/*Console.WriteLine("Hello, World!");

Console.WriteLine("Ingresa el nombre de la persona");
string nombre = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad");
int edad = int.Parse(Console.ReadLine() ?? "");

// Mostrar datos
Console.WriteLine("Los datos de la persona son:");
Console.WriteLine($"Nombre:{nombre}");
Console.WriteLine($"Edad:{edad}");*/

//Programa orientado a objetos
//Crear objeto de tipo persona

//Persona.Pais = "Tierra";
//Persona unEnteAlien = new Persona("Alien",580);
////Ejecutar el metodo de Persona
//unEnteAlien.MostrarDatos();
////unEnteAlien.MostrarPais();

//Persona humano = new Persona("Juan",20);
//humano.MostrarDatos();
//Persona.MostrarPais();
//humano.MostrarPais();
//unEnteAlien.MostrarPais();

//MI clase Cuadrado

Rectangulo rectangulo = new Rectangulo(9,3.1416);
double area = rectangulo.CalcularArea();
Console.WriteLine($"Area del rectangulo:{area}");
rectangulo.Perimetro();

Cuadrado cuadrado = new Cuadrado(9.5f);
Console.WriteLine($"Base del cuadrado: {cuadrado.Base}");
Console.WriteLine($"Altura del cuadrado: {cuadrado.Altura}");
Console.WriteLine($"Area cuadrado:{cuadrado.CalcularArea()}");
Console.WriteLine($"Perimetro cuadrado: {cuadrado.Perimetro()}");