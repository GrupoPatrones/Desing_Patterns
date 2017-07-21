using System;
using Patterns.Strategy.Class;
using Patterns.Strategy.Client.Class;
using Patterns.Strategy.EncapsulateFlyBehavior.Class;
using Patterns.Strategy.EncapsulateQuackBehavior.Class;

namespace Patterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Duck mallard = new MallarDuck();
            mallard.SetFlyBehavior(new  FlyNoWay());
            mallard.SetQuackBehavior(new Quack());
            var result = mallard.PerformQuack();
            var msj = mallard.PerformFly();

            Console.WriteLine(result);
            Console.WriteLine(msj);
            
            mallard.SetFlyBehavior(new FlyWithWings());
            mallard.SetQuackBehavior(new MuteQuack());

            var result1 = mallard.PerformQuack();
            var msj1 = mallard.PerformFly();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(result1);
            Console.WriteLine(msj1);
            Console.ReadLine();

        }
    }
}
