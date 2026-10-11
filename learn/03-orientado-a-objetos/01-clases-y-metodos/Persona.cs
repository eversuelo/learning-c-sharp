namespace ClasesYMetodos;

public class Persona
{
    // Propiedades
    public string Nombre { get; set; }
    public string Profesion { get; set; }
    public int AniosExperiencia { get; set; }

    // Constructor
    public Persona(string nombre, string profesion, int aniosExperiencia)
    {
        Nombre = nombre;
        Profesion = profesion;
        AniosExperiencia = aniosExperiencia;
    }

    // Método
    public void Saludar()
    {
        Console.WriteLine($"👋 ¡Hola! Mi nombre es {Nombre}, soy {Profesion} y tengo {AniosExperiencia} años de experiencia.");
    }
}
