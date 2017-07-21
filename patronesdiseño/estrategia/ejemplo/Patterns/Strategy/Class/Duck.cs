using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Strategy.EncapsulateFlyBehavior.Interfaces;
using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Class
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        protected Duck()
        {
            
        }

        public abstract string Display();

        public string Swim()
        {
            return "All ducks float, even decoys!";
        }

        public string PerformQuack()
        {
            return _quackBehavior.Quack();
        }

        public string PerformFly()
        {
            return _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

    }
}
