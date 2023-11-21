using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    public class Task3Class : CustomData
    {
        public int appliedForce;


        public Task3Class(int day, int month, int year, int appliedForce) : base(day, month, year)
        {
            this.appliedForce = appliedForce;
        }

        public double CalculateWork(double force, double distance)
        {
            double work = (force * distance) * Math.Cos(0) * appliedForce;

            return work;
        }
    }
}
