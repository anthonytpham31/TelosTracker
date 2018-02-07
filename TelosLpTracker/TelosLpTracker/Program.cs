using System;
using System.Linq;

namespace TelosLpTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repeat = true;
            while (repeat)
            {
                var enrage = EnrageInput();
                var telosCalculations = new TelosHealth(enrage);
                OutputTelosHealth(telosCalculations);
                repeat = AskToPlayAgain();
            }
        }

        private static void OutputTelosHealth(TelosHealth telosCalculations)
        {
            Console.WriteLine("Phase One: " + telosCalculations.StartingHealth);
            Console.WriteLine("Phase Two: " + telosCalculations.PhaseTwoHealth());
            Console.WriteLine("Phase Three: " + telosCalculations.PhaseThreeHealth());
            Console.WriteLine("Phase Four: " + telosCalculations.PhaseFourStartingHealth);
            Console.WriteLine("Phase Four F1: " + telosCalculations.PhaseFourFontOneHealth());
            Console.WriteLine("Phase Four F2: " + telosCalculations.PhaseFourFontTwoHealth());
            Console.WriteLine("Phase Four F3: " + telosCalculations.PhaseFourFontThreeHealth());
        }

        private static double EnrageInput()
        {
            while (true)
            {
                Console.WriteLine("Input Enrage: ");
                var enrageInput = Console.ReadLine();

                if (CheckEnrageInput(enrageInput)) return double.Parse(enrageInput);
            }
        }

        private static bool CheckEnrageInput(string enrageInput)
        {
            return enrageInput.All(char.IsNumber);
        }

        private static bool AskToPlayAgain()
        {
            Console.WriteLine("Press Enter or Y to Play Again.");
            var repeatInput = Console.ReadLine()?.ToLower();
            Console.Clear();
            return repeatInput == "y" || repeatInput == "";
        }
    }
}
