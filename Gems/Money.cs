

namespace CardSimulator.Gems
{
    public interface IMoney
    {
         Gem[] UsableAs();  
    }

    public class Gold : IMoney
    {
        private readonly Gem[] _gem = new [] { Gem.Ruby
                                             , Gem.Diamond
                                             , Gem.Sapphire
                                             , Gem.Emerald
                                             , Gem.Amethyst
                                             }; 
        public Gem[] UsableAs() => _gem;
    }

    public class Ruby : IMoney
    {
        private readonly Gem[] _gem = new [] { Gem.Ruby };
        public Gem[] UsableAs() => _gem;
    }

    public class Diamond : IMoney
    {
        private readonly Gem[] _gem = new [] { Gem.Diamond };
        public Gem[] UsableAs() => _gem;
    }

    public class Sapphire : IMoney
    {
        private readonly Gem[] _gem = new [] { Gem.Sapphire };
        public Gem[] UsableAs() => _gem;
    }

    public class Emerald : IMoney
    {
        private readonly Gem[] _gem = new [] { Gem.Emerald };
        public Gem[] UsableAs() => _gem;
    }

    public class Amethyst : IMoney
    {
        private readonly Gem[] _gem = new [] { Gem.Amethyst };
        public Gem[] UsableAs() => _gem;
    }
}
