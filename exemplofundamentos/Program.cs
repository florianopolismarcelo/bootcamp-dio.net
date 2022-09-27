//exemplofundamentos.Models.Pessoa p = new exemplofundamentos.Models.Pessoa();

using exemplofundamentos.Models;

Console.Clear();
Console.WriteLine("Difgite uma letra");
String letra = Console.ReadLine();

switch (letra)
{

    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é vogal");
        break;
}


/*----------------------------------------------------------------------------------------

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é vogal");
}

Console.Clear();
Console.WriteLine("Difgite uma letra");
String letra = Console.ReadLine();

if (letra == "a")
{
    Console.WriteLine("Vogal");
}
else if (letra == "a")
{
    Console.WriteLine("Vogal");
}
else if (letra == "e")
{
    Console.WriteLine("Vogal");
}
else if (letra == "i")
{
    Console.WriteLine("Vogal");
}
else if (letra == "o")
{
    Console.WriteLine("Vogal");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.Clear();
    Console.WriteLine("Não é vogal");
}


int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{

    Console.WriteLine("Venda invalida");
}

else if (possivelVenda)
{

    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada no estoque");
}

// String a = "15-";

// //int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");



// double a = 4 / (2 + 2); // Prioridade está dentro dos parenteses

// Console.WriteLine(a);


// int a = 5;
// double b = a;

// int a = 5;
// long b = a;

// Console.WriteLine(b);



// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);





// int a = 10;
// int b = 20;

// int c = a+ b;

// c += 5; //c = c +5;
// Console.WriteLine(c);




// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);


//  DateTime dataAtual = DateTime.Now.AddDays(5);
//  Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);


// double altura = 1.5;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0,00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Marcelo";
// pessoa1.Idade = 45;
// pessoa1.Apresentar();
---------------------------------------------------------------------------------------*/