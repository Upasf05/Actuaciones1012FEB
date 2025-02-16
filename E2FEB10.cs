using System;

public class Estudianteu // Clase para persona
{
    public string nombre; // Atributo para el nombre
    public int edad; // Edad del estudiante
    public string carrera; // Carrera del estudiante

    // Metodo para mostrar la informacion del estudiante
    public void MostrarInformacion() 
    {
        Console.WriteLine("Nombre: " + nombre + ", Edad: " + edad + ", Carrera: " + carrera);
    }
}

public class Program // Clase principal
{
    public static void Main(string[] args) // Metodo principal
    {
        Estudianteu estudianteu = new Estudianteu(); // Crear una instancia de Estudianteu
        estudianteu.nombre = "Darwin Espinoza"; // Asignar nombre
        estudianteu.edad = 30; // Asignar edad
        estudianteu.carrera = "Base de Datos Estructurada y Visual"; // Asignar carrera
        estudianteu.MostrarInformacion(); // Mostrar la informacion del estudiante
    }
}