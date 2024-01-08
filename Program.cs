using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            int codigo, alcool, gasolina, diesel;

            Console.WriteLine("Digite o codigo do combustivel");
            codigo = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            diesel = 0;
            while (codigo != 4) {
                if (codigo >= 1 && codigo <= 3) {
                    if (codigo == 1) {
                        alcool++;
                    }
                    else if (codigo == 2) {
                        gasolina++;
                    }
                    else if (codigo == 3) {
                        diesel++;
                    }
                }
                else {
                    Console.WriteLine("Digite um codigo valido");
                }

                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}