
using System;

namespace CardSimulator.Gems
{
    public class Bonus
    {
        public int VictoryPoint { get; }
        public Tuple<int, Gem>[] Requirement { get; }
        public Bonus( int vp, params Tuple<int, Gem>[] reqs )
        {
            VictoryPoint = vp;
            Requirement = reqs;
        }
    }
}
