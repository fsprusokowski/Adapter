using Adapter.Classes;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoPinPlug = new TwoPinPlug();
            var threePinPLug = new ThreePinPLug();

            Console.WriteLine("Two pin plug connection in a two hole input");
            twoPinPlug.Connect(FemalePLug.TwoInputs);
            Console.WriteLine("Two pin plug connected? {0}", twoPinPlug.Connected);

            Console.WriteLine();

            Console.WriteLine("Three pin plug connection in a two hole input");
            twoPinPlug.Connect(FemalePLug.TwoInputs);
            Console.WriteLine("Three pin plug connected? {0}", threePinPLug.Connected);

            Console.WriteLine();
            var adapter = new PlugAdapter(threePinPLug);

            Console.WriteLine("Three pin plug connection in a two hole input with adapter");
            adapter.Connect(FemalePLug.TwoInputs);
            Console.WriteLine("Three pin plug connected? {0}", threePinPLug.Connected);

            Console.ReadKey();
        }
    }
}
