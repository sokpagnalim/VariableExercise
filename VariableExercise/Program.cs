using System;

namespace VariableExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName; //declaration syntax
            dogName = "Bobo";//initialized syntax
            int dogAge = 5; //declaration & initialized syntax
            char firstInitial = 'B';
            bool isHungry = true;
            double dogWeight = 15.5;//decimals
            decimal dogHeight = 8.5m;//end with m
                                     //Console.WriteLine($"My dog's name is {dogName}." +
                                     //$"He is {dogAge} years old." +
                                     //$"He weights {dogWeight} lbs," +
                                     //$"and he is {dogHeight} inches tall."
                                     //);
            String Message = $"My dog's name is {dogName}." +
               $"His initial is {firstInitial}." + 
               $"He is {dogAge} years old." +
               $"He weights {dogWeight} lbs," +
               $"and he is {dogHeight} inches tall.";

            Console.WriteLine("It is " + isHungry + " that he is always hungry.");

               





        }
    }
}
