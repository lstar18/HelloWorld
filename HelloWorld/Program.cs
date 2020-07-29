using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();

            Console.WriteLine("Please select from southern, robot, or Hawaiian greeting");
            var dialect = Console.ReadLine();

            if (dialect == "southern")
            {
                Console.WriteLine($"'Howdy {name}'");
            }
            else if (dialect == "robot")
            {
                Console.WriteLine($"'H.E.L.L.O {name}'");
            }
            else if (dialect == "Hawaiian")
            {
                Console.WriteLine($"'Aloha {name}'");
            }
            //Console.WriteLine("Please enter your favorite color");

            //var favColor = Console.ReadLine();

            //randomDino = 
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            int CountSyllables(string word)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                string currentWord = word;
                int numVowels = 0;
                bool lastWasVowel = false;
                foreach (char wc in currentWord)
                {
                    bool foundVowel = false;
                    foreach (char v in vowels)
                    {
                        //don't count diphthongs
                        if (v == wc && lastWasVowel)
                        {
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                        else if (v == wc && !lastWasVowel)
                        {
                            numVowels++;
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                    }
                    //if full cycle and no vowel found, set lastWasVowel to false;
                    if (!foundVowel)
                        lastWasVowel = false;
                }
                //remove es, it's _usually? silent
                if (currentWord.Length > 2 &&
                    currentWord.Substring(currentWord.Length - 2) == "es")
                    numVowels--;
                // remove silent e
                else if (currentWord.Length > 1 &&
                    currentWord.Substring(currentWord.Length - 1) == "e")
                    numVowels--;
                return numVowels;
            }
            for (int i = 0; i < animals.Length; i++)
            {
                int syllableCount = CountSyllables(animals[i]);
                if (syllableCount >= 2)
                {
                    Console.WriteLine(animals[i]);
                }
            }

        }

    }
}
