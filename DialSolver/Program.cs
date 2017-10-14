using System;

namespace DialSolver
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting and answer values for the YELLOW dial.");
            var yellowStartVal = Console.ReadLine();
            var yellowAnswerVal = Console.ReadLine();
            Console.WriteLine("Enter the starting and answer values for the ORANGE dial.");
            var orangeStartVal = Console.ReadLine();
            var orangeAnswerVal = Console.ReadLine();
            Console.WriteLine("Enter the starting and answer values for the BLUE dial.");
            var blueStartVal = Console.ReadLine();
            var blueAnswerVal = Console.ReadLine();
            Console.WriteLine("Enter the starting and answer values for the PURPLE dial.");
            var purpleStartVal = Console.ReadLine();
            var purpleAnswerVal = Console.ReadLine();

            if (yellowStartVal == null || orangeStartVal == null || blueStartVal == null || purpleStartVal == null) return;
            if (yellowAnswerVal == null || orangeAnswerVal == null || blueAnswerVal == null || purpleAnswerVal == null) return;

            var dialSolver = new DialSolver(new[]
            {
                new Dial(int.Parse(yellowStartVal), int.Parse(yellowAnswerVal), DialColours.Yellow, 0, 9),
                new Dial(int.Parse(orangeStartVal), int.Parse(orangeAnswerVal), DialColours.Orange, 0, 9),
                new Dial(int.Parse(blueStartVal), int.Parse(blueAnswerVal), DialColours.Blue, 0, 9),
                new Dial(int.Parse(purpleStartVal), int.Parse(purpleAnswerVal), DialColours.Purple, 0, 9)
            });

            dialSolver.Solve();
        }
    }
}
