using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora
{
    internal class Operacion
    {
        public virtual int Operar()
        {
            return 0; 
        }
    }

    internal class Calculadora : Operacion
    {
        public int numero1;
        public int numero2;

        public Calculadora(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public override int Operar()
        {
            return sumar(); 
        }

        public virtual int dividir()
        {
            if (numero2 != 0)
                return numero1 / numero2;
            else
            {
                Console.WriteLine("Error: División por cero.");
                return 0;
            }
        }

        public virtual int multiplicar()
        {
            return numero1 * numero2;
        }

        public virtual int sumar()
        {
            return numero1 + numero2;
        }

        public virtual int restar()
        {
            return numero1 - numero2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Ingrese el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Operacion operacion = new Calculadora(numero1, numero2); 

            Calculadora calculadora = new Calculadora(numero1, numero2);

            Console.WriteLine($"Suma: {calculadora.sumar()}");
            Console.WriteLine($"Resta: {calculadora.restar()}");
            Console.WriteLine($"Multiplicación: {calculadora.multiplicar()}");
            Console.WriteLine($"División: {calculadora.dividir()}");

            Console.ReadLine(); 
        }
    }
}