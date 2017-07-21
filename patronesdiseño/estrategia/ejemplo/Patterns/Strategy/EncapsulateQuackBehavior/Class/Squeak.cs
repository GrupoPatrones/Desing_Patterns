using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Class
{
    internal class Squeak : IQuackBehavior
    {
        public string Quack()
        {
            return "Squeck";
        }
    }
}
