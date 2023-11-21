using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    abstract class Plant
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public abstract void Blossom();
        public abstract void Propagation();

        public void Information()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}");
        }

        public void LifeCycle()
        {
            Console.WriteLine("Life cycle of the plant.");
        }
    }

    class Tree : Plant
    {
        public string LeafType { get; set; }

        public override void Blossom()
        {
            Console.WriteLine("Trees blossom in spring or summer.");
        }

        public override void Propagation()
        {
            Console.WriteLine("Trees propagate by seeds or vegetative reproduction.");
        }

        public void Photosynthesis()
        {
            Console.WriteLine("Trees perform photosynthesis.");
        }

        public void Autumn()
        {
            Console.WriteLine("Autumn is the season of changing leaf colors on trees.");
        }
    }

    class Flowers : Plant
    {
        public string Color { get; set; }

        public override void Blossom()
        {
            Console.WriteLine("Flowers bloom in summer or autumn.");
        }

        public override void Propagation()
        {
            Console.WriteLine("Flowers propagate by seeds or seedlings.");
        }

        public void Fragrance()
        {
            Console.WriteLine("Many flowers have a delightful fragrance.");
        }

        public void Pruning()
        {
            Console.WriteLine("Pruning is recommended for better flower growth.");
        }
    }
}
