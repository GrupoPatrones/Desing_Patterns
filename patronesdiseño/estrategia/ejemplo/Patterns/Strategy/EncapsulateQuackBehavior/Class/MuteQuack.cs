using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.EncapsulateQuackBehavior.Class
{
    internal class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "Silence";
        }
    }
}
