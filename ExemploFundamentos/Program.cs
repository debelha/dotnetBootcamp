﻿using System.ComponentModel;
using System.Diagnostics;
using ExemploFundamentos.Common.Models;

/* EXERCÍCIOS DE FIXAÇÃO


16- LISTAS:

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("BA");

//Percorrendo a lista com FOR
for(int contador = 0; contador <listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

//Percorrendo a lista com FOREACH
int contadorForEach = 0;
foreach(string item in listaString) {
    Console.WriteLine($"Posição N° {contadorForEach} - {item}");
    contadorForEach++;
}





15- ARRAYS:

int[] arrayInteiros = new int [3]; 

arrayInteiros[0] = 72; 
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

//Percorrendo o array com FOR
for(int contador = 0; contador < arrayInteiros.Length; contador++) {
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

//Percorrendo o array com FOREACH
foreach(int valor in arrayInteiros) {
    Console.WriteLine(valor);
}

//Redimensionando o array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Copiando o array
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);





14- MENU INTERATIVO:

string opcao;
bool menu = true;

while(menu) {
    Console.Clear();
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1- Cadastrar cliente ");
    Console.WriteLine("2- Buscar cliente ");
    Console.WriteLine("3- Apagar cliente ");
    Console.WriteLine("4- Encerrar");

    opcao = Console.ReadLine(); 

    switch(opcao) {
        
        case "1":
            Console.WriteLine("Cadastro cliente"); 
            break; 

        case "2":
            Console.WriteLine("Busca cliente"); 
            break; 

        case "3":
            Console.WriteLine("Apagar cliente"); 
            break; 

        case "4":
            Console.WriteLine("Programa encerrado"); 
            menu = false;
            break; 

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}





13- LAÇO DE REPETIÇÃO DO WHILE:

int soma = 0; 
int numero = 0;

do {
    Console.WriteLine("Digite o número para parar o programa: ");
    numero = Convert.ToInt32(Console.ReadLine());  

    soma += numero;

} while(numero != 0);

Console.WriteLine($"A soma dos números digitados é: {soma}");





12- LAÇO DE REPETIÇÃO WHILE:

int numero =5;
int contador = 0;

while (contador <= 10) {
Console.WriteLine($"{contador}° Execução: {numero} * {contador} = {numero * contador}");
contador++;
}





11- LAÇO DE REPETIÇÃO FOR:

int numero = 5;

for(int contador = 0; contador <=10; contador++){
    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
}





10- INCREMENTO E DECREMENTO:

int numero = 10;

Console.WriteLine(numero);

Console.WriteLine("Incrementando o 10"); 
numero++;

Console.WriteLine(numero); 






9- CLASSE MATH E FUNÇÕES TRIGONOMÉTRICAS:

Calculadora calc = new Calculadora();

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);





8- CLASSE MATH E POTÊNCIA:

Calculadora calc = new Calculadora();
calc.Potencia(3, 3);





7- OPERADORES ARITIMÉTICOS:

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);





6- OPERADOR LÓGICO "!" :

bool choveu = true;
bool estaTarde = true; 

if (!choveu && !estaTarde) {
    Console.WriteLine("Vou pedalar!"); 
}
else {
    Console.WriteLine("Vou pedalar outro dia!");
}





5- OPERADOR LÓGICO "&&":

bool presencaMinima = true;
double media = 7.5;

if (presencaMinima && media >= 7) {
    Console.WriteLine("Aprovado!");
}
else {
    Console.WriteLine("Reprovado!");
}





4- OPERADORE LÓGICO "||":

bool maiorDeIdade = true;
bool autorizaçãoResponsável = false;

if (maiorDeIdade || autorizaçãoResponsável) {
    Console.WriteLine("Entrada autorizada!");
}
else {
    Console.WriteLine("Entrada não autorizada!");
}





3- OPERADORES CONDICIONAIS COM SWITCH CASE:

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





2- OPERADORES CONDICIONAIS COM IF ELSE:

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





1- SINTAXE E INDENTAÇÃO:

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Deborah";
pessoa1.Idade = "25";
pessoa1.Apresentar();

*/