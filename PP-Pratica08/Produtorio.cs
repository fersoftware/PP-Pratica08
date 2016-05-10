using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Elabore um método em C# chamado Produtorio, que não retorna valor, e que recebe um número
 *  inteiro. Esse método deve calcular e exibir a multiplicação de todos os números de 1 até o número
 *  recebido. Por exemplo, se o número for 5, o método deve calcular a multiplicação 1 x 2 x 3 x 4 x 5, que
 *  é igual a 120, e exibir o resultado.
 *  Nesse mesmo namespace, o método Main deve:
 *  - solicitar que o usuário digite um valor inteiro maior do que 4.
 *  - caso o número seja menor ou igual a 4, deve solicitar novamente, até que o número digitado seja
 *  maior do que 4.
 *  - chamar o método Produtorio, passando o número lido.
 */

namespace PP_Pratica08
{
    class Produtorio
    {
        public void exibir()
        {
            int n;

            do
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 4) Console.WriteLine("Número Inválido");

            } while (n <= 4);

            produtorio(n);
        }

        public void produtorio(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}",i);
                if (i < n) Console.Write("X");
            }   
        }
    }
}
