using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaHW7
{
    internal class Character
    {
        public int Health;
        public int Mana;
        public Character(int health, int mana)
        {
            this.Health = health;
            this.Mana = mana;
        }
        public void Attack()
        {
            Console.WriteLine("Персонаж атакует!");
        }
    }
}
