using System;
using WebRand.Infrastructure;

namespace WebRand.Services
{
    public class RollService
    {
        private readonly Random _rn = new();
        
        public int Roll(int RNmin, int RNmax)
        {
            if (RNmin > RNmax)
                throw new ArgumentException("The minimum value cannot be greater than the maximum value.");
            if (RNmin == RNmax)
                return RNmin;
            if (RNmax == int.MaxValue)
                return RNmin + _rn.Next(int.MaxValue - RNmin);

            return _rn.Next(RNmin, RNmax + 1);
        }
    }

    public class DRollService
    {
        private readonly Random _Drn = new();

        public List<int> Droll(Dice dx)
        {
            if (dx.Dmax < 2)
                throw new ArgumentException("Dice must have at least 2 sides!");
            if (dx.Damount < 1)
                throw new ArgumentException("You must throw at least 1 dice!");

            var results = new List<int>();
            for (int i=0; i < dx.Damount; i++)
            {
                results.Add(_Drn.Next(dx.Dmin, dx.Dmax + 1));
            }
            return results;
        }
        
    }

}
