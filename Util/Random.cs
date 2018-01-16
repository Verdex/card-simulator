
namespace CardSimulator.Util
{
    public class Random : IRandom
    {
        private readonly System.Random _rand;
        public Random()
        {
            _rand = new System.Random();
        }

        public int Next()
        {
            return _rand.Next();
        }

        public int Next(int maxExclusive)
        {
            return _rand.Next(maxExclusive);
        }

        public int Next(int min, int max)
        {
            return _rand.Next(min, max);
        }
    }
}
