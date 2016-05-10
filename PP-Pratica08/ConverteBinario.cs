using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método ConverteBinario, que recebe um número inteiro e exibe a sua conversão em binário.
 * Escreva o método Main, que solicita que o usuário digite vários valores inteiros e para cada valor, chama
 * o método ConverteBinario para exibir a sua conversão em binário. O programa deve perguntar se o
 * usuário deseja continuar (s/n). Se o usuário digitar “s”, solicita novamente outro valor. Se o usuário
 * digitar “n”, encerra o programa. 
*/

namespace PP_Pratica08
{
    class ConverteBinario
    {
        public void exibir()
        {
            Char opc = 'n';

            do
            {

                Console.Write("Digite um número:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(converteBinario(n));

                Console.WriteLine("Deseja continuar: [s/n] ");
                opc = char.Parse(Console.ReadLine());
            } while (opc == 's');
        }

        public string converteBinario(int n)
        {
            string y = "";
            int x = n / 2;
            int x1 = x * 2;
            int x2 = n - x1;
            string y0 = x2.ToString();

            do
            {
                n = x;
                x = n / 2;
                x1 = x * 2;
                x2 = n - x1;
                y += x2;
            } while (x > 0);
            return (y0 + y);
        }
    }
}
