using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo a Lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador ++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a Lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach ++;
// }


















// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador ++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }





// Console.WriteLine("Percorrendo o array com o FOREACH");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }














// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Doni";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();















// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente.");
//     Console.WriteLine("2 - Buscar Cliente.");
//     Console.WriteLine("3 - Apagar Cliente.");
//     Console.WriteLine("4 - Encerrar.");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente.");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente.");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente.");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar!");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }
//     Console.WriteLine("O programa encerrou!");













// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
//     Console.WriteLine($"Soma = {soma}\n");

// } while(numero != 0);

//     Console.WriteLine($"Total é: {soma}, \n \nPrograma finalizado!");













// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//      Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//      contador++;
// }












// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }











// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero++;

// Console.WriteLine(numero);












//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);












// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia!");
// }











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
