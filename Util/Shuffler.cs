
using System.Collections.Generic;

namespace CardSimulator.Util
{
    public class Shuffler
    {
        public readonly IRandom _rand;
        public Shuffler( IRandom rand )
        {
            _rand = rand;
        }

        public IEnumerable<T> Shuffle<T>(IReadOnlyList<T> target)
        {
            IEnumerable<T> S( IList<T> t )
            {
                while ( t.Count != 0 )
                {
                    var i = _rand.Next( 0, t.Count );
                    yield return t[i];
                    t.RemoveAt( i );
                }
            }

            return S( new List<T>( target ) ); 
        }
    }
}
