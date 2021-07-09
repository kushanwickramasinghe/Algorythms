using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms
{
    public class Operations
    {
        public int NumberOne(int a, int b)
        {
            if(a==b)
            {
                return (a + b) * 3;
            }
            else
            {
                return a + b;
            }
        }

        public int NumberTwo(int a)
        {
            return a > 51 ? (a - 51) * 3 : 51-a;
        }

        public bool NumberThree(int a,int b)
        {
            if ((a == 30) || (b ==30)||(a+b==30))
            {
                return true;
            }

            else
                return false;
        }

        public string NumberFive(string sentence)
        {
            string first = "if";

            string sentencewithoutspace = sentence.Trim();

            string firstword = sentencewithoutspace.Substring(0, 3).Trim();

            if (string.Equals(first, firstword))
            {
                return sentence;
            }
                
            else
            {
                return first + " " + sentence;
            }

        }

        public string NumberSix(string word,int index)
        {
            return word.Remove(index, 1);
        }

        public string NumberSeven(string word)
        {
            string wordwithtrim = word.Trim();

            string firstchar = wordwithtrim.Substring(0, 1);
            string lastchar = wordwithtrim.Substring(wordwithtrim.Length - 1, 1);

            if (wordwithtrim.Length==1)
            {
                return word;
            }

            else if(wordwithtrim.Length==2)
            {
                return lastchar + firstchar;
            }
            
            else
            {
                return lastchar + wordwithtrim.Substring(1, wordwithtrim.Length - 2) + firstchar;
            }
            
        }

        public string NumberEight(string word)
        {
            if(word.Length==1)
            {
                return word;
            }

            else
            {
                string firsttwochars = word.Substring(0, 2);
                return firsttwochars+firsttwochars+firsttwochars+firsttwochars;
            }
        }

        public string NumberNine(string word)
        {
            if (word.Length == 1)
               return word + word + word;
            else
            {
                string lastchar = word.Substring(word.Length - 1, 1);
                return lastchar + word + lastchar;
            }
        }

       
        public bool NumberTen(int number)
        {
            decimal a = (decimal)number / 3;
            decimal b = (decimal)number / 7;

            decimal c = a % 1 ;
            decimal d = b % 1 ;
          //  decimal b = a % 1;
            if (a % 1== 0 || b % 1 == 0)
                return true;
            else
                return false;
        }

        public int Number18(int number1,int number2,int number3)
        {
            int largest=number1;

            if (largest < number2)
                largest = number2;
            
            if (largest < number3)
                largest = number3;

            return largest;
        }

        public bool Number22(string word)
        {
            char[] characters = word.ToUpper().ToCharArray();
            int numberofZ=0;

            foreach (var item in characters)
            {
                if (item == 'Z')
                    numberofZ++;
            }

            if (numberofZ >= 2 && numberofZ <= 4)
                return true;

            else
                return false;
        }

        public string Number25(string word,int numer)
        {
            string finalword=word;

            for (int i = 1; i < numer; i++)
            {
                finalword = finalword + word;
            }

            return finalword;
        }

        public int Number27(string word)
        {
            char[] characters = word.ToCharArray();
            int aa = 0;
            for (int i = 0; i < characters.Length; i++)
            {
                if(i<characters.Length-1)
                {
                    char[] c = new char[2];
                    c[0]= characters[i];
                    c[1] = characters[i+1];
                    string a = new string(c);
                    if (a == "aa")
                        aa++;
                }
            }

            return aa;
        }

        public string Number29(string word)
        {
            char[] characters = word.ToCharArray();

            char[] c = new char[word.Length];

            for (int i = 0; i < characters.Length; i+=2)
            {
                c[i] = characters[i];
            }

            string output = new string(c);

            return output;
        }

        public string Number30(string word)
        {
           // string first = word.Substring(0, 1);
            string final="";

            for (int i = 1; i <= word.Length; i++)
            {
                final = final + (word.Substring(0, i));
            }

            return final;
        }

        public bool number34(int[] numbers)
        {
            int count = 0;
            bool result = false;
            for (int i = 0; i < numbers.Length-2; i++)
            {
                count = 0;
                int[] inneraray = new int[3];
                inneraray[0] = numbers[i];
                inneraray[1] = numbers[i + 1];
                inneraray[2] = numbers[i+2];

                for (int j = 0; j < 3; j++)
                {
                    if (inneraray[j] != j+1)
                        break;

                    else
                        count++;                  
                }

                if (count == 3)
                {
                    result = true;
                    break;
                }
                    
            }

            return result;
        }

        public void Number35(string first,string second)
        {
            int count = 0;
            string[] one = new string[first.Length - 1];
            string[] two = new string[second.Length - 1];

            for (int i = 0; i < first.Length-1; i++)
            {
                one[i] = first.Substring(i, 2);
            }

            for (int i = 0; i < second.Length-1; i++)
            {
                two[i] = second.Substring(i, 2);
            }

            for (int i = 0; i < two.Length; i++)
            {
                for (int J = 0; J < one.Length; J++)
                {
                    if (two[i] == one[J])
                        count++;
                }
            }

            Console.WriteLine(count);
            
        }

        public string Number37(string word)
        {
            char[] wordtochar = word.ToCharArray();
            char[] temp = new char[word.Length];

            int j = 0;
            for (int i = 0; i < word.Length-1; i+=4)
            {
                temp[j] = wordtochar[i];
                temp[j + 1] = wordtochar[i + 1];
                j += 2;               
            }

            string final = new string(temp);

            return final;
        }

        //check number of digits
        public int Number54(int x,int y)
        {
            double digitX = Math.Floor(Math.Log10(x) + 1); ;
            double digitSum= Math.Floor(Math.Log10(x+y) + 1); ;

            if (digitSum > digitX)
                return x;
            else
                return x + y;
        }

        public int Number57(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] >= 10 && numbers[i] <= 20) && (numbers[i] != 13 && numbers[i] != 17))
                    sum+=0;

                else
                    sum += numbers[i];
            }

            return sum;
        }

        public string Number77(string first, string second)
        {
            string firstchar = "#";
            string secondchar = "#";

            if (first.Length > 0)
                firstchar = first.Substring(0, 1);

            if (second.Length > 0)
                secondchar = second.Substring(second.Length - 1, 1);

            return firstchar + secondchar;
        }

        public bool Number81(string word)
        {
            string first = word.Substring(0,2);
            string second = word.Substring(word.Length-2,2);

            if (first == second)
                return true;

            else
                return false;
        }

        public string Number85(string word)
        {
            string firstchar = word.Substring(0,1);
            string secondchar = word.Substring(1, 1);

            string final = word.Substring(2, word.Length - 2);

            if (secondchar == "y")
                final = secondchar + final;

            if (firstchar == "p")
                final = firstchar + final;

            return final;
        }

        public int[] Number92(int[] myarray)
        {
            int[] newarray = new int[myarray.Length];
            int j = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                j = i+1;

                if (j == myarray.Length)
                    newarray[i] = myarray[0];

                else
                    newarray[i] = myarray[j];
            }

            return newarray;
        }

        public int[] Number93(int[] myarray)
        {
            int[] newarray = new int[myarray.Length];
            int j = 0;

            for (int i = myarray.Length-1; i >= 0; i--)
            {
                newarray[j] = myarray[i];
                j++;
            }

            return newarray;
        }

        public int[] Number94(int[] myarray)
        {
            int maxvalue=myarray[0];
            int[] newarray = new int[myarray.Length];
            for (int i = 1; i < myarray.Length; i++)
            {
                if (maxvalue<myarray[i])
                    maxvalue = myarray[i];
            }

            for (int i = 0; i < myarray.Length; i++)
            {
                newarray[i] = maxvalue;
            }

            return newarray;
        }

        public int Number110(int[] myarray)
        {
            int minval = myarray[0];
            int maxval = myarray[0]
                ;
            for (int i = 1; i < myarray.Length; i++)
            {
                if (maxval < myarray[i])
                    maxval = myarray[i];

                if (minval > myarray[i])
                    minval = myarray[i];
            }

            return (maxval - minval);
        }

        public int Number112(int[] myarray)
        {
            int sum = 0;
            int i = 0;
            while(i<myarray.Length)
            {
                if ((i + 1) < myarray.Length)
                {
                    if (myarray[i] == 5 && myarray[i + 1] == 6)
                    {
                        i += 2;
                        continue;
                    }

                    else
                    {
                        sum = sum + myarray[i];
                        i++;
                    }                  
                }
                if(i==myarray.Length-1)
                {
                    sum = sum + myarray[i];
                    i++;
                }
            }

            return sum;
        }

        public bool Number123(int[] myarray)
        {
            int[] newarray = new int[myarray.Length];
            int count = 0;
            bool result=false;

            for (int i = 0; i < myarray.Length; i++)
            {
                if(myarray[i]==5)
                {
                    newarray[i] = myarray[i];
                    count++;
                }
                
            }

            if(count==5)
            {
                for (int i = 0; i < newarray.Length; i++)
                {
                    if ((i + 1) != newarray.Length)
                    {
                        if (newarray[i] == newarray[i + 1])
                        {
                            result = false;
                            break;
                        }
                        else
                            result = true;
                    }
                    
                }
            }

            return result;
        }

        public bool Number126(int[] myarray)
        {
            bool result=false;
            int i = 0;

            while (i < myarray.Length-2)
            {
                if((i+2)<=myarray.Length-1)
                {
                    int firstval = myarray[i];
                    int secondval = myarray[i+1];
                    int thirdval = myarray[i + 2];

                    if (secondval - firstval == 1 && thirdval - secondval == 1)
                    {
                        result = true;
                        break;
                    }
                    if (thirdval - secondval != 1)
                    {
                        i += 3;
                    }
                    else
                        i++;
                }               
            }

            return result;
        }

        public int[] Number130(int[] myarray)
        {
            int[] newarray = new int[myarray.Length];
            int count = 0;
            int j = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] == 5)
                {
                    count++;
                    continue;
                }
                else
                {
                    newarray[j] = myarray[i];
                    j++;
                }
            }

            for (int i = j; i < newarray.Length; i++)
            {
                newarray[i] = 0;
            }

            return newarray;
        }

        public bool Number139(int number)
        {
            bool result = false;
            string numstr = number.ToString();
            int[] numarray = new int[numstr.Length];

            for (int i = 0; i < numstr.Length; i++)
            {
                numarray[i] = int.Parse(numstr[i].ToString());
            }

            for (int i = 0; i < numarray.Length; i++)
            {
                if (numarray[i] == 2)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }

        public int[] Number146(int[] inputarray)
        {
            string[] inputarraystr = new string[inputarray.Length];
            int[] outputarray = new int[inputarray.Length];

            for (int i = 0; i < inputarraystr.Length; i++)
            {
                inputarraystr[i] = inputarray[i].ToString();
            }

            for (int i = 0; i < inputarraystr.Length; i++)
            {
                foreach (var item in inputarraystr[i])
                {
                    outputarray[i] = int.Parse(item.ToString());
                }
            }

            return outputarray;
        }

        public string[] Number148(string[] inputarray)
        {
            string[] outputarray = new string[inputarray.Length];

            for (int i = 0; i < inputarray.Length; i++)
            {
                char[] outchar = new char[inputarray[i].Length];

                int k = 0;
                foreach (var item in inputarray[i])
                {
                    if (item == 'a')
                    {
                        continue;
                    }

                    else
                    {
                        outchar[k] = item;
                        k++;
                    }
                }

                outputarray[i] = new string(outchar);
            }

            return outputarray;
        }

        public int[] Number150(int[] inputarray)
        {

            int[] outputarray = new int[inputarray.Length];
            int j = 0;

            for (int i = 0; i < inputarray.Length; i++)
            {
                string mystring = inputarray[i].ToString();
                bool isinclude=false;

                foreach (var item in mystring)
                {
                    if (item == '7')
                    {
                        isinclude = true;
                        break;
                    }
                }

                if (!isinclude)
                {
                    outputarray[j] = inputarray[i];
                    j++;
                }
            }

            return outputarray;
        }
    }
}
