using System;
using System.Collections.Generic;
using System.Text;

namespace CHomeTask12
{
    internal class Dairy:Product
    {
        public double FatPercent;

        public void DairyShowInfo()
        {
            Console.WriteLine($"No{No}, Name: {Name}, Price: {Price}, FatPercent{FatPercent}");
        }
    }
}
