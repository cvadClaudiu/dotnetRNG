namespace WebRand.Infrastructure
{
    public class Dice
    {
        public int Dmin { get; private set; } = 1;
        public int Dmax { get; private set; }
        public int Damount { get; private set; }
        public List<int> Drez { get; private set; } = new();

        public Dice(DiceType type, int Dtype)
        {
            Dmax = (int)type; 
            Damount = Dtype;
        }
    }

    public enum DiceType
    {
        coin = 2,
        d4 = 4,
        d6 = 6,
        d10 = 10,
        d20 = 20
    }
}
