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
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno)}");
        }

        public void Cos(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cosseno)}");
        }

        public void Tan(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"a raiz de {x}= {raiz}");
        }
    }
}