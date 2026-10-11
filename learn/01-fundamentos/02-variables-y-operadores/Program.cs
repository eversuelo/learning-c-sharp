using System;

namespace VariablesYOperadores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=============================================");
        Console.WriteLine(" 🟢 Paso 1.2: Variables, Tipos y Operadores");
        Console.WriteLine("=============================================");

        // Tipos Primitivos Básicos
        string nombre = "Alex";
        int edad = 25;
        double estaturaMetros = 1.75;
        bool esEstudiante = true;

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estaturaMetros} m");
        Console.WriteLine($"¿Es Estudiante?: {esEstudiante}");
        Console.WriteLine();

        // Operaciones Aritméticas
        int numA = 15;
        int numB = 4;

        Console.WriteLine($"Suma ({numA} + {numB}): {numA + numB}");
        Console.WriteLine($"Resta ({numA} - {numB}): {numA - numB}");
        Console.WriteLine($"Multiplicación ({numA} * {numB}): {numA * numB}");
        Console.WriteLine($"División Entera ({numA} / {numB}): {numA / numB}");
        Console.WriteLine($"Residuo / Módulo ({numA} % {numB}): {numA % numB}");
        Console.WriteLine($"División Decimal (cast a double): {(double)numA / numB}");
    }
}
