using System;

class Program

{
    static void Main(){

        string nome = ("Lys Vic");
        int idade = (18);
        decimal saldoBancario = (10.999m);
        bool contaAtiva = true;
        char categoriaCliente = 'A';

        Console.WriteLine("Cadastro do Cliente: ");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade + "anos");
        Console.WriteLine("Saldo bancário R$ :" + saldoBancario);
        Console.WriteLine("Conta ativa:" + contaAtiva);
        Console.WriteLine("Categoria do cliente: " + categoriaCliente);
    }


}