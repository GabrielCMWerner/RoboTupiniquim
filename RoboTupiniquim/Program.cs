using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] areaY = new int[5];
            int[] areaX = new int[5];

            int maxy = 5;
            int maxx = 5;


            int roboy1 = 0;
            int robox1 = 0;
            char direcao1 = 'N';


            int roboy2 = 0;
            int robox2 = 0;
            char direcao2 = 'N';

            Console.WriteLine("5 5");

            Console.WriteLine("Digite a posição inicial do robo:");
            string posicao = Console.ReadLine();


            string[] posicaoRobo = posicao.ToUpper().Split(" ");
            robox1 = int.Parse(posicaoRobo[0]);
            roboy1 = int.Parse(posicaoRobo[1]);
            direcao1 = char.Parse(posicaoRobo[2]);


            Console.WriteLine("Digite os comandos do primeiro Robô: ");

            string comandos1 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite a posição inicial do robo:");
            string posicao2 = Console.ReadLine();


            string[] posicaoRobo2 = posicao2.ToUpper().Split(" ");
            robox2 = int.Parse(posicaoRobo2[0]);
            roboy2 = int.Parse(posicaoRobo2[1]);
            direcao2 = char.Parse(posicaoRobo2[2]);

            Console.WriteLine("Digite os comandos do segundo Robô: ");
            string comandos2 = Console.ReadLine();





            char[] quebrados1 = new char[50];
            quebrados1 = comandos1.ToUpper().ToCharArray();

            char[] quebrados2 = new char[50];
            quebrados2 = comandos2.ToUpper().ToCharArray();

            for (int i = 0; i < quebrados1.Length; i++)
            {
                if (quebrados1[i] != null)
                {
                    switch (quebrados1[i])
                    {
                        case 'M':
                            if(direcao1 == 'N')
                            {
                                if(roboy1 < maxy) roboy1++;
                            }

                            else if(direcao1 == 'S')
                            {
                                if(roboy1 > 0) roboy1--;
                            }

                            else if (direcao1 == 'O')
                            {
                                if (robox1 > 0) robox1--;
                            }

                            else if (direcao1 == 'L')
                            {
                                if (robox1 > maxx) robox1--;
                            }
                        break;



                        case 'E':
                            if (direcao1 == 'N')
                            {
                                direcao1 = 'O'; 
                            }

                            else if (direcao1 == 'O')
                            {
                                direcao1 = 'S';
                            }

                            else if (direcao1 == 'S')
                            {
                                direcao1 = 'L';
                            }

                            else if (direcao1 == 'L')
                            {
                                direcao1 = 'N';
                            }

                        break;



                        case 'S':
                            if (direcao1 == 'N')
                            {
                                direcao1 = 'L';
                            }

                            else if (direcao1 == 'L')
                            {
                                direcao1 = 'S';
                            }

                            else if (direcao1 == 'S')
                            {
                                direcao1 = 'O';
                            }

                            else if (direcao1 == 'O')
                            {
                                direcao1 = 'N';
                            }

                        break;

                    }
                }
            }




            for (int i = 0; i < quebrados2.Length; i++)
            {
                if (quebrados2[i] != null)
                {
                    switch (quebrados2[i])
                    {
                        case 'M':
                            if (direcao2 == 'N')
                            {
                                if (roboy2 < maxy) roboy2++;
                            }

                            else if (direcao2 == 'S')
                            {
                                if (roboy2 > 0) roboy2--;
                            }

                            else if (direcao2 == 'O')
                            {
                                if (robox2 > 0) robox2--;
                            }

                            else if (direcao2 == 'L')
                            {
                                if (robox2 > maxx) robox2--;
                            }
                            break;



                        case 'E':
                            if (direcao2 == 'N')
                            {
                                direcao2 = 'O';
                            }

                            else if (direcao2 == 'O')
                            {
                                direcao2 = 'S';
                            }

                            else if (direcao2 == 'S')
                            {
                                direcao2 = 'L';
                            }

                            else if (direcao2 == 'L')
                            {
                                direcao2 = 'N';
                            }

                            break;



                        case 'S':
                            if (direcao2 == 'N')
                            {
                                direcao2 = 'L';
                            }

                            else if (direcao2 == 'L')
                            {
                                direcao2 = 'S';
                            }

                            else if (direcao2 == 'S')
                            {
                                direcao2 = 'O';
                            }

                            else if (direcao2 == 'O')
                            {
                                direcao2 = 'N';
                            }

                            break;

                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(roboy1 + " " + robox1 + " " + direcao1);

            Console.WriteLine();
            Console.WriteLine(roboy2 + " " + robox2 + " " + direcao2);

            Console.ReadLine();

        }
    }
}