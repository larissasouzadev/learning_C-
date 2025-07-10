using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learning_c_.models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos");
        }
    }
}
