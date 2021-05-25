using System;
using ExemploSobrecarga.Classes;

namespace ExemploSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item: ");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("");
            
            Console.WriteLine("Mostrar sem argumentos.");
            f.Mostrar();

            Console.WriteLine("Mostrar com argumento tipo 'int'.");
            f.Mostrar(2);

            Console.WriteLine("Mostrar com argumento tipo 'string'.");
            f.Mostrar("maçã");
        }
    }
}
