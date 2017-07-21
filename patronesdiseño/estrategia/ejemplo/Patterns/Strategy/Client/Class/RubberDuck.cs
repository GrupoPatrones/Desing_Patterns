using Patterns.Strategy.Class;

namespace Patterns.Strategy.Client.Class
{
    internal class RubberDuck : Duck
    {
        public override string Display()
        {
            return "Display RubberDuck";
        }
    }
}
