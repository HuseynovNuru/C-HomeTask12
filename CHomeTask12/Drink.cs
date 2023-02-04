using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CHomeTask12
{
    internal class Drink:Product
    {
        public double AlcoholPercent;

        public void DrinkShowInfo()
        {
            Console.WriteLine($"No{No}, Name: {Name}, Price: {Price} ,AlcoholPercent: {AlcoholPercent}");
        }
    }
}
