using System;

namespace LetterLoopz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some random letters");
            var input = Console.ReadLine();
            var output = "";

            for (var i = 0; i < input.Length; i++)
            {
                output += char.ToUpper(input[i]);
                
                for (var j = 0; j < i; j++)
                {
                    output += char.ToLower(input[i]);
                }
                output += "-";
            }
            output = output.Remove(output.Length - 1);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
