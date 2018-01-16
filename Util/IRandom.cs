
namespace CardSimulator.Util
{
    public interface IRandom
    {
        int Next();

        int Next(int maxExclusive);

        int Next(int min, int max);
    }
}
