using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    public class Task3Class : CustomData
    {
        public int AgeOfProduct;


        public Task3Class(int day, int month, int year) : base(day, month, year)
        {

        }

        public void CalculateAgeOfProduct(int manifacturingYear)
        {
            AgeOfProduct = manifacturingYear - Year;
        }
    }
}
