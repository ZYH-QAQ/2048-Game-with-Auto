using System;

namespace g2048
{
    class Program
    {
        static void Main(string[] args)
        {
            bool judge2 = true;
            int[] pos = new int[16];
            bool judge3 = true;
            while (judge3)
            {
                Console.Clear();
                //add randomly a number first
                Random r = new Random();
                int rNumber = r.Next(0, 16);
                while (pos[rNumber] != 0)
                {
                    rNumber = r.Next(0, 16);
                }
                if (judge2)
                {
                    pos[rNumber] = 1;
                }
                else
                {
                    judge2 = true;
                }

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(pos[4 * i + j] + "  ");
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine();
                    }
                }
                string input = Console.ReadLine();
                bool[] judge = new bool[16];
                for (int i = 0; i < 16; i++)
                {
                    judge[i] = true;
                }
                switch (input)
                {
                    case "w":
                        for (int k = 0; k < 3; k++)
                        {
                            for (int j = 1; j < 4; j++)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (pos[4 * j + i] == pos[i + 4 * j - 4] && pos[4 * j + i] != 0 && judge[i + 4 * j - 4] && judge[i + 4 * j])
                                    {
                                        pos[i + 4 * j - 4] = 2 * pos[i + 4 * j - 4];
                                        pos[4 * j + i] = 0;
                                        judge[i + 4 * j - 4] = false;
                                    }
                                    if (pos[4 * j + i - 4] == 0)
                                    {
                                        pos[i + 4 * j - 4] = pos[i + 4 * j];
                                        pos[4 * j + i] = 0;
                                    }

                                }

                            }

                        }
                        break;
                    case "s":
                        for (int k = 0; k < 3; k++)
                        {
                            for (int j = 3; j > 0; j--)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (pos[4 * j + i] == pos[i + 4 * j - 4] && pos[4 * j + i] != 0 && judge[i + 4 * j] && judge[i + 4 * j - 4])
                                    {
                                        pos[i + 4 * j] = 2 * pos[i + 4 * j - 4];
                                        pos[4 * j + i - 4] = 0;
                                        judge[i + 4 * j] = false;
                                    }
                                    if (pos[4 * j + i] == 0)
                                    {
                                        pos[i + 4 * j] = pos[i + 4 * j - 4];
                                        pos[4 * j + i - 4] = 0;
                                    }

                                }

                            }

                        }
                        break;
                    case "a":
                        for (int k = 0; k < 3; k++)
                        {
                            for (int j = 1; j < 4; j++)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (pos[4 * i + j - 1] == pos[j + 4 * i] && pos[4 * i + j] != 0 && judge[j + 4 * i - 1] && judge[j + 4 * i])
                                    {
                                        pos[j + 4 * i - 1] = 2 * pos[j + 4 * i];
                                        pos[4 * i + j] = 0;
                                        judge[i + 4 * j - 1] = false;
                                    }
                                    if (pos[4 * i + j - 1] == 0)
                                    {
                                        pos[j + 4 * i - 1] = pos[j + 4 * i];
                                        pos[4 * i + j] = 0;
                                    }

                                }

                            }

                        }
                        break;
                    case "d":
                        for (int k = 0; k < 3; k++)
                        {
                            for (int j = 3; j > 0; j--)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (pos[4 * i + j - 1] == pos[j + 4 * i] && pos[4 * i + j] != 0 && judge[j + 4 * i] && judge[j + 4 * i - 1])
                                    {
                                        pos[j + 4 * i] = 2 * pos[j + 4 * i];
                                        pos[4 * i + j - 1] = 0;
                                        judge[j + 4 * i] = false;
                                    }
                                    if (pos[4 * i + j] == 0)
                                    {
                                        pos[j + 4 * i] = pos[j + 4 * i - 1];
                                        pos[4 * i + j - 1] = 0;
                                    }

                                }

                            }

                        }
                        break;
                    default:
                        Console.WriteLine("You have put in an undefined letter,please try again.");
                        Console.WriteLine("press any key to continue.");
                        judge2 = false;
                        Console.ReadKey();
                        break;
                }

                for (int i = 0; i < 16; i++)
                {
                    if (pos[i] == 0)
                    {
                        judge3 = true;
                        break;
                    }
                    else
                    {
                        judge3 = false;
                    }
                }

            }
            Console.WriteLine("ends");
        }
    }
}

