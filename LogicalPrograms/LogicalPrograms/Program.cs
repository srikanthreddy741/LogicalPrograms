using System.Diagnostics;

namespace LogicalPrograms
{
    class Program
    {
        static Stopwatch watch = new Stopwatch();
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            StartStopWatch();
            EndStopWatch();

            Console.WriteLine("Measure the elapsed time: " + watch.Elapsed);
        }
        static void StartStopWatch()
        {
            string input = "null";
            while (input != "1")
            {
                Console.WriteLine("Enter the \'1\' to Start the StopWatch: ");
                input = Console.ReadLine();
                if (input == "1")
                    watch.Start();
            }
        }
        static void EndStopWatch()
        {
            string input = "null";
            while (input != "0")
            {
                Console.WriteLine("Enter the \'0\' to Stop the StopWatch:");
                input = Console.ReadLine();

                if (input == "0")
                    watch.Stop();
            }
        }
    }
}