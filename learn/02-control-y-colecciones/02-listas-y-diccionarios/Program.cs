using System;
using System.Collections.Generic;

namespace ListasYDiccionarios;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" 🟡 Paso 2.2: Manejo de Listas y Diccionarios");
        Console.WriteLine("==================================================");

        // Lista dinámica de Strings
        List<string> frutas = new List<string> { "Manzana", "Plátano", "Naranja" };
        frutas.Add("Uva");
        frutas.Add("Mango");

        Console.WriteLine($"Total de frutas en la lista: {frutas.Count}");
        Console.WriteLine("Lista de Frutas (usando foreach):");
        foreach (var fruta in frutas)
        {
            Console.WriteLine($" 🍎 {fruta}");
        }

        Console.WriteLine();
        // Diccionario (Clave -> Valor)
        Dictionary<string, int> inventario = new Dictionary<string, int>
        {
            { "Teclado", 15 },
            { "Mouse", 28 },
            { "Monitor", 7 }
        };

        Console.WriteLine("Inventario de Productos:");
        foreach (KeyValuePair<string, int> item in inventario)
        {
            Console.WriteLine($" 📦 {item.Key}: {item.Value} unidades en stock");
        }
    }
}
