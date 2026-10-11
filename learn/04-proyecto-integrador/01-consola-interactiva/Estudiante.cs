namespace LearningCSharp;

/// <summary>
/// Clase de ejemplo para aprender Programación Orientada a Objetos (POO) en C#.
/// </summary>
public class Estudiante
{
    // Propiedades (Auto-properties)
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }
    public List<double> Calificaciones { get; set; } = new List<double>();

    // Constructor
    public Estudiante(string nombre, int edad, string curso)
    {
        Nombre = nombre;
        Edad = edad;
        Curso = curso;
    }

    // Métodos
    public void AgregarCalificacion(double calificacion)
    {
        if (calificacion >= 0 && calificacion <= 100)
        {
            Calificaciones.Add(calificacion);
        }
    }

    public double CalcularPromedio()
    {
        if (Calificaciones.Count == 0) return 0.0;
        return Calificaciones.Average();
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"🎓 Estudiante: {Nombre}");
        Console.WriteLine($"   Edad: {Edad} años");
        Console.WriteLine($"   Curso: {Curso}");
        Console.WriteLine($"   Promedio: {CalcularPromedio():F1}/100");
    }
}
