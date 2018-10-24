using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int actYear = 2018, ageLimit = 10;
            Animal.ActualYear = actYear;
            Animal.AgeLimit = ageLimit;

            Competition();
        }

        private static void Competition()
        {
            Animal animal;
            string name;
            int birthYear;
            int beauty,behaviour;
            int randomScoreLimit = 10;

            Random rand = new Random();

            int competitorSum = 0;
            int scoreSum = 0;
            //int maxScore = 0;

            Console.WriteLine("Competition begins \n");
            char next = 'y';

            while (next== 'y')
            {
                Console.Write("\n The name of the animal: ");
                name = Console.ReadLine();
                Console.Write("Its birthYear: ");
                while (!int.TryParse(Console.ReadLine(),out birthYear) || birthYear<=0 || birthYear>= Animal.ActualYear )
                {
                    Console.Write("Incorrect data,try again");
             
                }
                beauty = rand.Next(randomScoreLimit + 1);
                behaviour = rand.Next(randomScoreLimit + 1);
                animal = new Animal(name, birthYear);
                animal.Scoring(beauty, behaviour);
                Console.WriteLine(animal);
                scoreSum += animal.Score;
                competitorSum++;
                Console.Write("Is there any more animal? y/n: ");
                next = char.Parse(Console.ReadLine());

                //Try find the maximum
            }
        }
    }
}
