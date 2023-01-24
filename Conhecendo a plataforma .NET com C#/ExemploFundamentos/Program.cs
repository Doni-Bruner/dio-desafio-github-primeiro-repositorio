using ExemploFundamentos.Models;

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia!");
}











// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }













// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Autorizada!");
// }
// else
// {
//     Console.WriteLine("Entrada não Autorizada!");
// }













// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal!");
//         break;

//     default:
//         Console.WriteLine("Não é uma Vogal!");
//         break;    
// }









// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }



















// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, Não temos a quantidade desejada em estoque!");
// }










// string a = "15";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso.");











// double a = 4 / 2 + 2;

// Console.WriteLine(a);












// int a = 5;
// double b = a;

// Console.WriteLine(b);











// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);








// Cast - Casting
// int a = Convert.ToInt32("5"); // aceita valores nulo, nao geram erro no programa
// int a = int.Parse("5"); // não aceita valores nulo, gera erro no programa

// Console.WriteLine(a);







// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;
// c += 5;

// Console.WriteLine(c);





// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yy"));




// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("valor da variavel quantidade: " + quantidade);
// Console.WriteLine("valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("valor da variavel preco: " + preco);
// Console.WriteLine("valor da variavel condição: " + condicao);






//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Doni";
//pessoa1.Idade = 29;
//pessoa1.Apresentar();
