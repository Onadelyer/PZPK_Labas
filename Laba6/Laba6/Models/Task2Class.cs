using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    class Bicycle
    {
        private string brand;
        private int year;
        private double price;
        private int gearCount;
        private bool isElectric;
        private string color;
        private double currentSpeed;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int GearCount
        {
            get { return gearCount; }
            set { gearCount = value; }
        }

        public bool IsElectric
        {
            get { return isElectric; }
            set { isElectric = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }


        public Bicycle()
        {
            brand = "Unknown";
            year = 2022;
            price = 0.0;
            gearCount = 1;
            isElectric = false;
            color = "Black";
            currentSpeed = 0.0;
        }

        public Bicycle(string brand, int year, double price, int gearCount, bool isElectric, string color, double currentSpeed)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
            this.gearCount = gearCount;
            this.isElectric = isElectric;
            this.color = color;
            this.currentSpeed = currentSpeed;
        }


        public void Accelerate(double speedIncrease)
        {
            currentSpeed += speedIncrease;
            Console.WriteLine($"Accelerating to {currentSpeed} km/h.");
        }

        public void Brake()
        {
            currentSpeed = 0.0;
            Console.WriteLine("Bicycle stopped.");
        }

        public string DisplayInfo()
        {
            return 
             $"Brand: {brand}"
             + $" Year: {year}"
             + $" Price: ${price}\n"
             + $" Gears: {gearCount}"
             + $" Electric: {isElectric}"
             + $" Color: {color}\n"
             + $" Current Speed: {currentSpeed} km/h";
        }
    }
}
