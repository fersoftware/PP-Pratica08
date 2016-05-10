using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método Moedeira, que recebe um valor em centavos e devolve uma string dizendo quantas e
 * quais moedas correspondem ao valor fornecido. Por exemplo, 27 centavos corresponde a 1 moeda de
 * R$ 0,25, 1 moeda de R$ 0,05 e 2 moedas de R$ 0,01. (Priorize a moeda de maior valor).
 * Escreva o método Main, que solicita que o usuário digite vários valores abaixo de 1 real e para cada
 * valor lido, chama o método Moedeira, passando o valor como parâmetro e exibe a string retornada pelo
 * método, dizendo quantas e quais moedas correspondem ao valor fornecido. Depois de exibir essa string,
 * o programa deve perguntar se o usuário deseja continuar (s/n). Se o usuário digitar “s”, solicita
 * novamente outro valor. Se o usuário digitar “n”, encerra o programa. 
 */

namespace PP_Pratica08
{
    class ContaMoeda
    {
        public void exibir()
        {
            char opc = 's';

            float valor = 0;
            do
            {
                do
                {
                    Console.Write("Digite um valor em centavos: ");
                    valor = float.Parse(Console.ReadLine());
                    valor *= 100;
                    if (valor > 99  || valor <= 0) Console.WriteLine("Valor Incorreto");
                } while (valor > 99 );
                
                Moedeira(valor);
                Console.WriteLine();
                Console.Write("Deseja continuar: [s/n]");
                opc = char.Parse(Console.ReadLine());
            } while (opc == 's');
        }

        public void Moedeira(float n)
        {
            
            if (n > 50)
            {
                Console.WriteLine("1 moeda de 0,50");
                n -= 50;
            }
                

            if ( n >= 24 && n <= 49)
            {
                n -= 25;
                Console.WriteLine("1 moeda de 0,25");                    
                if ((n / 10) > 0.9) Console.WriteLine("{0} moeda(s) de 10", (n - (n % 10)) / 10);
                if (n % 10 > 0) Console.WriteLine("{0} moeda(s) de 1", n % 10);
            }
            else
            {
                if ((n / 10) > 0.9) Console.WriteLine("{0} moeda(s) de 10", (n - (n % 10)) / 10);
                if (n % 10 > 0) Console.WriteLine("{0:0} moeda(s) de 1", n % 10);
            }
                
            
        }
    }
}
