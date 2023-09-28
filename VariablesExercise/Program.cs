namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string myName = "Seth";
            //int myAge = 29;
            //double avg = 98.7;
            //decimal myWallet = 200.00m;
            //bool isMarried = true;
            //char inital = 'S';

            //Console.WriteLine($"Name: {myName}\nAge: {myAge}\nAverage: {avg}\nMoney: ${myWallet}\nMarried: {isMarried}\nInitial: {inital}");


            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");

        }
    }
}
