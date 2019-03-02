using System;
using System.Collections.Generic;
using System.Linq;

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

            // ------------------ ALTERNATIVE SOLUTION -----------------------
            //Console.WriteLine("Eneter some letters");
            //var userInput = Console.ReadLine().ToLower();
            //var loopCount = 0;
            //var myCharacters = new List<string>();

            //foreach (var character in userInput)
            //{
            //    var letterString = character.ToString().ToUpper();
            //    // loopCount is going to give us the correct loopcount that we want so we dont have to use inner for loop
            //    letterString += new string(character, loopCount); //strings have a constructor that you can pass things to

            //    // adding string to a list
            //    myCharacters.Add(letterString);

            //    loopCount++;
            //}

            //// joining string to a separater and then writing it to a console
            //Console.WriteLine(string.Join('-', myCharacters));


            // ------------- ANOTHER SOLUTION --------------
            Console.WriteLine("Enter some letters");
            var userInput = Console.ReadLine().ToLower();
            var loopCount = 0;

            var longStringOutput = string.Join('-', userInput.ToCharArray().Select(c => c.ToString().ToUpper() + new string(c, loopCount++)));
            Console.WriteLine(longStringOutput);

            Console.ReadLine();
        }
    }
}
