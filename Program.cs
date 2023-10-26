using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
                Criar um script que solicite 2 numeros ao usuario
              e ao final mostre a soma dos valores
            */

            //Define as variaveis
            decimal numero_um;
            decimal numero_dois;
            decimal resultadomult;
            decimal resultadosub;
            decimal resultadodiv;
            decimal resultadoadicao;
            decimal opcaocalc;
            decimal resultmed;
            decimal resultimc;
            decimal opcao;
            decimal media1;
            decimal media2;
            decimal media3;
            decimal media4;
            string nome;
            decimal idade;
            char sexo;
            decimal peso;
            decimal altura;
            decimal altura2;
            

            Console.WriteLine("Escolha uma Opção: \r\n Opção 1: Calculadora Básica      \r\n Opção 2: Calculo Média             \r\n Opção 3: Calculo IMC");
            opcao = Convert.ToDecimal(Console.ReadLine());
            if (opcao == 1) {
                Console.WriteLine("Informe o primeiro numero: ");
                numero_um = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                numero_dois = Convert.ToDecimal(Console.ReadLine());







                Console.WriteLine(
                    "Escolha uma Opção: Opção 1: Adição\r\n                Opção 2: Subtração\r\n                Opção 3: Divisão\r\n                Opção 4: Multiplicação"
                );
                opcaocalc = Convert.ToDecimal(Console.ReadLine());
                resultadoadicao = numero_um + numero_dois;
                resultadomult = numero_um * numero_dois;
                resultadodiv = numero_um / numero_dois;
                resultadosub = numero_um - numero_dois;

                if (opcaocalc == 1)
                {
                    Console.WriteLine(
                    "A soma dos numeros " + numero_um + " e " + numero_dois + " é: " + resultadoadicao
                   );
                }
                else if (opcaocalc == 2)
                {
                    Console.WriteLine(
                   "A subtracão dos numeros " + numero_um + " e " + numero_dois + " é: " + resultadosub
                  );
                }
                else if (opcaocalc == 3)
                {
                    Console.WriteLine(
                   "A divisão dos numeros " + numero_um + " e " + numero_dois + " é: " + resultadodiv
                  );
                }
                else if (opcaocalc == 4)
                {
                    Console.WriteLine(
                    "A multiplicação dos numeros " + numero_um + " e " + numero_dois + " é: " + resultadomult
                   );
                }

                else
                {
                    Console.WriteLine("opcao Invalida");
                }
            }
            else if (opcao == 2) {
                Console.WriteLine("Informe o primeiro numero: ");
                media1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                media2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o primeiro numero: ");
                media3 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                media4 = Convert.ToDecimal(Console.ReadLine());

                resultmed = (media1 + media2 + media3 + media4) / 4;

                Console.WriteLine(
                    "A média dos numeros " + media1 + " e " + media2 + " e " + media3 + " e " + media4 + " é: " + resultmed
                   ); }

            else if (opcao == 3)
            {
                Console.WriteLine("Por favor, informe seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Por favor, Informe sua idade: ");
                idade = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Por favor, Informe seu sexo: (Utilize apenas M ou F)");
                sexo = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Por favor, Informe seu peso(Em Kg): ");
                peso = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Por favor, Informe sua altura(Em Metros): ");
                altura = Convert.ToDecimal(Console.ReadLine());

                altura2 = altura * altura;
                resultimc = peso / altura2;
               
                
                Console.WriteLine("Olá " + nome);
                Console.WriteLine("Idade: " + idade + "\r\n Sexo: " + sexo + "\r\n Peso: " + peso + "\r\n Altura: " + altura );
                Console.WriteLine("IMC: " + resultimc);

                Console.ReadKey("Aguardando ação");

            }

        }
    }
}
