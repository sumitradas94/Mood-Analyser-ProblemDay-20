namespace MoodAnalyserProject
{
    class Program
    {
        static void Main(string[] args)
        {

            MoodAnalyser mood = new MoodAnalyser();
            Console.WriteLine("Enter mood Happy/Sad : ");
            string M = Console.ReadLine();
            mood.AnalyzeMood(M);
            Console.WriteLine(mood.AnalyzeMood(M));
        }
    }
}