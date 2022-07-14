using System;

namespace Exercicio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WhiteLine(" Seu nome: ");
            float nome = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira sua altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira sua idade: ");
            float idade = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é " + imc);

            if (imc < 18.5) ;
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25) ;
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc < 30) ;
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc => 30) ;
            {
                Console.WriteLine("Obesidade");
            }
            

         


        
            
        }



 
    }
}