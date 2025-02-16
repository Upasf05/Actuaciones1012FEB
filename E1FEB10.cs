using System; //Ejercicio 1; Vehiculos

public class Vehiculo //Clase para persona
{
    public string marca; //Atributos en valores int y string para cada clase que sera un objeto
    public string modelo; 
    public int anio; //Anio es un valor int.
    public void MostrarInformacion() //Metodo para probar y mostrar los nombres y edad
    {
        Console.WriteLine("Marca: " + marca + ", Modelo: " + modelo + ", Anio: " + anio); //Mostrar en pantalla los valores introducidos
    }
}

public class Program //Clase principal que muestra todos los atributos solicitados
{
    public static void Main(string[] args) //Metodo que muestra todos los objetos creados mediante clases con sus valores
    {
        Vehiculo vehiculo = new Vehiculo();
        vehiculo.marca = "Hyundai";
        vehiculo.modelo = "Tucson";
        vehiculo.anio = 2015;
        vehiculo.MostrarInformacion(); 
    }
}