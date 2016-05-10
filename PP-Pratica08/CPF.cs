using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método ValidaCPF, que recebe uma string contendo o valor de um CPF e devolve true se o CPF
 * for válido e false, caso contrário.
 * Para validar o CPF, deve-se seguir o algoritmo a seguir. Vamos supor que o CPF seja “ABC.DEF.GHI-XY”.
 * O método deve calcular os dígitos verificadores e comparar se os dígitos XY estão corretos. 
 * Passos para calcular os dígitos verificadores:
 * a) Multiplicar o dígito A por 10, o dígito B por 9, o dígito C por 8 e assim sucessivamente até o dígito I
 * que deve ser multiplicado por 2.
 * b) Calcular a soma de todos os valores obtidos no passo anterior.
 * c) Dividir o total obtido no passo anterior por 11 (divisão inteira). Se o resto da divisão for menor que 2,
 * o primeiro dígito verificador deve ser 0. Caso contrário, subtrair 11 do valor obtido. (esse número é o X)
 * d) Multiplicar o dígito A por 11, o dígito B por 10, o dígito C por 9 e assim sucessivamente até o dígito
 * X que deve ser multiplicado por 2.
 * e) Calcular a soma de todos os valores obtidos no passo anterior.
 * f) Dividir o total obtido no passo anterior por 11 (divisão inteira). Se o resto da divisão for menor que 2,
 * o segundo dígito verificador deve ser 0. Caso contrário, subtrair 11 do valor obtido. (esse número é o Y)
 * Dica: Para isolar os dígitos da string, pode-se utilizar o método Substring, que recebe 2 valores: o
 * primeiro valor indica o índice do dígito que se quer isolar da string, começando de zero (como num
 * array), o segundo valor indica quantos dígitos se quer isolar.
 * Por exemplo:
 * String numero= “01234”; //deve-se usar String com S maiúsculo
 * String num1 = numero.Substring(0,3);
 * //a partir do primeiro dígito, isola 3 caracteres
 * //num1 será igual a “012”
 * String num2 = numero.Substring(3,2);
 * //a partir do quarto dígito, isola 2 caracteres
 * //num2 será igual a “34”
 * int digito = int.Parse(numero.Substring(2,1));
 * //a partir do 3º dígito, isola 1 caractere, transformando-o em
 * //inteiro. Dessa forma, digito será igual a 2.
 * //exemplo para isolar os dígitos do CPF
 * String CPF = “123.456.789-01”;
 * int a= int.Parse(CPF.Substring(0,1));
 * int b= int.Parse(CPF.Substring(1,1));
 * int c= int.Parse(CPF.Substring(2,1));
 * int x= int.Parse(CPF.Substring(12,1));
 * int y= int.Parse(CPF.Substring(13,1));
 * Escreva o Main, que solicita que o usuário digite vários CPFs e para cada CPF digitado, chama o método
 * ValidaCPF, passando a string digitada. O método Main deve exibir se o CPF é valido ou não. Pergunte
 * ao usuário deseja continuar (s/n). Se digitar “s”, continue. Se digitar “n”, encerre o programa.
 */


namespace PP_Pratica08
{
    class CPF
    {
        public void exibir()
        {
            char opc = 's';

            string cpf = "";
            do
            {
                Console.Write("Digite um CPF: ");
                cpf = Console.ReadLine();

                if (ValidaCPF(cpf))
                {
                    Console.WriteLine("CPF Válido");
                }
                else
                {
                    Console.WriteLine("CPF Inválido");
                }
                Console.WriteLine();
                Console.Write("Deseja continuar: [s/n]");
                opc = char.Parse(Console.ReadLine());
            } while (opc == 's');
        }


        public bool ValidaCPF(string cpf)
        {
            String a = cpf.Substring(0, 1);
            String b = cpf.Substring(1, 1);
            String c = cpf.Substring(2, 1);
            String d = cpf.Substring(4, 1);
            String e = cpf.Substring(5, 1);
            String f = cpf.Substring(6, 1);
            String g = cpf.Substring(8, 1);
            String h = cpf.Substring(9, 1);
            String i = cpf.Substring(10, 1);
            String x = cpf.Substring(12, 1);
            String y = cpf.Substring(13, 1);

            //Corrige bug;
            string n = a + b + c + d + e + f + g + h + i + x + y;
            if ( n == "00000000000" || n == "11111111111" || n == "22222222222" || n == "33333333333" || n == "44444444444" ||  n == "55555555555" ||  n == "66666666666" ||  n == "77777777777" || n == "88888888888" || n == "99999999999")
            {
                return false;
            }
                

            int A, B, C, D, E, F, G, H, I;
            A = int.Parse(a) * 10;
            B = int.Parse(b) * 9;
            C = int.Parse(c) * 8;
            D = int.Parse(d) * 7;
            E = int.Parse(e) * 6;
            F = int.Parse(f) * 5;
            G = int.Parse(g) * 4;
            H = int.Parse(h) * 3;
            I = int.Parse(i) * 2;
            
            int soma = A + B + C + D + E + F + G + H + I;
            int soma1 = A + B + C + D + E + F + G + H + I;
            int restDiv = (soma * 10) % 11;
            int restDiv1 = (soma * 10) % 11;
            int rst1= 0, rst2 = 0;

            if(restDiv == int.Parse(x))
            {            
                rst1 = restDiv;           
            }
            else if (restDiv == 10)
            {
                rst1 = 0;
            }

            A = int.Parse(a) * 11;
            B = int.Parse(b) * 10;
            C = int.Parse(c) * 9;
            D = int.Parse(d) * 8;
            E = int.Parse(e) * 7;
            F = int.Parse(f) * 6;
            G = int.Parse(g) * 5;
            H = int.Parse(h) * 4;
            I = int.Parse(i) * 3;
            int X = int.Parse(x) * 2;
           
            soma = A + B + C + D + E + F + G + H + I + X;
            restDiv = (soma * 10) % 11;

            if (restDiv == int.Parse(y))
            {
                rst2 = restDiv;
            }
            else if (restDiv == 10)
            {
                rst2 = 0;
            }

            if (rst1 == int.Parse(x) && rst2 == int.Parse(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

