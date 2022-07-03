using System;

namespace HW_5._1
{
    internal class Program
    {
        static void Print(string[] nums)
        {
            foreach (var num in nums)
            {
                Console.WriteLine($"{num}");
            }
        }

        static string[] Get(string Str)
        {
            string[] strNew = Str.Split(' ','.',',','?','!');
            return strNew;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст.");
            string a = Console.ReadLine();
            string[] subs = Get(a);
            Print(subs);    
            
            Console.ReadKey();
        }
    }   
        
}
