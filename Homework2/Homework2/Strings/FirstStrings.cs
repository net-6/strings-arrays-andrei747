using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Security;

namespace Homework2.Strings
{
    public class FirstStrings
    {
        //Write a method that to remove the nth index character from a nonempty string.
        public void Problem1()
         {
             string s1 = "string and arrays";
             Console.WriteLine("first " + s1.Remove(7, 10));
         }
         //Write a method that to remove the characters which have odd index values of a given string. 
         public void Problem2()
         {
             string s1 = "strings";
             string s2 = s1.Remove(1, 1);//srings
             string s3 = s2.Remove(2, 1);//srngs
             string s4 = s3.Remove(3, 1);//srns           
             Console.WriteLine(s4);
         }
         // Write a method that takes input from the user and displays that input back in upper and lower cases. 
         public void Problem3()
         {
             Console.WriteLine("Type something");
             string s1 = Console.ReadLine();
             string s2 = s1.ToUpper();
             string s3 = s1.ToLower();
             Console.WriteLine(s2);
             Console.WriteLine(s3);
         }
         //Write a method that reverses a string if it's length is a multiple of 4
         public void Problem4()
         {
             Console.WriteLine("Write something");
             string s1 = Console.ReadLine();
             StringBuilder sb = new StringBuilder();
             for(int i = s1.Length - 1; i >= 0; i--)
             {
                 if(s1.Length % 4 == 0)
                 sb.Append(s1[i]);
             }
             Console.WriteLine(sb.ToString());

         }
         //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
         public void Problem5()
         {
             Console.WriteLine("Type your text");
             string s1 = Console.ReadLine();                     
             if(s1.Length <= 4)
             {
                 Console.WriteLine(s1.ToUpper());///in progress
             }
             else
             {
                 Console.WriteLine(s1);
             }

         }
         // Write a method that to remove a newline.
         public void Problem6()
         {
             Console.WriteLine("Remove a newline");
             string s1 = Console.ReadLine(); 
             Console.WriteLine("Remove line: " + s1.Replace("/n", String.Empty));

         }
         /*Write a method to display formatted text (width=50) as output. For example: 
        If I have a text that's 134 characters long, the formatted string should have maximum
            of 50 characters per line. In this case we will have 3 lines of text.*/

        public void Problem7()
        {
            Console.WriteLine("Write something");
            string s1 = Console.ReadLine();                     
            Console.WriteLine(s1); ///in progress


        }
        // Write a method that formats a number with a percentage
        public void Problem8()
        {
            Console.WriteLine("Type a number");            
            int myInt = int.Parse(Console.ReadLine());
            Console.WriteLine(myInt.ToString("P"));
           
        }
        //Write a method that reverses a string.
        public void Problem9()
        {
            Console.WriteLine("Write something");
            string s1 = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = s1.Length - 1; i >= 0; i--)
            {                
                    sb.Append(s1[i]);
            }
            Console.WriteLine(sb.ToString());
        }
        //Write a method that strips a set of characters from a string. 
        public void Problem10()
        {
            
            static string RemoveCharactersFromString(string testString, string removeChars)
            {
                char[] charAry = removeChars.ToCharArray();
                string returnString = testString;
                foreach (char c in charAry)
                {
                    while (returnString.IndexOf(c) > -1)
                    {
                        returnString = returnString.Remove(returnString.IndexOf(c), 1);
                    }
                }
                return returnString;
            }
            string testString = "She was a soul stripper. She took my heart!";
            string removeChars = "aei";
            Console.WriteLine(RemoveCharactersFromString(testString, removeChars));

        }
        //Write a method that transforms to lowercase first n characters in a string
        public void Problem11()
        {
            Console.WriteLine("Type");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1.ToLower());


        }
       // Write a method to capitalize first and last letters of each word of a given string.
        public void Problem12()
        {
            Console.WriteLine("Type something");
            string s1 = Console.ReadLine();
            char[] ch = s1.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                int k = i;//k is the first index & i is the last
                while (i < ch.Length && ch[i] != ' ')
                    i++;
                ch[k] = (char)(ch[k] >= 'a' && ch[k] <= 'z'
                             ? ((int)ch[k] - 32)
                             : (int)ch[k]);
                ch[i - 1] = (char)(ch[i - 1] >= 'a' && ch[i - 1] <= 'z'
                                    ? ((int)ch[i - 1] - 32)
                                    : (int)ch[i - 1]);
            }
            Console.WriteLine(ch); 

        }
        //Write a method to compute sum of digits of a given string(if any).
        public void Problem13()
        {
            Console.WriteLine("write something");
            string s1 = Console.ReadLine();           
            for(int i = 0; i < s1.Length; i++)
            {
                int sum = 0;
                sum = s1.Length + i;
                Console.WriteLine(sum);

            }

        }
        /* Clean the text
        You will get a text from where you will need to clean the text because it contains a lot of strange
        characters that don’t belong there( ^ <, > &+ @%$)```
        Input:
           Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks.@Hate ^me^ %now% and %thank% me &later.
        Output:
          Hi there I’m telling you, you need to do your homeworks.Hate me now and thank me later.*/
        public void Problem14()
        {
            string s1 = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks.@Hate ^me^ %now% and %thank% me &later.";
            string[] s2 = s1.Split('^', '>','<','%', '&', '$', '@' , '+');
            foreach(string s3 in s2)
            {
                Console.Write(s3);
            }

        }
        /*## Ing, ly
         Write a method to add 'ing' at the end of a given string (length should be at least 3). 
         If the given string already ends with 'ing' then add 'ly' instead. If the string length of 
         the given string is less than 3, leave it unchanged.
              ```
            Input : 'abc'
            Output : 'abcing' 
            Input : 'string'
            Output: 'stringly'*/
        public void Problem15()
        {
            string s1 = Console.ReadLine();

            if (s1.Length < 3)
            {
                Console.WriteLine(s1);
            }
            else if (s1.Length >= 3)
            {
                string s2 = s1 + "ing";
                Console.WriteLine(s2);
            }

            if (s1.Contains("ing"))
            {
                Console.WriteLine(s1 + "ly");
            }
        }
        /*## Obfucate Email
        You have some text that contains your email address.And you want to hide that.You decide to censor
         your email: to replace all characters in it with asterisks ('*') except the domain.
          Assume your email address will always be in format[username]@[domain]. You need to replace the
          username with asterisks of equal number of letters and keep the domain unchanged.
          You will get as input the email address you need to obfuscate
 
               ```
             Input: awesome @dotnet.com
             Output: *******@dotnet.com*/
        public void Problem16()
        {
            Console.WriteLine("Type email");
            string s1 = Console.ReadLine();          
            string stars = "";
            for (int i = 0; i < s1.Length; i++) 
                stars += "*";
            {                
                if (s1.Contains("@"))
                {                   
                    s1.Replace("*", "");
                    Console.WriteLine(stars + s1);///in progress
                }
            }                                       

        }
        /*## Re-string
        Write a method to get a string made of the first 2 and the last 2 chars from a given a string.
            If the string length is less than 2, return instead of the empty string. 
              ```
                  Sample String : “w3resource”
                     Expected Result :”'w3ce”
                      Sample String :”w3”
                   Expected Result : “w3w3”
                   Sample String : “w”
                Expected Result : Empty String*/
        public void Problem17()
        {
            Console.WriteLine("type something");
            string s1 = Console.ReadLine();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Length < 2)
                {
                    Console.WriteLine(String.IsNullOrEmpty(s1));
                }
                else if (s1.Length > 2)
                {
                    string s3 = s1.Substring(0, 2);
                    string s4 = s1.LastIndexOf(i);
                    Console.WriteLine(s3 + s4);//in progress


                }
            }

        }
        /*## Replace Char
        Write a method to get a string from a given string where all occurrences of its 
            first char have been changed to '$', except the first char itself.
            ```
          Sample String : 'restart'
           Expected Result : 'resta$t'*/

        public void Problem18()
        {
            Console.WriteLine("Write");
            string s1 = Console.ReadLine();
            char[] ch = s1.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                int index = 0;
                index = i;// in progress

            }
        }
        /*- Write a method to get a single string from two given strings, 
        separated by a space and swap the first two characters of each string.
            ```
          Input: 'abc', 'xyz' 
            Output: 'xyc abz'*/
        public void Problem19()
        {
            Console.WriteLine("Write word 'one'");
            string s1 = Console.ReadLine();
            Console.WriteLine("Write word 'two'");
            string s2 = Console.ReadLine();
            Console.WriteLine(s2 + " " + s1);
        }
        /* Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, 
        if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. 
            Return the resulting string.
               ```
              Input: 'The lyrics is not that poor!'
             Output : 'The lyrics is poor!'
              Input  : 'The lyrics is good!'
              Output : 'The lyrics is poor!'*/
        public void Problem20()
        {
            Console.WriteLine("Type");
            string s1 = Console.ReadLine();           
            Console.WriteLine(s1.Replace("poor", "good"),s1.Replace("not","good"));//in progress                                               
        }
        /*## Longest word
        Write a method that takes a list of words and returns the length of the longest one.*/
        public void Problem21()
        {
            Console.WriteLine("Longest word");
            string s1 = "one, two, three, fifthyfive";
            int n = s1.Length;
            int res = 0; int currentLength = 0;
            for(int i = 0; i < n; i++)
            {
                if (s1[i] != ' ')
                    currentLength++;
                else
                {
                    res = Math.Max(res, currentLength);
                    currentLength = 0;
                }
                Console.WriteLine(Math.Max(res, currentLength));
            }
            Console.WriteLine(s1);

        }
        /*## Last Part
        Write a method to get the last part of a string before a specified character.
                 ```
               Input :  https://www.siit.com/net-exercises
              -
            Output:  https://www.siit.com/net */
        
        public void Problem22()
        {
            Console.WriteLine("Last part");
            string s1 = Console.ReadLine();
            string [] s2 = s1.Split('-');
            foreach(string s3 in s2)
            {
                Console.WriteLine(s3.Remove(7,4));//in progress
            }
        }
        /*- Write a method to check whether a string starts with specified characters
                   ```
                      input: awesome string
                              a
                  output : Yes, starts with a*/
         
        public void Problem23()
        {
            string s1 = Console.ReadLine();
            char ch = s1[0];           
            Console.WriteLine("Yes, starts with " + ch);           
        }

        /*-  Write a method to count occurrences of a substring in a string
                 ```
                   input: alabala portocala
                         ala
                    output : 3*/
        public void Problem24()
        {
            string s1 = Console.ReadLine();          
            string s2 = "ala";           
            Console.WriteLine(s2);//in progress              
        }
        /*- Write a method to swap comma and dot in a string. 
                 ```
                   Input: "32.054,23"
                 Output: "32,054.23"*/
        public void Problem25()
        {
            int [] num1 = {32.054,23}; //in progress
                       
        }
        //- Write a method to remove spaces from a given string.
        public void Problem26()
        {
            string s1 = Console.ReadLine();
            string s2 = s1.Trim();
            Console.WriteLine(s2);

        }

         /*## Palindrome
         Check if a string is palindrome(same value read from left to right and right to left)
         Ex: alabala -> True*/

        public void Problem27()
        {
            string s1 = Console.ReadLine();//in progresss

        }
        ///ARAYS IN PROGRES!!!!!!!!!!!!!!!

    }
        

}
