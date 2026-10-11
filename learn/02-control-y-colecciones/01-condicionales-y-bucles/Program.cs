using System;

namespace CondicionalesYBucles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" 🟡 Paso 2.1: Estructuras Condicionales y Bucles");
        Console.WriteLine("==================================================");

        // 1. Condicional if/else
        int puntuacion = 85;
        Console.WriteLine($"Puntuación obtenida: {puntuacion}");

        if (puntuacion >= 90)
        {
            Console.WriteLine("Resultado: Excelente 🌟");
        }
        else if (puntuacion >= 70)
        {
            Console.WriteLine("Resultado: Aprobado ✅");
        }
        else
        {
            Console.WriteLine("Resultado: Reprobado ❌");
        }

        Console.WriteLine();
        Console.WriteLine("--- Bucle 'for' (Contando del 1 al 5) ---");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Conteo: {i}");
        }

        Console.WriteLine();
        Console.WriteLine("--- Bucle 'while' (Tabla del 3) ---");
        int multiplicador = 1;
        while (multiplicador <= 5)
        {
            Console.WriteLine($"3 x {multiplicador} = {3 * multiplicador}");
            multiplicador++;
        }
    }
}
