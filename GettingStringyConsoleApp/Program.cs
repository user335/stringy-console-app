using System;
using System.Text;

namespace GettingStringyConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Greetings, human. It's time to get stringy.");
            Console.Write("What is your favorite fruit? Answer: ");
            var answer = Console.ReadLine();
            Console.Write("What? " + answer + "?! Are you serious right now... Answer : ");
            var answer2 = Console.ReadLine();
            Console.WriteLine("Ah ha! I've got you now. If you were serious you would have at least said said \'" + answer2.ToUpper() + "\'");
            StringBuilder stringyTime = new StringBuilder();
            stringyTime.Append("So, because you're not being serious, I don't have to be either.");
            stringyTime.Append(" It's about to get pretty stringy up in here.");
            stringyTime.Append(" It's about to get pretty stringy up in here.");
            stringyTime.Append(" It's about to get pretty stringy up in here.");
            stringyTime.Append(" It's about to get pretty stringy up in here.");
            stringyTime.Append(" ...told you so. B) ");
            Console.WriteLine(stringyTime);
            Console.Read();
        }
    }
}
