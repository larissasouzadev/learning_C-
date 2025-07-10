using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learning_c_.models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");

        }
        public void Subitrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");

        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");

        }
        public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");

        }
         public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

    }
}