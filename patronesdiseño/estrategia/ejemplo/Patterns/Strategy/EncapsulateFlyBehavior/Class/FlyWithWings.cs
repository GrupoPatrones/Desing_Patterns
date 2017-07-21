using Patterns.Strategy.EncapsulateFlyBehavior.Interfaces;
using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.EncapsulateFlyBehavior.Class
{
    internal class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I'm flying";
        }
    }
}
