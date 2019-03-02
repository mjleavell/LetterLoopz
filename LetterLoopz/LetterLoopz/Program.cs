using System;

namespace LetterLoopz
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------ Tell user to type in text -----
            Console.WriteLine("Type some random letters");

            // ------ User enters an input -----
            var input = Console.ReadLine();
            var output = "";

            // ------ Loop over string -----
            for (var i = 0; i < input.Length; i++)
            {
                // ------ Make first letter Capital -----
                output += char.ToUpper(input[i]);

                // ------ Looping over each character the number of times equal to the index -----
                for (var j = 0; j < i; j++)
                {
                    // ------ If letter is not first, change to lower -----
                    output += char.ToLower(input[i]);
                }
                // ------ Add hypen -----
                output += "-";
            }
            // ------ Remove last hypen because we dont want it -----
            output = output.Remove(output.Length - 1);

            // ------ Output line is displayed in console -----
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
