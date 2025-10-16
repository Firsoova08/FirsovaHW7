using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaHW7
{
    internal class Dice
    {
        private int _sides;
        private Random _random;
        public Dice(int sides = 6)
        {
            this._sides = sides;
            this._random = new Random();
        }
        public int Roll()
        {
            return _random.Next(1, _sides + 1);  
        }
        public string GetInfo()
        {
            return $"{_sides}-гранный кубик";
        }

    }
}
