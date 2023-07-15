using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramms
{
    public interface ICountry
    {
        void Travel();
    }

    public interface IWorld
    {
        void Travel();
    }

    public abstract class AbstractCountry : ICountry, IWorld
    {
        public abstract void Travel();
    }

    public class YellowBus : AbstractCountry
    {
        public override void Travel()
        {
            Console.WriteLine("I am traveling to a beautiful country by yellow bus.");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            YellowBus yellowBus = new YellowBus();
            yellowBus.Travel();
        }
    }
}
