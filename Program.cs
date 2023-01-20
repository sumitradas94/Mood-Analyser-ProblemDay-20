namespace MoodAnalyserProject
{
    class Program
    {
        static void Main(string[] args)
        {


            static void Main(string[] args)
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Enter mood Happy/Sad : ");
                    string M = Console.ReadLine();
                    MoodAnalyser mood = new MoodAnalyser(M);
                    Console.WriteLine(mood.AnalyzeMood());
                }
            }
        }
    }
}
