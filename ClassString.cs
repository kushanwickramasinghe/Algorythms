using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorythms
{
    public class ClassString
    {
        public void Number3(string mystring)
        {
            char[] characters = mystring.ToCharArray();

            for (int i = characters.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(characters[i]);
            }
        }

        public void Number5(string mystring)
        {
            string[] words = mystring.Split(' ');

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

        public void Number10(string mystring)
        {
            char[] characters = mystring.ToCharArray();
            char maxoccur=characters[0];
            int maxcount = 0;


            for (int i = 0; i < characters.Length-1; i++)
            {
                char character = characters[i];
                int count = 0;
                for (int j = 0; j < characters.Length; j++)
                {
                    if (characters[j] == character && i != j)
                        count++;
                }

                if(count>maxcount)
                {
                    maxcount = count;
                    maxoccur = character;
                }
                    
            }

            Console.WriteLine(maxoccur);
        }

        //sorting
        public void Number11(string mystring)
        {
            string str = mystring.Replace(" ", "");

            char orginalval;
            char newval;

            char[] characters = str.ToCharArray();

            //for (int i = 0; i < characters.Length-1; i++)
            //{
            //    for (int j = 0; j <= characters.Length-2; j++)
            //    {
            //        char temp = characters[j];
            //        if(characters[j]>characters[j+1])
            //        {
            //            characters[j] = characters[j + 1];
            //            characters[j + 1] = temp;
            //        }
            //    }
            //}

            int i = 0;

            while (i < characters.Length)
            {
                orginalval = characters[i];
                int pos=-1;
                for (int j = i; j < characters.Length; j++)
                {                              
                    if (orginalval>characters[j] && i!=j)
                    {
                        pos = j;
                    }
                }
                if (pos != -1)
                {
                    newval = characters[pos];
                    characters[pos] = orginalval;
                    characters[i] = newval;
                }
                else
                    i++;
            }

            Console.WriteLine(new string(characters));
        }

        public void Number19(string mystring,string searchstr)
        {
            var count = Regex.Matches(mystring, searchstr).Count;

            Console.WriteLine(count);
        }

        public void Number20(string mystring, string inputstr)
        {
            //this is a string
            var words = Regex.Split(mystring, inputstr);
            string output="";
            for (int i = 0; i < words.Length; i++)
            {
                if (i < words.Length - 1)
                    output = output + words[i] + "a test";

                else
                    output = output + words[i];
            }

            Console.WriteLine(output);
        }

        public void Number38()
        {
            string mystring = "birds";
            string sentence = "Kill two birds with one stone";

            if(sentence.Contains(mystring))
            {
               int Start = sentence.IndexOf(mystring);
             //  int End = sentence.IndexOf(mystring, Start);
            }
        }

        public void Number41(string[] myarray)
        {
            foreach (var item in myarray)
            {
                string last = item.Substring(item.Length-1, 1);

                if (last == ".")
                    Console.WriteLine(true);

                else
                    Console.WriteLine(false);
            }
        }

        public void Number45(string[] myarray)
        {
            foreach (var item in myarray)
            {
                string upperCase = item.ToUpper();
                char[] mystring = upperCase.ToCharArray();
                char[] finalString = new char[mystring.Length];

                int j = 0;
                for (int i = mystring.Length-1; i >= 0; i--)
                {
                    finalString[j] = mystring[i];
                    j++;
                }

                Console.WriteLine(new string(finalString));
            }
        }

        public void Number47(string[] myarray)
        {
            foreach (var item in myarray)
            {
                string upperCase = item.ToUpper();
                char[] mystring = upperCase.ToCharArray();
                char[] finalString = new char[mystring.Length];

                
               // int j = 0;
                for (int i =0 ; i <mystring.Length - 1; i++)
                {
                    char first = mystring[i];
                    for (int j = 0; j <  mystring.Length - 1; j++)
                    {
                        if(mystring[j]==first && i!=j)
                        {
                           
                        }
                    }
                    
                }

                Console.WriteLine(new string(finalString));
            }
        }
    }
}
