
using System;

namespace CardSimulator.Gems
{
    public class Card
    {
        public int VictoryPoint { get; }
        public Gem Mine { get; }
        public Tuple<int, Gem>[] Cost { get; }

        public Card( int vp, Gem mine, Tuple<int, Gem>[] cost )
        {
            VictoryPoint = vp;
            Mine = mine;
            Cost = cost;
        }
    }
}
