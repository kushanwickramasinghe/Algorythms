using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms
{
    public class ClassForLoop
    {
        public void Number13(int noofrows)
        {
            int display = 1;
            int x;

            for (int i = 1; i <= noofrows; i++)
            {
                x = noofrows - i;
                for (int j = 0; j < i; j++)
                {
                    int k = 0;
                    while (k < 7)
                    {
                        if (k == x)
                        {
                            Console.Write(display);
                            x = 1;
                            break;
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                        k++;

                    }

                    display++;

                }

                Console.Write("\n");
            }
            Console.Read();
        }

        public void Number20()
        {
            int noofaztrix = 1;
            int x;

            for (int i = 1; i <= 3; i++)
            {
                x = 3 - i;

                for (int j = 0; j < 4; j++)
                {
                    if (x == j)
                    {
                        for (int k = 0; k < noofaztrix; k++)
                        {
                            Console.Write("*");
                        }

                        noofaztrix += 2;

                        break;
                    }

                    else
                        Console.Write(" ");
                }

                Console.Write("\n");
            }
            Console.Read();
        }

        public void Number22()
        {
            bool check = false;
            bool isone = false;

            for (int i = 1; i <= 5; i++)
            {
                isone = check;
                for (int j = 0; j < i; j++)
                {
                    if (isone)
                    {
                        Console.Write("0");
                    }

                    else
                        Console.Write("1");

                    isone = !isone;
                }
                check = !check;
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }

        public void Number25()
        {
            int increment = 3;
            int number = 1;
            int sum = 0;

            int[] myarray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                myarray[i] = number;
                number += increment;
                increment += 2;
            }

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.Write(myarray[i] + " ");
                sum += myarray[i];
            }
            Console.WriteLine("\n");
            Console.WriteLine(sum);
            Console.Read();
        }

        public void Number31()
        {
            int noofrows = 8;
            int noofaztrix = 1;
            int x;

            for (int i = 1; i <= noofrows; i++)
            {
                x = noofrows - i;

                for (int j = 0; j <= noofrows; j++)
                {
                    if (x == j)
                    {
                        for (int k = 0; k < noofaztrix; k++)
                        {
                            Console.Write("*");
                        }

                        noofaztrix += 2;

                        break;
                    }

                    else
                        Console.Write(" ");
                }

                Console.Write("\n");
            }

            noofaztrix = noofaztrix - 4;
            for (int i = noofrows - 1; i >= 1; i--)
            {
                x = noofrows - i;

                for (int j = 0; j <= noofrows; j++)
                {
                    if (x == j)
                    {
                        for (int k = 0; k < noofaztrix; k++)
                        {
                            Console.Write("*");
                        }

                        noofaztrix -= 2;

                        break;
                    }

                    else
                        Console.Write(" ");
                }

                Console.Write("\n");
            }
            Console.Read();
        }

        public void Number36()
        {
            int noofrows = 5;
            int noofaztrix = 1;
            int b = 1;
            int x;

            for (int i = 1; i <= noofrows; i++)
            {
                x = noofrows - i;


                for (int j = 0; j <= noofrows; j++)
                {
                    if (x == j)
                    {
                        if (noofaztrix == 1)
                        {
                            for (int k = 0; k < noofaztrix; k++)
                            {
                                Console.Write(1);
                            }

                            noofaztrix += 2;

                            break;
                        }

                        else
                        {
                            int a = 0;

                            for (int p = 0; p < noofaztrix - b; p++)
                            {
                                a++;
                                Console.Write(a);
                            }

                            if (noofaztrix != b)
                                b++;

                            for (int q = 0; q < noofaztrix - b; q++)
                            {
                                a--;
                                Console.Write(a);
                            }


                            noofaztrix += 2;

                            break;
                        }

                    }

                    else
                        Console.Write(" ");
                }

                Console.Write("\n");
            }

            Console.Read();
        }

        public void Number40()
        {
            int noofrows = 5;
            int noofchar = 1;
            int b = 1;

            for (int i = 0; i < noofrows; i++)
            {
                char ch = 'A';

                if (noofchar == 1)
                {
                    Console.Write(ch);

                }

                else
                {
                    for (int p = 0; p < noofchar - b; p++)
                    {
                        Console.Write(ch);
                        ch++;
                    }

                    ch--;
                    if (noofchar != b)
                        b++;

                    for (int q = 0; q < noofchar - b; q++)
                    {
                        ch--;
                        Console.Write(ch);
                    }
                }
                noofchar += 2;


                Console.Write("\n");
            }

            Console.Read();

        }
    }
}
