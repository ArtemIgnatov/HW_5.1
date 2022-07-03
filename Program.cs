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

        static string[] SplitWord(string text)
        {
            string[] wordsSplit = text.Split(' ', ',', '.', '!', '?');
            return wordsSplit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст.");
            string a = Console.ReadLine();
            string[] subs = SplitWord(a);
            Print(subs);    
            
            Console.ReadKey();
        }
    }   
        
}
