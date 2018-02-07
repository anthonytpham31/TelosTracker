namespace TelosLpTracker
{
    public class TelosHealth
    {
        private double Enrage { get; }
        public double StartingHealth { get; }
        public double PhaseFourStartingHealth { get; }

        public TelosHealth(double enrage)
        {
            Enrage = enrage;
            StartingHealth = PhaseOneHealth();
            PhaseFourStartingHealth = PhaseFourHealth();
        }

        public double PhaseOneHealth()
        {
            if (Enrage > 200) return 600000;
            return 400000 + Enrage * 1000;
        }

        public double PhaseTwoHealth()
        {
            return StartingHealth - StartingHealth * 0.25;
        }

        public double PhaseThreeHealth()
        {
            return StartingHealth - StartingHealth * 0.5;
        }

        public double PhaseFourHealth()
        {
            return StartingHealth - StartingHealth * 0.75;
        }

        public double PhaseFourFontOneHealth()
        {
            return PhaseFourStartingHealth - PhaseFourStartingHealth * 0.25;
        }

        public double PhaseFourFontTwoHealth()
        {
            return PhaseFourStartingHealth - PhaseFourStartingHealth * 0.5;
        }

        public double PhaseFourFontThreeHealth()
        {
            return PhaseFourStartingHealth - PhaseFourStartingHealth * 0.75;
        }
    }
}