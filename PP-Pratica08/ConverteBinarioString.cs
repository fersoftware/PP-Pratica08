using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método ConverteBinarioString, que recebe um número inteiro e retorna uma string com a sua
 * conversão em binário.
 * Escreva o método Main, que solicita que o usuário digite vários valores inteiros e para cada valor, chama
 * o método ConverteBinarioString para obter a string correspondente à sua conversão em binário. O
 * programa deve ler vários valores até ler um número negativo, quando então, não deverá chamar o * método e deverá encerrar.
 */

namespace PP_Pratica08
{
    class ConverteBinarioString
    {
        public void exibir()
        {
            int n = 0;
            do
            {
                Console.Write("Digite um número:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(converteBinario(n));
            } while (n > 0);

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
