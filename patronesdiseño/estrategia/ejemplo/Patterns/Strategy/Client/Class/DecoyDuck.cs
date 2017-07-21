using Patterns.Strategy.Class;

namespace Patterns.Strategy.Client.Class
{
    internal class DecoyDuck : Duck
    {
        public override string Display()
        {
            return  "Display DecoyDuck";
        }
    }
}
