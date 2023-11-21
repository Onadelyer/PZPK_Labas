using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    public interface ISoftwareProduct
    {
        string Name { get; set; }
        double Version { get; set; }

        void Release();
        void Update();
    }

    public interface IDeveloper
    {
        string DeveloperName { get; set; }
        string ProgrammingLanguage { get; set; }

        void Code();
        void Test();
    }

    class OperatingSystem : ISoftwareProduct, IDeveloper
    {
        public string Name { get; set; }
        public double Version { get; set; }
        public string DeveloperName { get; set; }
        public string ProgrammingLanguage { get; set; }

        public void Release()
        {
            Console.WriteLine($"{Name} {Version} has been released.");
        }

        public void Update()
        {
            Console.WriteLine($"Updating {Name} to version {Version + 0.1}.");
        }

        public void Code()
        {
            Console.WriteLine($"Coding {Name} in {ProgrammingLanguage}.");
        }

        public void Test()
        {
            Console.WriteLine($"Testing {Name} for bugs.");
        }

        public void ManageHardware()
        {
            Console.WriteLine($"Managing hardware compatibility for {Name}.");
        }

        public void SecurityCheck()
        {
            Console.WriteLine($"Performing security checks for {Name}.");
        }
    }

    class MobileApp : ISoftwareProduct, IDeveloper
    {
        public string Name { get; set; }
        public double Version { get; set; }
        public string DeveloperName { get; set; }
        public string ProgrammingLanguage { get; set; }

        public void Release()
        {
            Console.WriteLine($"{Name} {Version} has been released on app stores.");
        }

        public void Update()
        {
            Console.WriteLine($"Updating {Name} to version {Version + 0.1}.");
        }

        public void Code()
        {
            Console.WriteLine($"Coding {Name} in {ProgrammingLanguage}.");
        }

        public void Test()
        {
            Console.WriteLine($"Testing {Name} for usability and functionality.");
        }

        public void DesignUI()
        {
            Console.WriteLine($"Designing user interface for {Name}.");
        }

        public void ImplementFeatures()
        {
            Console.WriteLine($"Implementing new features for {Name}.");
        }
    }
}
