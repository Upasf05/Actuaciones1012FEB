using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora //Espacio principal del programa
{
    internal class Operacion //Clase interna para la realización de operaciones
    {
        public virtual int Operar()
        {
            return 0; //Método base sin implementación específica
        }
    }

    internal class Calculadora : Operacion //Clase interna que representa a la calculadora como un objeto
    {
        public int numero1; //Definir primer número que realizará operación
        public int numero2; //Definir segundo número que realizará operación

        public Calculadora(int numero1, int numero2) //Método donde funcionará la calculadora
        {
            this.numero1 = numero1; //Colcoar el primer valor en el método
            this.numero2 = numero2; //Colocar el segundo valor en el método
        }

        public override int Operar() //Usar polimorfismo en el objeto para permitir método similares
        {
            return sumar(); //Por defecto, se realizará una suma
        }

        public virtual int dividir() //Método de división
        {
            if (numero2 != 0)
                return numero1 / numero2;
            else
            {
                Console.WriteLine("Error: División por cero.");
                return 0;
            }
        }

        public virtual int multiplicar() //Método de multiplicación
        {
            return numero1 * numero2;
        }

        public virtual int sumar() //Método de suma
        {
            return numero1 + numero2;
        }

        public virtual int restar() //Método de resta
        {
            return numero1 - numero2;
        }
    }

    class Program //Clase abstracta que imprime los resultados, actúa como una interfaz
    {
        static void Main(string[] args) //Único método
        {
            int numero1, numero2; //Definir los valores
            Console.WriteLine("Ingrese el primer número: "); //Solicitar la impresión del primer número
            numero1 = Convert.ToInt32(Console.ReadLine()); //Leer el número
            Console.WriteLine("Ingrese el segundo número: "); //Solicitar la impresión del segundo número
            numero2 = Convert.ToInt32(Console.ReadLine()); //Leer el segundo número

            Operacion operacion = new Calculadora(numero1, numero2); //Polimorfismo, convertir clase en valor a imprimir

            Calculadora calculadora = new Calculadora(numero1, numero2); //Repetir el proceso de polimorfismo

            Console.WriteLine($"Suma: {calculadora.sumar()}"); //Imprimir lso valores
            Console.WriteLine($"Resta: {calculadora.restar()}");
            Console.WriteLine($"Multiplicación: {calculadora.multiplicar()}");
            Console.WriteLine($"División: {calculadora.dividir()}");

            Console.ReadLine(); //Cerrar el método
        }
    }
}
