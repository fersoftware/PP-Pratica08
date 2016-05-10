using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método MediaDivisores, que recebe um número inteiro n e devolve a média dos divisores desse
 * número n.
 * Escreva o método Main, que solicita que o usuário digite um valor que deva ser maior ou igual a 5 e
 * menor ou igual a 100. Se o número não estiver nesse intervalo, deve solicitar que o usuário digite
 * novamente. Depois de lido o valor válido, deve chamar o método MediaDivisores e exibir o retorno do
 * método.
 */

namespace PP_Pratica08
{
    class MediaDivisor
    {
        public void exibir()
        {
            int n;
            

            do
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if (n < 5 && n > 100) Console.WriteLine("Número Inválido");
            } while (n < 5 && n > 100);

            Console.WriteLine("Media da Soma dos Divisores é: {0}", MediaDivisores(n));
        }

        public int MediaDivisores(int n)
        {
            int soma = 0, c = 0;            
            for (int i = 1; i <= 10; i++)
            {
                if( n %i == 0)
                {
                    Console.WriteLine("Divisor: {0}", i);
                    c++;
                    soma += i;                   
                }
            }

            return soma / c;
        }
    
    }
}
