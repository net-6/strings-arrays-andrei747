using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework2
{
    public class FirstArrays
    {
        //- Write a method to create an array of 5 integers and display the array items. 
        //Access individual elements and display them through indexes.

        public void Problem1()
        {
            int[] num = { 11, 22, 33, 44, 55 };
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(i);//display them through indexes
                Console.WriteLine(num[i]);//display the array items
            }
            
        }

        // Write a method to reverse the order of the items in the array
        public void Problem2()
        {
            int[] num = { 74, 75, 76, 77, 78 };
            int len = num.Length;//get array size       
            for(int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);//reverse order

            }

        }
        // Write a method to get the number of occurrences of a specified element in an array
        public void Problem3()
        {
            string[] s1 = { "Ioana", "Ionel", "Irina", "Ion", "Ioana", "Ioana" };
            int count = 0;
            foreach(string c in s1)
            {
                if (c == "Ioana")
                    count++;
                
            }
            Console.WriteLine(count);//number of occurrences

        }
        //Write a method to insert a new item before the second element in an existing array
        public void Problem4()
        {
             List<string> countries = new string [] { "France", "Portugal", "Germany" }.ToList();//use list to insert an item at a given position
            countries.Insert(1, "Romania");
            foreach(string c in countries)
            {
                Console.WriteLine(c);
            }
                              
        }
        // Write a method to remove a specified item using the index from an array. 
        public void Problem5()
        {
            List<string> towns = new string[] { "Porto", "Lisabona", "Braga", "Guimaraes" }.ToList();
            towns.RemoveAt(2);//remove Braga from the array
            foreach(string s in towns)
            {
                Console.WriteLine(s);
            }

        }
        //Write a program to find the sum of all elements of the array
        public void Problem6()
        {
            string[] towns = { "Vigo", "Sevilla", "Malaga", "Granada" };
            int sum = 0;
            for(int i = 0; i <= towns.Length; i++)
            {
                sum = sum + i;//add the sum to each element
                
            }
            Console.WriteLine(sum);
        }
        //Write a program to print all unique elements in an array.
        public void Problem7()
        {
            string[] s1 = { "Ioana", "Ionel", "Irina", "Ion", "Ioana", "Ioana" };
            IEnumerable<string> uniqueItems = s1.Distinct<string>();
            Console.WriteLine("Unique elements are: " + string.Join(",", uniqueItems));

        }
        //Write a program to merge two arrays of same size sorted in ascending order.
        public void Problem8()
        {
            string[] s1 = { "Romania", "Moldova", "Ukraine", "Bulgaria" };
            string[] s2 = { "Greece", "Turkey", "Hungary", "Serbia" };
            var arr = s1.Union(s2).ToArray();
            Array.Sort(arr);
            foreach(string c in arr)
            {
                Console.WriteLine(c);
            }
        }
        //Write a program to find maximum and minimum element in an array.
        public void Problem9()
        {
            int[] num = { 11, 5, 5, 21, 62, 7 };
            int max = num[0];
            int min = num[0];
            for(int i = 1; i < num.Length; i++)
            {
                if(num[i] > max)
                {
                    max = num[i];
                } 
                if(num[i] < min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine("The maximum element is: " + max);
            Console.WriteLine("The minimum element is: " + min);

        }
        //Write a program to separate odd and even integers in separate arrays
        public void Problem10()
        {

            int[] arr = { 12, 22, 13, 15, 8, 7 };
            int j = 0; int k = 0;//just like int i, we use with for loop
            int[] arr1 = new int[6];
            int[] arr2 = new int[6];//arr1 & arr2 the new arrays odd and even
            for (int i = 0; i < 6; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[j] = arr[i];//for even numbers
                    j++;
                }
                else 
                {
                    arr2[k] = arr[i];//for odd numbers
                    k++;

                }
            }
            Console.WriteLine("Even numbers are: ");
            for(int i = 0; i < j; i++)
            {
                Console.WriteLine(arr1[i]); 
            }
            Console.WriteLine("Odd numbers are: ");
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(arr2[i]);
            }


        }
        //Write a program to sort elements of array in ascending order.
        public void Problem11()
        {
            string[] s1 = { "Romania", "Moldova", "Ukraine", "Bulgaria" };
            Array.Sort(s1);
            foreach(string countries in s1)
            {
                Console.WriteLine(countries);
            }

        }
        //Write a program to sort elements of the array in descending order.
        public void Problem12()
        {
            int [] s1 = { 12, 1, 5, 64, 33 };
            Array.Sort(s1);
            for(int i = s1.Length -1; i >= 0; i--)
            {
                Console.WriteLine(s1[i]);
            }

        }
        //Write a program to find the second largest element in an array.
        public void Problem13()
        {
            int[] num = { 12, 52, 14, 33, 44 };
            int i; int first = num[0]; int second = num[0];
            for(i = 0; i < num.Length; i++)
            {
                if(num[i] > first)
                {                   
                    first = num[i];

                }else if(num[i] > second && num[i] != first)
                {
                    second = num[i];
                }

            }

            Console.WriteLine(second);
        }
        //Write a program to find the second smallest element in an array.
        public void Problem14()
        {
            int[] num = { 112, 52, 14, 33, 44 };
            int i; int first = num[0]; int second = num[0];
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] < first)
                {
                    first = num[i];

                }
                else if (num[i] < second && num[i] > first)
                {
                    second = num[i];
                }

            }
            Console.WriteLine(second);
        }
        //Write a program for a 2D array of size 3x3 and print the matrix.
        public void Problem15()
        {
            int i, j;
            int[,] arr = new int[3, 3];
            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.Write("[{0},{1}]",i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());//store the numbers in array or matrix
                }
            }
            Console.Write("\n The matrix is: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for(j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t",arr[i, j]);//{0} because is arr[] not i & j

                }
                Console.Write("\n\n");
            }

        }
        //Write a program in C# Sharp for addition of two Matrices of same size
        public void Problem16()
        {
            int i, j;
            int[,] arr = new int[2, 2];
            int i2, j2;
            int[,] arr2 = new int[2, 2];
            int[,] addition = new int[2, 2];
            //first matrix
            for(i = 0; i < 2; i++)
            {
                for(j = 0; j < 2; j++)
                {
                    Console.WriteLine("[{0},{1}]",i, j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(i = 0; i < 2; i++)
            {
                for(j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0}\t",arr[i, j]);
                }
            }
            //second matrix
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("[{0},{1}]", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0}\t",arr2[i, j]);
                }
            }
            //the addition
            for(i = 0; i < 2; i++)
            {
                for(j = 0; j <2; j++)
                {
                    addition[i,j] = arr[i, j] + arr2[i, j];
                }
                
            }
            Console.Write("\n the addition of matrix is: \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                {
                    Console.Write("{0} \t",addition[i, j]);
                }
                Console.Write("\n\n");
            }
           

        }





    }
}
