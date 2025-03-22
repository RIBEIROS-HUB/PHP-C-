using System;
 
class Program {
    static void Main() {

        Console.WriteLine("Digite um número (de 1 a 7): ");
        int dias = Convert.ToInt32(Console.ReadLine());
 
        switch (dias)
        {
            case 1:
                Console.WriteLine("Segunda");
                break;
            case 2:
                Console.WriteLine("Terça");
                break;
            case 3:
                Console.WriteLine("Quarta");
                break;
            case 4:
                Console.WriteLine("Quinta");
                break;
            case 5:
                Console.WriteLine("Sexta");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Insira um número válido");
                break;
        }
        
    }
}