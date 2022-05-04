using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            //#region bird
            //Bird penguin = new Bird()
            //{
            //    Legs = 2,
            //    HasFur = false,
            //    Color = "black and white, some yellow",
            //    HasTail = true,
            //    CanFly = false,
            //    BeakSize = "small",
            //    HasWebbedFeet = true,
            //    WingSpanSize = "short",               
            //};
            //Console.WriteLine($" The following are some of the characteristics of a penguin. It has {penguin.Legs} legs." +
            //    $"\n The penguin is {penguin.Color}. The beak size of the penguin is {penguin.BeakSize}." +
            //    $"\n The wingspan of the penguin is relatively {penguin.WingSpanSize}. ");
            //Console.WriteLine("----------------------------------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------------------------------");

            //var answer1 = penguin.HasFur;
            //var answer2 = penguin.HasTail;
            //var answer3 = penguin.CanFly;
            //var answer4 = penguin.HasWebbedFeet;

            //Console.WriteLine("Time for Penguin trivia!\n All answers are true or false.");
            ////Question 1
            //Console.WriteLine("Question 1: Does a penguin have fur?");                        
            //string userInput1 = Console.ReadLine();
            //if (userInput1 == "true")
            //{
            //    Console.WriteLine($"{answer1}. You are incorrect!");

            //}
            //else if (userInput1 == "false")
            //{
            //    Console.WriteLine("You are correct!");
            //}
            //Console.WriteLine();

            ////Question 2
            //Console.WriteLine("Question 2: Does a penguin have a tail?");
            //string userInput2 = Console.ReadLine();
            //if (userInput2 == "true")
            //{
            //    Console.WriteLine("You are correct!");

            //}
            //else if (userInput2 == "false")
            //{
            //    Console.WriteLine($"{answer2}. You are incorrect!");
            //}
            //Console.WriteLine();

            ////Question 3
            //Console.WriteLine("Question 3: Can a penguin fly?");
            //string userInput3 = Console.ReadLine();
            //if (userInput3 == "true")
            //{
            //    Console.WriteLine($"{answer3}. You are incorrect!");

            //}
            //else if (userInput3 == "false")
            //{
            //    Console.WriteLine("You are correct");
            //}
            //Console.WriteLine();

            ////Question 4
            //Console.WriteLine("Question 4: Does a penguin have webbed feet");
            //string userInput4 = Console.ReadLine();
            //if (userInput4 == "true")
            //{
            //    Console.WriteLine("You are correct!");

            //}
            //else if (userInput4 == "false")
            //{
            //    Console.WriteLine($"{answer4}. You are incorrect!");
            //}
            //Console.WriteLine();
            //Console.WriteLine("This is the end of penguin trivia. Thank you for participating!");
            //#endregion bird 

            Reptile snake = new Reptile()
            {
                Color = "can very depending on type",
                ColdBlooded = "Yes",
                Scales = "Yes",
                LaysEggs = true,
                ShedsSkin = true,
            };
            Console.WriteLine($" The following are some characteristics of a reptile,specifically a snake.\n" +
                $"\n It has {snake.Legs} legs. The color of a snake {snake.Color}.\n" +
                $"\n Is a snake coldblooded? {snake.ColdBlooded}." +
                $"\n Does a snake have scales? {snake.Scales}.");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");

            var answer01 = snake.HasFur;
            var answer02 = snake.HasTail;
            var answer03 = snake.LaysEggs;
            var answer04 = snake.ShedsSkin;

            Console.WriteLine(" Now it's time for snake trivia!\n All answers must be true or false.");
            //Question 1
            Console.WriteLine(" Question 1: Does a snake have fur?");
            string userInput01 = Console.ReadLine();
            if (userInput01 == "true")
            {
                Console.WriteLine($"{answer01}. You are incorrect!");

            }
            else if (userInput01 == "false")
            {
                Console.WriteLine("You are correct!");
            }
            Console.WriteLine();

            //Question 2
            Console.WriteLine(" Question 2: Does a snake have a tail?");
            string userInput02 = Console.ReadLine();
            if (userInput02 == "true")
            {
                Console.WriteLine("You are correct!");

            }
            else if (userInput02 == "false")
            {
                Console.WriteLine($"{answer02}. You are incorrect!");
            }
            Console.WriteLine();

            //Question 3
            Console.WriteLine(" Question 3: Does a snake lay eggs?");
            string userInput03 = Console.ReadLine();
            if (userInput03 == "true")
            {
                Console.WriteLine("You are correct!");

            }
            else if (userInput03 == "false")
            {
                Console.WriteLine($"{answer03}. You are incorrect!");
            }
            Console.WriteLine();

            //Question 4
            Console.WriteLine(" Question 4: Does a snake shed its skin?");
            string userInput04 = Console.ReadLine();
            if (userInput04 == "true")
            {
                Console.WriteLine("You are correct!");

            }
            else if (userInput04 == "false")
            {
                Console.WriteLine($"{answer04}. You are incorrect!");
            }
            Console.WriteLine();
            Console.WriteLine("This is the end of snake trivia. Thank you for participating!");









        }
    }
}
