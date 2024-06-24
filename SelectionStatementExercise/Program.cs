using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("What is my Favorite Number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else { Console.WriteLine("you guessed it!!"); }

            string userFavoriteSubject;

            do
            {
                Console.WriteLine("What is your favorite school subject?");

                userFavoriteSubject = Console.ReadLine();

                switch (userFavoriteSubject.ToLower())
                {

                    case "history":
                        Console.WriteLine("That is a great choice!");
                        break;
                    case "math":
                        Console.WriteLine("You are going Far!");
                        break;
                    case "science":
                        Console.WriteLine("Kaboom!!");
                        break;
                    case "art":
                        Console.WriteLine("You'll Never Make it!");
                        break;
                    case "engineering":
                        Console.WriteLine("Join the Team!");
                        break;
                    default:
                        Console.WriteLine("Never Heard Of It!");
                        continue;
                }
                break;
            } while (true);
            


        }


    }
 }


