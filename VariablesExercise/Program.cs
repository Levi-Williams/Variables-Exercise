namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string bakedGood = "Pie";
            int bakeTime = 20;
            char exclamation = '!';
            bool isBakedGoodGlutenFree = false;
            double coolOffTime = 10.5;
            decimal timeToEat = 1.43m;

            Console.WriteLine($"I will make {bakedGood} for dessert tonight. It should take {bakeTime} minutes to complete{exclamation}" +
                $"After removing from the oven it will take {coolOffTime} minutes to cool. I am so hungry I am sure it will only take {timeToEat}" +
                $" minutes to eat! ");

            if (isBakedGoodGlutenFree == false)
            {
                Console.WriteLine("I should mention, however, this pie is not gluten free");
            }
            else
                    {
                Console.WriteLine("And to add to how tasty it is, it's even gluten free!");
            }


        }
    }
}
