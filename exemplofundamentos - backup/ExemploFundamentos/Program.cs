// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Common.Models;


int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

for (int contador = 0; contador < arrayInteiro.Conlength; contador++)
{
   Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
}






// //exemplofundamentos.Models.Pessoa p = new exemplofundamentos.Models.Pessoa();
// pessoa pessoa1 = new pessoa();
// pessoa1.Nome = "Marcelo";
// pessoa1.Idade = 45;
// pessoa1.Apresentar();




// // string opcao;
// // bool exibirMenu = true;

// // while(exibirMenu){
// //     Console.Clear();
// //     Console.WriteLine("Digite a sua opção");
// //     Console.WriteLine("1 - Cadastrar cliente");
// //     Console.WriteLine("2 - Buscar cliente");
// //     Console.WriteLine("3 - Apagar cliente");
// //     Console.WriteLine("4 - Encerrar");

// //     opcao = Console.ReadLine();
    
// //     switch(opcao)
// //     {
// //         case "1":
// //         Console.WriteLine("Cadastro de cliente");
// //         break;

// //         case "2":
// //         Console.WriteLine("Buscar cliente");
// //         break;

// //         case "3":
// //         Console.WriteLine("Apagar cliente");
// //         break;

// //         case "4":
// //         exibirMenu = false;
// //         Console.WriteLine("Encerrar");
  
// //         //Environment.Exit(0);
// //         break;

// //         default:
// //          Console.WriteLine("Opção invalida");
// //          break;
// //     }
// // }
// // Console.WriteLine("O programa encerrou");




// // int soma = 0, numero = 0;

// // do
// // {
// //     Console.Write("Digite um numero: ");
// //     numero = Convert.ToInt32(Console.ReadLine());

// // }while(numero != 0);
// // Console.WriteLine($"Total da soma dos números é: {soma}");


// // int numero = 5;
// // int contador = 0;

// // while (contador <= 10)
// // {
// // Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
// // contador++;

// // if (contador == 6)
// // {
// //     break;
// // }
// // }



// // int numero = 5;

// // for(int contador = 0; contador <=10; contador++)
// // {
// // Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// // }



















// // Calculadora cal = new Calculadora();
// // cal.Somar(10, 30);
// // cal.Subtrair(10, 50);
// // cal.Multiplicar(15, 45);
// // cal.Dividir(2, 2);
// // cal.Potencia(3, 3);
// // cal.Seno(30);
// // cal.Coseno(30);
// // cal.Tangente(30);
// // cal.RaizQuadrada(9);






// // int numeroIncremento = 10;
// // Console.WriteLine("Incrementando 10");
// // //numeroIncremento = numeroIncremento + 1;
// // numeroIncremento++;
// // Console.WriteLine(numeroIncremento);


// // int numeroDecremento = 20;
// // Console.WriteLine("Decrementando 20");
// // //numeroDecremento = numeroDecremento - 1;
// // numeroDecremento--;
// // Console.WriteLine(numeroDecremento);



// // bool choveu = true;
// // bool estaTarde = false;

// // if (!choveu && !estaTarde)
// // {
// //     Console.WriteLine("Vou pedalar");
// // }
// // else
// // {
// //     Console.WriteLine("Vou pedalar um outro dia");
// // }


// // bool possuPresencaMinima = false;
// // double media = 7.5;

// // if (possuPresencaMinima && media >= 7)
// // {
// //     Console.Clear();
// //     Console.WriteLine("Aprovado");
// // }
// // else
// // {
// //     Console.Clear();
// //     Console.WriteLine("Reprovado");
// // }




// // bool ehMaiorDeIdade = false;
// // bool possuiAtorizacaoDoResponsavel = false;

// // if (ehMaiorDeIdade || possuiAtorizacaoDoResponsavel)
// // {
// //     Console.Clear();
// //     Console.WriteLine("Entrada liberada");
// // }
// // else
// // {
// //     Console.Clear();
// //     Console.WriteLine("Entrada não liberada");
// // }

// // Console.Clear();
// // Console.WriteLine("Difgite uma letra");
// // String letra = Console.ReadLine();


// // switch (letra)
// // {

// //     case "a":
// //     case "e":
// //     case "i":
// //     case "o":
// //     case "u":

// //         Console.WriteLine("Vogal");
// //         break;

// //     default:
// //         Console.WriteLine("Não é vogal");
// //         break;
// // }


// /*----------------------------------------------------------------------------------------

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal");
// }

// Console.Clear();
// Console.WriteLine("Difgite uma letra");
// String letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.Clear();
//     Console.WriteLine("Não é vogal");
// }


// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {

//     Console.WriteLine("Venda invalida");
// }

// else if (possivelVenda)
// {

//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada no estoque");
// }

// // String a = "15-";

// // //int b = 0;

// // int.TryParse(a, out int b);

// // Console.WriteLine(b);
// // Console.WriteLine("Conversão realizada com sucesso!");



// // double a = 4 / (2 + 2); // Prioridade está dentro dos parenteses

// // Console.WriteLine(a);


// // int a = 5;
// // double b = a;

// // int a = 5;
// // long b = a;

// // Console.WriteLine(b);



// // int inteiro = 5;
// // string a = inteiro.ToString();

// // Console.WriteLine(a);





// // int a = 10;
// // int b = 20;

// // int c = a+ b;

// // c += 5; //c = c +5;
// // Console.WriteLine(c);




// // Cast - Casting
// // int a = Convert.ToInt32("5");
// // int a = int.Parse("5");

// // Console.WriteLine(a);


// //  DateTime dataAtual = DateTime.Now.AddDays(5);
// //  Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// // string apresentacao = "Olá, seja bem vindo";

// // int quantidade = 1;
// // Console.WriteLine("Valor da variável quantidade: " + quantidade);

// // quantidade = 10;
// // Console.WriteLine("Valor da variável quantidade: " + quantidade);


// // double altura = 1.5;

// // decimal preco = 1.80M;

// // bool condicao = true;


// // Console.WriteLine(apresentacao);
// // Console.WriteLine("Valor da variável quantidade: " + quantidade);
// // Console.WriteLine("Valor da variável altura: " + altura.ToString("0,00"));
// // Console.WriteLine("Valor da variável preco: " + preco);
// // Console.WriteLine("Valor da variável condição: " + condicao);


// // Pessoa pessoa1 = new Pessoa();

// // pessoa1.Nome = "Marcelo";
// // pessoa1.Idade = 45;
// // pessoa1.Apresentar();
// ---------------------------------------------------------------------------------------*/