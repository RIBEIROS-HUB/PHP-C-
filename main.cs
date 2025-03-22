using System;

class Program

{
    static void Main(){

        string nomeProduto= ("Energético");
        string nomeProduto2= ("Funko Pop do Homem-Aranha");
        int codigoProduto = (3456789);
        int codigoProduto2 = (5984689);
        decimal preco = (15.00m);
        decimal preco2 = (135.65m);
        int quantidade = (12);
        int quantidade2 = (4);
        bool disponibilidade = true;
        bool disponibilidade2 = true;

        Console.WriteLine("Cadastro dos produtos: ");
        Console.WriteLine("Nome: " + nomeProduto);
        Console.WriteLine("Código: " + codigoProduto);
        Console.WriteLine("R$: " + preco);
        Console.WriteLine("Em estoque: " + quantidade);
        Console.WriteLine("Disponibilidade: " + disponibilidade);
        Console.WriteLine("Nome: " + nomeProduto2);
        Console.WriteLine("Código: " + codigoProduto2);
        Console.WriteLine("R$: " + preco2);
        Console.WriteLine("Em estoque: " + quantidade2);
        Console.WriteLine("Disponibilidade: " + disponibilidade2);
    }


}