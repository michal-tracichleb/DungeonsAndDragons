using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.StuffToGame
{
    internal class RollDice
    {
        Random rnd = new Random();
        public int K4()
        {
            return rnd.Next(0,5);
        }
        public int K6()
        {
            return rnd.Next(0, 7);
        }
        public int K8()
        {
            return rnd.Next(0, 9);
        }
        public int K10()
        {
            return rnd.Next(0, 11);
        }
        public int K12()
        {
            return rnd.Next(0, 13);
        }
        public int K20()
        {
            return rnd.Next(0, 21);
        }
        public int K100()
        {
            return rnd.Next(0, 101);
        }
    }
}
