using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método Carteira, que recebe um valor em reais (sem a parte dos centavos) e devolve uma
 * string dizendo quantas e quais notas em reais correspondem ao valor fornecido. Por exemplo. R$ 357,00
 * corresponde a 3 notas de R$ 100,00, 1 nota de R$ 50,00, 1 nota de R$ 5,00 e 1 nota de R$ 2,00.
 * (Priorize a nota de maior valor).
 * Escreva o método Main, que solicita que o usuário digite vários valores em reais e para cada valor lido,
 * chama o método Carteira, passando o valor como parâmetro e exibe a string retornada pelo método,
 * dizendo quantas e quais notas em reais correspondem ao valor fornecido. Depois de exibir essa string,
 * o programa deve perguntar se o usuário deseja continuar (s/n). Se o usuário digitar “s”, solicita
 * novamente outro valor. Se o usuário digitar “n”, encerra o programa.
 */

namespace PP_Pratica08
{
    class Carteira
    {
        public void exibir()
        {
            char opc = 's';

            int valor = 0;
            do
            {
                Console.Write("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());                
                carteira(valor);
                Console.WriteLine();
                Console.Write("Deseja continuar: [s/n]");
                opc = char.Parse(Console.ReadLine());
            } while (opc == 's');

        }

        public void carteira(int n)
        {
            if ((n / 1000) != 0) Console.WriteLine("{0} nota(s) de 1000",  (n / 1000));
            if (n / 100 != 0) Console.WriteLine("{0} nota(s) de 100", (n - ((n / 1000) * 1000)) / 100);
            if ((n % 100) / 10 != 0) Console.WriteLine("{0} nota(s) de 10", (n % 100) / 10);
            if (n % 10 != 0 ) Console.WriteLine("{0} nota(s) de 1", n % 10);
        }
    }
}
