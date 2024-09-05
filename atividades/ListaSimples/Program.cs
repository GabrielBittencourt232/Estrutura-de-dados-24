using System.Collections;

// Utilizando a Lista Simples
ArrayList arrList = new ();
arrList.Add(5);
arrList.Add("Mauricio");
//É possível adicionar um conjunto de valores de uma só vez
arrList.AddRange (new int[] {1, 2, 3});
// O método .Add() insere o valor ao final do vetor
arrList.Insert(1, 15);
// Já o método insert, me permite incluir o valor desejado na posição epecificada no primeiro parâmetro
// Lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// percorrendo a Lista com foreach
foreach(object obj in arrList)
{
    Console.WriteLine(obj);
}

//obtendo o tamanho total da lista
// Quantos elementos tem
int tamanho = arrList.Count;
// obter a capacidade
// Quantos podem ser armazenados
int capacidade = arrList.Capacity;

// percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write( $" | {arrList[i]}");
}

// Recursos importantes da Lista
// Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("Mauricio");
if(!contemNome)
    Console.WriteLine("Nome Mauricio não encontrado");

// Para saber o índice que contem o valor buscado
// Neste caso se o valor existir na lista ele retorna o índice (número inteiro)
// Caso o valor não exista na lista, retorna -1
int indiceDoValor = arrList.IndexOf("Mauricio");
if(indiceDoValor >= 0)
    Console.WriteLine( $"Mauricio está em [{indiceDoValor}]");
else
    Console.WriteLine("É, realmente não tem.");

// É possível remover itens da lista
arrList.Remove("Mauricio"); // Remove pelo valor
arrList.RemoveAt(4); // Remove no indice
arrList.RemoveRange(0,2); // O primeiro parâmetro é o índice e o segundo é quantas casas após o índice
