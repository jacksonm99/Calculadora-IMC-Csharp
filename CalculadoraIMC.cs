using System;

namespace AulasC_
{
    class CalculadoraIMC
    {
        static void Calculadora(string[] args)
        {
            double peso, altura, imc;
            Console.Write("Digite o seu peso:\n");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite o sua altura: \n");
            altura = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            Console.WriteLine($"O seu IMC é {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if ((imc == 18.5) || (imc < 25))
            {
                Console.WriteLine("Você está no peso ideal");

            }
            else if ((imc == 25) || (imc < 30))
            {
                Console.WriteLine("Você está acima do peso");
            }
            else if ((imc == 30) || (imc < 35))
            {
                Console.WriteLine("Você está com Obesidade Grau I");
            }
            else if ((imc == 35) || (imc < 40))
            {
                Console.WriteLine("Você está com Obesidade Grau II");

            }
            else
            {
                Console.WriteLine("Você está com Obesidade Grau III (Obesidade Mórbida)");
            }


        }
    }
}
