using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Selecione a operação desejada: 1 Adição, 2 Subtração, 3 Multiplicação e 4 Divisão.");
        int operacao = Convert.ToInt32(Console.ReadLine());

        int cont = 0;
        while (true)
        {
            switch (operacao)
            {
                case 1:
                    double soma = (num1 + num2);
                    Console.WriteLine("Resultado :" + soma);
                    break;
                case 2:
                    double subtracao = (num1 - num2);
                    Console.WriteLine("Resultado :" + subtracao);
                    break;
                case 3:
                    double multiplicacao = (num1 * num2);
                    Console.WriteLine("Resultado :" + multiplicacao);
                    break;
                case 4:
                    double divisao = num1 / num2;
                    if (num2 != 0)
                    {
                        Console.WriteLine("Resultado: " + divisao);
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir um número por 0, digite outro número");
                        int contadorLoc = 0;
                        while (true)
                        {
                            Console.WriteLine("Digite o primeiro número: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo número: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + divisao);
                            break;
                        }
                        contadorLoc = contadorLoc + 1;
                        
                    }
                    break;
                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
            break;
        }
    }
}