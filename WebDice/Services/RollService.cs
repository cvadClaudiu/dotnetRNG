using System;

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
}
