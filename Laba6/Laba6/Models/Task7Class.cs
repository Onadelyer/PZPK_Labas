using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Laba6.Models
{
    public interface IProduct
    {
        string Name { get; set; }
        double Version { get; set; }

        void Install();
        void Update(Label label);
    }
    
    public interface IDeveloper
    {
        string DeveloperName { get; set; }
        string ProgrammingLanguage { get; set; }

        void WriteCode();
        void TestCode();
    }
    
    public class CustomOperatingSystem : IProduct, IDeveloper
    {
        public string Name { get; set; } = "Bubuntu";
        public double Version { get; set; }
        public string DeveloperName { get; set; }
        public string ProgrammingLanguage { get; set; }

        private bool newFeatureHasBeenDeveloped = false;
        private bool newFeatureHasBeenTested = false;

        public void Install()
        {
            MessageBox.Show("Installing OS...");
        }

        public void Update(Label label)
        {
            if(newFeatureHasBeenDeveloped && newFeatureHasBeenTested)
            {
                MessageBox.Show("Updating OS...");
                Version += 0.1;
                label.Content = ToString();
            }
            else
                if(!newFeatureHasBeenDeveloped)
                    MessageBox.Show("New feature has not been developed");
                else if(!newFeatureHasBeenTested)
                    MessageBox.Show("New feature has not been tested");
        }

        public void WriteCode()
        {
            MessageBox.Show("Programmers are developing new feature");
            newFeatureHasBeenDeveloped = true;
        }

        public void TestCode()
        {
            if (!newFeatureHasBeenDeveloped) 
                MessageBox.Show("New feature has not been developed yet");
            else
            {
                MessageBox.Show("New feature has been tested");
                newFeatureHasBeenTested = true;
            }
        }
        
        public void RebootSystem()
        {
            MessageBox.Show("Rebooting system...");
        }

        public void AddUserToTheSystem()
        {
            MessageBox.Show("Adding user to the system...");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nVersion: {Version}\nDeveloper: {DeveloperName}\nProgramming language: {ProgrammingLanguage}";
        }
    }

    
    public class MobileApp : IProduct, IDeveloper
    {
        public string Name { get; set; } = "Cool app";
        public double Version { get; set; }
        public string DeveloperName { get; set; }
        public string ProgrammingLanguage { get; set; }

        private bool newFeatureHasBeenDeveloped = false;
        private bool newFeatureHasBeenTested = false;

        public void Install()
        {
            MessageBox.Show("Installing mobile app from PlayMarket");
        }

        public void Update(Label label)
        {
            if (newFeatureHasBeenDeveloped && newFeatureHasBeenTested)
            {
                MessageBox.Show("Updating app...");
                Version += 0.1;
                label.Content = ToString();
            }
            else
                if (!newFeatureHasBeenDeveloped)
                MessageBox.Show("New feature has not been developed");
            else if (!newFeatureHasBeenTested)
                MessageBox.Show("New feature has not been tested");
        }

        public void WriteCode()
        {
            MessageBox.Show("Programmers are developing new feature");
            newFeatureHasBeenDeveloped = true;
        }

        public void TestCode()
        {
            if (!newFeatureHasBeenDeveloped)
                MessageBox.Show("New feature has not been developed yet");
            else
            {
                MessageBox.Show("New feature has been tested");
                newFeatureHasBeenTested = true;
            }
        }

        public void TurnOnSecretChinaSpyCamera()
        {
            
        }

        public void EnableRootAccess()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {Name}\nVersion: {Version}\nDeveloper: {DeveloperName}\nProgramming language: {ProgrammingLanguage}";
        }
    }

}
