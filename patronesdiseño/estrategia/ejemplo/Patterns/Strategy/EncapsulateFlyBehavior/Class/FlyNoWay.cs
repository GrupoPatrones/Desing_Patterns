using Patterns.Strategy.EncapsulateFlyBehavior.Interfaces;
using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.EncapsulateFlyBehavior.Class
{
    internal class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I Cant't fly";
        }
    }
}
