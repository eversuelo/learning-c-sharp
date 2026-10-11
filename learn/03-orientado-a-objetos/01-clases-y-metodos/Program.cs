using System;

namespace ClasesYMetodos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" 🟠 Paso 3.1: Clases, Objetos y Constructores");
        Console.WriteLine("==================================================");

        // Instanciación de Objetos
        Persona dev1 = new Persona("Laura Rivas", "Desarrolladora Backend C#", 4);
        Persona dev2 = new Persona("Mateo Silva", "Arquitecto de Software", 8);

        // Invocando Métodos
        dev1.Saludar();
        dev2.Saludar();
    }
}
