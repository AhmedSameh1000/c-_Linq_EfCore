using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 4, 5, 9, 7, 6, 3, 21, 8, 4, 5, 6, 3, 21, 5, 8, 8, 85, 2, 4, 3 };
            arr.Get_max();
            4598.Get_Digits();
            356.Reverse();
            "Hello!@#$%^&*()+".Remove_spicial_character();      
            

            //89453
        }
    }
    static class Ahmed
    {
        public  static void Reverse(this int num)
        {
                int reversedNumber = 0;
                while (num > 0)
                {
                    int current = num % 10;
                    reversedNumber = (reversedNumber * 10) + current;
                    num /= 10;
                }
            Console.WriteLine($"reverse number is {reversedNumber}");
        }
        public static void Get_Digits(this int num)
        {
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                ++count;
            }
            Console.WriteLine("Number of digits: " + count);
        }
        public static void Get_max(this List<int>arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Count-1; i++)
            {
              
                if (max < arr[i + 1])
                {
                    max = arr[i + 1];
                }
            }
            Console.WriteLine($"max number is : {max}");

        }
        public static void Remove_spicial_character(this string text)
        {
            
            string result = Regex.Replace(text, "[^a-zA-Z0-9]+", "");
            Console.WriteLine($"text =>> {result}"); 
        } 
    }
}