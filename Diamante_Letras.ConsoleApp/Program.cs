using System;

namespace Diamante_Letras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definição de variáveis
            string continuar = "";
            char[] letras = new char[26];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';
            letras[5] = 'F';
            letras[6] = 'G';
            letras[7] = 'H';
            letras[8] = 'I';
            letras[9] = 'J';
            letras[10] = 'K';
            letras[11] = 'L';
            letras[12] = 'M';
            letras[13] = 'N';
            letras[14] = 'O';
            letras[15] = 'P';
            letras[16] = 'Q';
            letras[17] = 'R';
            letras[18] = 'S';
            letras[19] = 'T';
            letras[20] = 'U';
            letras[21] = 'V';
            letras[22] = 'W';
            letras[23] = 'X';
            letras[24] = 'Y';
            letras[25] = 'Z';

            do
            {   //controle de entrada
                Console.Write("Digite um número impar entre 3 e 25: ");
                int alturaDoDiamante = int.Parse(Console.ReadLine());

                while (alturaDoDiamante < 3 || alturaDoDiamante > 25 || alturaDoDiamante % 2 == 0)
                {
                    Console.Write("Entrada inválida! um número impar entre 3 e 25: ");
                    alturaDoDiamante = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                int meioDaAlturaDoDiamante = (alturaDoDiamante - 1) / 2;
                int controlaLinhas = 1;
                string espacoDentro = " ";
                int indiceLetras = 1;


                char[] emBranco = new char[1];
                emBranco[0] = ' ';


                //primeira coluna
                for (int i = 0; i < meioDaAlturaDoDiamante; i++)
                {
                    Console.Write(emBranco[0]); //espaços em branco da primeira linha, antes da primeria letra. ex ---A
                }

                Console.WriteLine(letras[0]); // escreve a primeira letra

                //parte superior
                //for que roda a partir da segunda linha, até o meio
                for (int i = 0; i < meioDaAlturaDoDiamante; i++)
                {
                    //escreve os espaços em brancos a que tem antes da letra, a partir da segunda linha. 
                    for (int j = controlaLinhas; j < meioDaAlturaDoDiamante; j++)
                    {
                        Console.Write(emBranco[0]);
                    }

                    //escreve as letras + espaços de dentro
                    Console.Write(letras[indiceLetras] + espacoDentro + letras[indiceLetras]);
                    espacoDentro = espacoDentro + "  "; // espacoDentro inicia com um espaco em branco e a cada ciclo soma 2 espacos


                    //escreve os espaços em brancos a que tem depois da letra, a partir da segunda linha.
                    for (int l = controlaLinhas; l < meioDaAlturaDoDiamante; l++)
                    {
                        Console.Write(emBranco[0]);

                    }

                    Console.WriteLine();
                    controlaLinhas++; // pula pra proxima linha
                    indiceLetras++; // sobe o indice da letra, de A para B, de B para C...
                }

                //parte inferior
                //for que roda a partir do meio até a penultima linha

                controlaLinhas = meioDaAlturaDoDiamante; // definindo que a parte inferior do diamante vai começar a partir do meio
                indiceLetras = meioDaAlturaDoDiamante - 1; // indice da letra vai começar ao contrario do inicio
                int countroladorEspaco = espacoDentro.Length - 4; // cortando 4 posições do espaço

                for (int i = 1; i < meioDaAlturaDoDiamante; i++)
                {
                    //escreve os espaços em brancos a que tem antes da letra, a partir da linha do meio.
                    for (int j = controlaLinhas; j <= meioDaAlturaDoDiamante; j++)
                    {
                        Console.Write(emBranco[0]);
                    }

                    //escreve as letras + espaços de dentro
                    espacoDentro = espacoDentro.Substring(0, countroladorEspaco); // cortando a string 
                    Console.Write(letras[indiceLetras] + espacoDentro + letras[indiceLetras]);
                    countroladorEspaco = countroladorEspaco - 2; // cortando 2 posições da string

                    if (countroladorEspaco <= 1)
                    {
                        countroladorEspaco = 1; // não pode ser menor do que 1
                    }

                    //escreve os espaços em brancos a que tem depois da letra.
                    for (int l = controlaLinhas; l < meioDaAlturaDoDiamante; l++)
                    {
                        Console.Write(emBranco[0]);

                    }

                    Console.WriteLine();
                    controlaLinhas--;
                    indiceLetras--;
                }


                ////ultima linha
                for (int i = 0; i < meioDaAlturaDoDiamante; i++)
                {
                    Console.Write(emBranco[0]);
                }

                Console.WriteLine(letras[0]);
                Console.WriteLine();


                //controle para continuar o programa ou finalizar
                Console.Write("Digite C para CONTINUAR ou S para SAIR: ");
                continuar = Console.ReadLine();
                Console.WriteLine();

                while (continuar != "C" && continuar != "S")
                {
                    Console.Write("Entrada inválida! Digite C para CONTINUAR ou S para SAIR: ");
                    continuar = Console.ReadLine();
                    Console.WriteLine();
                }


            } while (continuar == "C");
        }
    }
}
