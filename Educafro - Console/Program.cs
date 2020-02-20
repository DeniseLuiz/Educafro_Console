using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educafro___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis 

            string vnome1;
            string vgenero;
            int[] vtcod = new int[10];
            double[] vtvalor = new double[10];
            string[] vnome = new string[10];
            int[] vtquantidade = new int[10];
            uint indice = 0;
            int cod;
            int qnt;
            string pergunta;
            int i;
            int[] qntd = new int[10];
            double[] subtotal = new double[10];
            double total = 0;

            // Interagindo com o usuário.

            Console.WriteLine(">>>>>>>>>>> OficinAfro <<<<<<<<<<<<");
            Console.WriteLine("-----------------------------------");

            Console.Write("Digite seu nome: ");
            vnome1 = Console.ReadLine();
            Console.Write("Qual gênero você se identifica? Digite 1 - Feminino, ou 2 - Masculino: ");

            vgenero = Console.ReadLine();

            // Aplicando o estrutura para UX de acordo com o genero.

            if (vgenero == "1")
            {

                Console.WriteLine("Olá, {0}. Bem vinda a OficinAfro.", vnome1);
            }
            else
            {

                Console.WriteLine("Olá, {0}. Bem vindo a OficinAfro.", vnome1);
            }

            Console.ReadKey();

            // Atribuindo Nomes
            vnome[0] = "Camisa Masc Tshirt:     ";
            vnome[1] = "Macacão Saruel:         ";
            vnome[2] = "Colete Afro:            ";
            vnome[3] = "Meia Resistência Afro:  ";
            vnome[4] = "Conjunto Masc floral:   ";
            vnome[5] = "Kimono Afro             ";
            vnome[6] = "Calça jeans skin:       ";
            vnome[7] = "Saia longa afro:        ";
            vnome[8] = "Moletom Pantera negra:  ";
            vnome[9] = "Bata florida solta:    ";

            // Atribuindo Códgio
            vtcod[0] = 01;
            vtcod[1] = 02;
            vtcod[2] = 03;
            vtcod[3] = 04;
            vtcod[4] = 05;
            vtcod[5] = 06;
            vtcod[6] = 07;
            vtcod[7] = 08;
            vtcod[8] = 09;
            vtcod[9] = 10;

            // Atribuindo Valor unitário
            vtvalor[0] = 29.90;
            vtvalor[1] = 74.99;
            vtvalor[2] = 42.90;
            vtvalor[3] = 19.90;
            vtvalor[4] = 60.00;
            vtvalor[5] = 67.99;
            vtvalor[6] = 79.90;
            vtvalor[7] = 74.90;
            vtvalor[8] = 99.90;
            vtvalor[9] = 58.90;

            // Atribuindo  Quantidade em estoque 
            vtquantidade[0] = 05;
            vtquantidade[1] = 11;
            vtquantidade[2] = 08;
            vtquantidade[3] = 20;
            vtquantidade[4] = 13;
            vtquantidade[5] = 09;
            vtquantidade[6] = 15;
            vtquantidade[7] = 03;
            vtquantidade[8] = 10;
            vtquantidade[9] = 16;

            // Apresentar lista de produtos. O do atua rodando o programa enquanto o usuário digitar "1".
            //teste
            do
            {
                Console.Clear();

                Console.WriteLine();

                Console.WriteLine("{0}, aqui está a lista de nossos produtos disponíveis:", vnome1);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" NOME                            COD            VALOR          ESTOQUE      ");



                // Utilizando contador para o programa correr por todos os produtos.
                indice = 0;
                while (indice < 10)
                {
                    Console.WriteLine();
                    Console.WriteLine(vnome[indice] + "   " + "       " + vtcod[indice] + "   " + "         " + vtvalor[indice].ToString("C") + "   " + "        " + vtquantidade[indice]);

                    indice = indice + 1;
                }

                Console.WriteLine();
                Console.WriteLine();

                // Usuário digita o código do produto do produto desejado
                do
                {
                    do
                    {
                        Console.Write("Digite o código do produto desejado: ");
                        cod = int.Parse(Console.ReadLine());

                        indice = 0;
                        hkgjgfj


                        while (cod != vtcod[indice])
                        {

                            indice = indice+1;

                        }
                        Console.WriteLine("O produto desejado é: " + vnome[indice]);

                        if (vtquantidade[indice] == 0)
                        {
                            Console.WriteLine("Produto indisponível no momento.");
                        }
                        if (qntd[indice] != 0)
                        {
                            Console.WriteLine("Produto já adicionado. Digite o código de outro produto.");
                        }

                    } while (qntd[indice] != 0);
                } while (vtquantidade[indice] == 0);

                Console.WriteLine();
                Console.WriteLine();


                // Usuário digita a quantidade desejada.
                Console.Write("Digite a quantidade desejada: ");
                qnt = int.Parse(Console.ReadLine());
                if (qnt == 0)
                {
                    do
                    {
                        Console.WriteLine("Quantidade inválida.");
                        Console.Write("Digite a quantidade desejada: ");
                        qnt = int.Parse(Console.ReadLine());
                    } while (qnt == 0); 
                    

                }

                while (qnt > vtquantidade[indice])
                {

                    // Caso a quantidade seja maior que a quantidade disponível em estoque
                    Console.WriteLine("Não temos essa quantidade disponível");
                    Console.Write("Digite a quantidade desejada: ");
                    qnt = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
                Console.WriteLine();

                qntd[indice] = qnt;

                // Cálculo da quantidade x preço.
                Console.WriteLine(vnome1 + ", O valor total é: " + "R$ " + (vtvalor[indice] * qnt) + ".");
                Console.WriteLine();
                Console.WriteLine();

                // Cálculo 9% de imposto.
                Console.WriteLine("O valor de imposto total é: " + "R$ " + (vtvalor[indice] * qnt * 0.09) + ".");

                vtquantidade[indice] = vtquantidade[indice] - qnt;

                Console.WriteLine();

                // O usuário decide que o programa será rodado novamente
                Console.WriteLine("Gostaria de continuar? S ou N");
                pergunta = Console.ReadLine();


            }
            while (pergunta == "S");

            Console.Clear();
            Console.WriteLine(" PRODUTOS                    QUANTIDADE          VALOR        SUBTOTAL        ");


            for (i = 0; i < 10; i++)
            {
                if (qntd[i] != 0)
                {
                    total = total + (qntd[i] * vtvalor[i]);

                    Console.WriteLine(" {0}        {1}                R${2}       R${3}        ", vnome[i], qntd[i], vtvalor[i], (qntd[i] * vtvalor[i]));
                    Console.WriteLine();
                }

            }

            Console.WriteLine();

            Console.WriteLine("                                                             TOTAL: R${0}", total);
            Console.WriteLine();
            Console.WriteLine("                                                             IMPOSTO: R${0}", (total * 0.09));


        }
    }
}
