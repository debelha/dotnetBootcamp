using System.Diagnostics;
using bootcamp.NET.models;


/* OPERATORS

//6- OPERADORES LÓGICOS: ! 

bool choveu = true;
bool estaTarde = true; 

if (!choveu && !estaTarde) {
    Console.WriteLine("Vou pedalar!"); 
}
else {
    Console.WriteLine("Vou pedalar outro dia!");
}





//5- OPERADORES LÓGICOS: &&

bool presencaMinima = true;
double media = 7.5;

if (presencaMinima && media >= 7) {
    Console.WriteLine("Aprovado!");
}
else {
    Console.WriteLine("Reprovado!");
}





//4- OPERADORES LÓGICOS: ||

bool maiorDeIdade = true;
bool autorizaçãoResponsável = false;

if (maiorDeIdade || autorizaçãoResponsável) {
    Console.WriteLine("Entrada autorizada!");
}
else {
    Console.WriteLine("Entrada não autorizada!");
}





//3- OPERADORES CONDICIONAIS COM SWITCH CASE

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine(); 

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Consoante");
        break;
}





//2- OPERADORES CONDICIONAIS COM IF ELSE

int quantidadeEmEstoque = 0; 
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0) {
    Console.WriteLine("A quantidade não pode ser zero.");
}
else if (possivelVenda) {
    Console.WriteLine("Venda realizada!");
}
else {
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque."); 
    }





//1- SINTAXE E INDENTAÇÃO

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Deborah";
pessoa1.Idade = "25";
pessoa1.Apresentar();

*/