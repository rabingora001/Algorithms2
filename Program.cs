using System;

namespace fundamentalAlgo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //foreach loop
            string[] arr={"civic","deified","deleveled","devoved","dew"};

            Console.WriteLine("Checking words for Palindrome");
            foreach(string str in arr)
            {
                Console.WriteLine("{0} = {1}" , str, AlgoPractice.isPalindrome(str));
            }
        }
    }

    class AlgoPractice
    {
        public static bool isPalindrome(string myStr)
        {
            for (int i=0; i<myStr.Length/2; i++)
            {
                if(myStr[i] != myStr[myStr.Length-1-i])
                    return false;
            }
            return true;
        }
    }
}
