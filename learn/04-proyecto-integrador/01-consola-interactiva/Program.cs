using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("================================================");
            Console.WriteLine("    🚀 ¡BIENVENIDO A APRENDER C# DESDE CERO!   ");
            Console.WriteLine("================================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Selecciona un tema para aprender:");
            Console.WriteLine(" 1. 📝 Variables y Tipos de Datos");
            Console.WriteLine(" 2. 🔀 Estructuras de Control (If / Switch)");
            Console.WriteLine(" 3. 🔄 Bucles y Colecciones (Listas / Diccionarios)");
            Console.WriteLine(" 4. 🧩 Programación Orientada a Objetos (POO)");
            Console.WriteLine(" 5. 🔍 Consultas con LINQ");
            Console.WriteLine(" 6. ❌ Salir");
            Console.WriteLine();
            Console.Write("👉 Ingresa el número de opción: ");

            string? opcion = Console.ReadLine();

            Console.Clear();
            switch (opcion)
            {
                case "1":
                    LeccionVariables();
                    break;
                case "2":
                    LeccionEstructurasControl();
                    break;
                case "3":
                    LeccionBuclesYColecciones();
                    break;
                case "4":
                    LeccionPOO();
                    break;
                case "5":
                    LeccionLINQ();
                    break;
                case "6":
                    salir = true;
                    Console.WriteLine("¡Gracias por practicar! ¡Sigue aprendiendo C#! 👋");
                    continue;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Presiona cualquier tecla para reintentar...");
                    Console.ResetColor();
                    break;
            }

            if (!salir)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Presiona ENTER para volver al menú principal...");
                Console.ResetColor();
                Console.ReadLine();
            }
        }
    }

    #region Lecciones

    static void LeccionVariables()
    {
        MostrarTitulo("Lección 1: Variables y Tipos de Datos");

        // Tipos de datos primitivos
        string lenguaje = "C#";
        int versionNET = 10;
        double pi = 3.14159;
        bool esDivertido = true;
        DateTime fechaHoy = DateTime.Now;

        // Inferencia de tipos con 'var'
        var mensaje = "¡Hola desde C#!";

        Console.WriteLine($"• String (Texto):        {lenguaje}");
        Console.WriteLine($"• Int (Entero):          .NET versión {versionNET}");
        Console.WriteLine($"• Double (Decimal):      {pi}");
        Console.WriteLine($"• Bool (Booleano):       ¿Es divertido aprender C#? {esDivertido}");
        Console.WriteLine($"• DateTime (Fecha/Hora): {fechaHoy:d}");
        Console.WriteLine($"• Var (Tipo inferido):   \"{mensaje}\"");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("💡 Consejo:");
        Console.WriteLine("C# es un lenguaje de tipado fuerte (strongly-typed). Cada variable tiene un tipo definido.");
        Console.ResetColor();
    }

    static void LeccionEstructurasControl()
    {
        MostrarTitulo("Lección 2: Estructuras de Control");

        Console.Write("Ingresa tu edad para evaluar la estructura 'if/else': ");
        string? entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int edad))
        {
            if (edad >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ Tienes {edad} años: Eres mayor de edad.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"⚠️ Tienes {edad} años: Eres menor de edad.");
            }
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("No ingresaste un número entero válido.");
        }

        Console.WriteLine();
        Console.WriteLine("--- Ejemplo de Switch ---");
        DayOfWeek dia = DateTime.Now.DayOfWeek;

        string mensajeDia = dia switch
        {
            DayOfWeek.Saturday or DayOfWeek.Sunday => "¡Es fin de semana! 🎉",
            DayOfWeek.Friday => "¡Por fin es viernes! 🚀",
            _ => "Día de trabajo/estudio 💪"
        };

        Console.WriteLine($"Hoy es {dia} -> {mensajeDia}");
    }

    static void LeccionBuclesYColecciones()
    {
        MostrarTitulo("Lección 3: Bucles y Colecciones");

        // Lista
        List<string> tecnologias = new List<string> { "C#", ".NET", "ASP.NET Core", "Entity Framework", "LINQ" };

        Console.WriteLine("--- Recorriendo una Lista<string> con 'foreach' ---");
        foreach (var tech in tecnologias)
        {
            Console.WriteLine($" 🔹 {tech}");
        }

        Console.WriteLine();
        Console.WriteLine("--- Recorriendo con un bucle 'for' tradicional ---");
        for (int i = 0; i < tecnologias.Count; i++)
        {
            Console.WriteLine($" [{i + 1}] {tecnologias[i]}");
        }

        Console.WriteLine();
        Console.WriteLine("--- Diccionario (Clave -> Valor) ---");
        Dictionary<string, string> conceptos = new Dictionary<string, string>
        {
            { "CLR", "Common Language Runtime (Entorno de ejecución de .NET)" },
            { "SDK", "Software Development Kit (Herramientas para desarrollar)" },
            { "JIT", "Just-In-Time Compiler (Compila a código de máquina al vuelo)" }
        };

        foreach (var item in conceptos)
        {
            Console.WriteLine($" 📖 {item.Key}: {item.Value}");
        }
    }

    static void LeccionPOO()
    {
        MostrarTitulo("Lección 4: Programación Orientada a Objetos (POO)");

        Console.WriteLine("Creando dos objetos de la clase 'Estudiante'...\n");

        Estudiante est1 = new Estudiante("Ana Gómez", 20, "Desarrollo de Software");
        est1.AgregarCalificacion(95.0);
        est1.AgregarCalificacion(88.5);
        est1.AgregarCalificacion(92.0);

        Estudiante est2 = new Estudiante("Carlos López", 22, "Ciencia de Datos");
        est2.AgregarCalificacion(78.0);
        est2.AgregarCalificacion(85.0);
        est2.AgregarCalificacion(90.0);

        est1.MostrarInformacion();
        Console.WriteLine();
        est2.MostrarInformacion();
    }

    static void LeccionLINQ()
    {
        MostrarTitulo("Lección 5: LINQ (Language Integrated Query)");

        List<int> numeros = new List<int> { 12, 5, 8, 23, 42, 17, 30, 4, 99, 50 };

        Console.WriteLine($"Lista original: {string.Join(", ", numeros)}");
        Console.WriteLine();

        // Filtrar números pares mayores a 10 usando LINQ
        var paresMayoresA10 = numeros
            .Where(n => n % 2 == 0 && n > 10)
            .OrderBy(n => n)
            .ToList();

        Console.WriteLine($"1. Números pares > 10 (ordenados): {string.Join(", ", paresMayoresA10)}");

        // Operaciones de agregación
        Console.WriteLine($"2. Cantidad de elementos: {numeros.Count()}");
        Console.WriteLine($"3. Valor máximo: {numeros.Max()}");
        Console.WriteLine($"4. Valor mínimo: {numeros.Min()}");
        Console.WriteLine($"5. Promedio: {numeros.Average():F2}");
    }

    static void MostrarTitulo(string titulo)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"=== {titulo} ===");
        Console.ResetColor();
        Console.WriteLine();
    }

    #endregion
}
