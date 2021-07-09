using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms
{
    public class ClassArray
    {
        public int Number5(int[] myarray)
        {
            int number;
            int repeatingcount=0;
            int count = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                number = myarray[i];
                repeatingcount = 0;

                for (int j = i+1; j < myarray.Length; j++)
                {
                    if (myarray[j] == number)
                    {
                        repeatingcount++;
                    }                      
                }

                if (repeatingcount == 0)
                    count++;
            }

            return count;
        }

        public int Number6(int[] myarray)
        {
            int number;
            int repeatingcount = 0;
            int count = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                number = myarray[i];
                repeatingcount = 0;

                for (int j = 0; j < myarray.Length; j++)
                {
                    if (myarray[j] == number && i!=j)
                    {
                        repeatingcount++;
                    }
                }

                if (repeatingcount == 0)
                    count++;
            }

            return count;
        }

        public void Number9(int[]myarray)
        {
            int min;
            int max;
          
                min = myarray[0];
                for (int j = 0; j < myarray.Length; j++)
                {
                    if (myarray[j] < min)
                        min = myarray[j];
                }

            max = myarray[0];
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] > max)
                    max = myarray[i];
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            
        }

        //sorting
        public void Number11(int[] myarray)
        {
            int pos=0;
            int orginalval;
            int newval;

            for (int i = 0; i < myarray.Length; i++)
            {
                orginalval = myarray[i];
                newval = myarray[i];
                pos = -1;
                for (int j = i; j < myarray.Length; j++)
                {
                    
                    if (newval > myarray[j] && i!=j)
                    {
                        pos = j;
                        newval = myarray[j];                    
                    }

                }

                if(pos!=-1)
                {
                    myarray[i] = newval;
                    myarray[pos] = orginalval;
                }
               
            }

            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }

        }

        public void Number12(int[] myarray)
        {
            int pos = 0;
            int orginalval;
            int newval;

            for (int i = 0; i < myarray.Length; i++)
            {
                orginalval = myarray[i];
                newval = myarray[i];
                pos = -1;
                for (int j = i; j < myarray.Length; j++)
                {

                    if (newval < myarray[j] && i != j)
                    {
                        pos = j;
                        newval = myarray[j];
                    }

                }

                if (pos != -1)
                {
                    myarray[i] = newval;
                    myarray[pos] = orginalval;
                }

            }

            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }
        }

        public void Number13(int[] myarray, int number)
        {
            int[] newarray = new int[myarray.Length + 1];
            int j = -1;
            int i = 0;
            int pos=0;
            
            while(j<myarray.Length)
            {
                if(myarray[i]>number)
                {
                    pos = i;
                    j=i+1;
                }
                else
                {
                    j++;
                }
                newarray[j] = myarray[i];
                i++;
            }

            newarray[pos] = number;
        }

        public void Number16(int[] myarray)
        {
            int pos = 0;
            int orginalval;
            int newval=0;

            for (int i = 0; i < 2; i++)
            {
                orginalval = myarray[i];
                newval = myarray[i];
                pos = -1;
                for (int j = i; j < myarray.Length; j++)
                {

                    if (newval < myarray[j] && i != j)
                    {
                        pos = j;
                        newval = myarray[j];
                    }

                }

                if (pos != -1)
                {
                    myarray[i] = newval;
                    myarray[pos] = orginalval;
                }

            }

            Console.WriteLine(newval);
        }

        public void Number18()
        {
            int[,] firstarray = new int[2,2];
            int[,] secondarray = new int[2, 2];
            int number = 1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    firstarray[i, j] = number;
                    number++;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    secondarray[i, j] = number;
                    number++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int sum=firstarray[i, j] - secondarray[i, j];
                    Console.WriteLine(sum);
                }

                Console.WriteLine("\n");
            }
        }

        public void Number22()
        {
            int[,] firstarray = new int[2, 2];
            int[,] secondarray = new int[2, 2];
            int number = 1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    firstarray[i, j] = number;
                    number++;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    secondarray[j, i] = firstarray[i,j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(secondarray[i,j]);
                }

                Console.WriteLine("\n");
            }

        }

        public void Number35(int[] myarray)
        {
            int pos = 0;
            int sum = 0;
            int orginalval;
            int newval = 0;

            for (int i = 0; i < 2; i++)
            {
                orginalval = myarray[i];
                newval = myarray[i];
                pos = -1;
                for (int j = i; j < myarray.Length; j++)
                {

                    if (newval > myarray[j] && i != j)
                    {
                        pos = j;
                        newval = myarray[j];
                    }

                }

                if (pos != -1)
                {
                    myarray[i] = newval;
                    sum = sum + newval;
                    myarray[pos] = orginalval;
                }

            }

            Console.WriteLine(sum);
        }

        public void Number36(int[] myarray)
        {
            int firstnumber = myarray[0];

            for (int i = 0; i <= myarray.Length; i++)
            {
                if (myarray[i] != firstnumber)
                    break;

                firstnumber += 1;
            }

            Console.WriteLine(firstnumber);
        }
    }
}
