using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Laba6.Models
{
    public abstract class Plant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool OnTheVergeOfExtinction { get; set; }

        public abstract void Grow();
        public abstract void Blossom();

        public void Photosynthesize()
        {
            MessageBox.Show($"{this.Name} фотосинтезує");
        }

        public override string ToString()
        {
            return $"Name:{Name} Type:{Type} In Red List:{OnTheVergeOfExtinction}";
        }
    }

    public class Tree : Plant
    {
        public bool LeavesFallInAutumn { get; set; }

        public override void Grow()
        {

        }

        public override void Blossom()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} Are leaves fall in autumn:{LeavesFallInAutumn}";
        }
    }

    public class Flowers : Plant
    {
        public string Color { get; set; }

        public override void Grow()
        {

        }

        public override void Blossom()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} Color:{Color}";
        }
    }

    public class PlantDatabase
    {
        private List<Plant> _plants = new List<Plant>();

        public void AddPlant(Plant plant)
        {
            _plants.Add(plant);
        }

        public void DisplayInformationOnScreen(Label label)
        {
            var resultText = string.Join(" ", _plants.Select(p => p.ToString() + "\n").ToList());

            label.Content = resultText;
        }

        public void DisplayPlantsOnTheVergeOfExtinction(Label label)
        {
            var resultText = string.Join(" ", _plants.Where(p => p.OnTheVergeOfExtinction).Select(p => p.ToString() + "\n").ToList());

            label.Content = resultText;
        }

        public List<Plant> FindEndangeredSpecies()
        {
            return _plants.Where(p => p.GetType() == typeof(Tree) || p.GetType() == typeof(Flowers)).ToList();
        }

        public void GeneratePlants()
        {
            if (_plants.Count != 0)
            {
                return;
            }

            // Create a list to hold plants
            List<Plant> plantsList = new List<Plant>();

            Random r = new Random();

            // Generate 10 trees with unique parameters
            for (int i = 1; i <= 10; i++)
            {
                Tree tree = new Tree
                {
                    Name = $"Tree{i}",
                    Type = "Deciduous",
                    LeavesFallInAutumn = i % 2 == 0 // Example: Set LeavesFallInAutumn based on even/odd index
                };

                tree.OnTheVergeOfExtinction = r.Next(10) % 2 == 0;

                plantsList.Add(tree);
            }

            // Generate 10 flowers with unique parameters
            for (int i = 1; i <= 10; i++)
            {
                Flowers flower = new Flowers
                {
                    Name = $"Flower{i}",
                    Type = "Perennial",
                    Color = i % 2 == 0 ? "Red" : "Blue" // Example: Set color based on even/odd index
                };

                flower.OnTheVergeOfExtinction = r.Next(10) % 2 == 0;

                plantsList.Add(flower);
            }

            _plants = plantsList;
        }
    }

}
