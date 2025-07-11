// See https://aka.ms/new-console-template for more information
using learning_c_.models;

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Larissa";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();


// Pessoa pessoa2 = new Pessoa();
// pessoa2.Nome = "Victor";
// pessoa2.Idade = 19;
// pessoa2.Apresentar();


// // operadores de atrubição
// int a = 10;
// int b = 20;
// int c = a + b;


// Console.WriteLine(c);

// // datetime no c#
// DateTime dataAtual = DateTime.Now.AddDays(7);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


// tipos de variaveis
// double altura = 1.80;
// Console.WriteLine("valor da variavel" + preco);


// conersão de tipos de str para outros


// int numA = 85;
// numA = Convert.ToInt32(85);
// Console.WriteLine(numA);


// // null parse para a exe 

// int inteiro = 5;
// string a_inteiro = inteiro.ToString();

// Console.WriteLine(a_inteiro);
// Console.WriteLine(a_inteiro.GetType());


// cast implicito
// int a =(89 - 9) /2;
// double b = a;
// Console.WriteLine(b);
// Console.WriteLine(b.GetType());




// string x = "12";
// int y = Convert.ToInt32(x);
// Console.WriteLine(y);
// Console.WriteLine("Conversão realizada com sucess!");
// string x = "12";
// int y = 0 ;
// int.TryParse(x, out y);
// Console.WriteLine(y);
// Console.WriteLine("Conversão realizada com sucesso!");



// operadores de condições
// int quantidadeEmEstoque = 13;
// int quantidadeCompra = 42;
// bool possivelVenda = quantidadeCompra > 0 &&  quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade me estoque:{quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade me estoque:{quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda ?{quantidadeEmEstoque >= quantidadeCompra}");

// if (quantidadeCompra == 0 )
// {
//     Console.WriteLine("Venda inválida!");
// }

//  else if (possivelVenda)
// {
//         Console.WriteLine("Venda aprovada");
//         int restoEstoque = (quantidadeEmEstoque - quantidadeCompra);
//         Console.WriteLine($"Temos {restoEstoque} deste produto");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não esta quantidade em nosso estoque!");
// }









// Swich case
// Console.WriteLine("digite uma letra:");
// string letra = Console.ReadLine();
// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//         Console.WriteLine("Vogal");
//         break;

//     default:
//     Console.WriteLine("Não é uma vogal");
//     break;

// }

// 
// bool possuiPresencaMinima = true;
// double media = 2.0;

// if (possuiPresencaMinima && media >= 7 )
// {
//     Console.WriteLine("Aprovado");

// }
// else
// {
//     Console.WriteLine("Reprovado");
// }


// not ou negação
// 



// Calculadora calc = new Calculadora();

// calc.Somar(10, 50);
// calc.dividir(80, 40);
// calc.RaizQuadrada(256);
// calc.Cos(185);
// calc.Seno(90);
// calc.Subitrair(250, 145);
// calc.Tan(65);
// // 

// int num = 10;
// Console.WriteLine(num);
// Console.WriteLine("incrementando o 10");
// num = num + 1;
// Console.WriteLine(num);



// estrutura de repetiçoes for(var;condicao;incremento)


// int num = 5;

// for (int contador = 0; contador <= 70; contador++)
// {
//     Console.WriteLine($"{num} x {contador} = {num * contador}");
// }

// estrutura de repetição while(condição)


// int num = 6;
// int contador = 0;

// while (contador <= 20)
// {
//     Console.WriteLine($"{num} x {contador} = {num * contador}");
//     contador++;

// }   



// menu interativo
string opcao;
while (true)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1- Cadastrar cliente");
    Console.WriteLine("2- buscar cliente");
    Console.WriteLine("3- apagar cliente");
    Console.WriteLine("4- encerrar");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("cadastro de cliente");
             break; 

        case "2":
            Console.WriteLine("busca de cliente");
             break; 
        case "3":
            Console.WriteLine("apagar de cliente");
             break; 
        case "4":
            Console.WriteLine("encerrar");
            Environment.Exit(0);
            break;


        default:
            Console.WriteLine("opção invalida");
            break;
        
            }


}

























// do while 


// int soma = 7, num = 5; // Agora 'soma' está corretamente inicializada

// do
// {
//     Console.WriteLine("Digite um número, (0 para parar):");
//     num = Convert.ToInt32(Console.ReadLine());
//     soma += num;

// } while (num != 0);

// Console.WriteLine($"Total da soma dos números digitados é : {soma}");
