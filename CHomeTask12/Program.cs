
using System;

namespace CHomeTask12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Drink product elave et.");
                Console.WriteLine("2.Dairy product elave et.");
                Console.WriteLine("3.Butun productlara bax.");
                Console.WriteLine("4.Verilmis nomreli producta bax.");
                Console.WriteLine("5.Drink productlara bax.");
                Console.WriteLine("6.Dairy productlara.");
                Console.WriteLine("7.Ada gore axtaris et.");
                Console.WriteLine("8.Qiymet araligina gore axtaris et");
                Console.WriteLine("9.Siyahidan mehsulu sil.");
                Console.WriteLine("0.Menudan cix.");
                
                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch(option)
                {
                 case "1":
                        Console.WriteLine("Drink productun adini daxil edin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Drink productun qiymetini daxil edin:");
                        string priceStr = Console.ReadLine();
                        double price = double.Parse(priceStr);
                        Console.WriteLine("Drink productun spirt faizini daxil edin:");
                        string alcoholpercentStr = Console.ReadLine();
                        double alcoholpercent = double.Parse(alcoholpercentStr);
                        Drink drink = new Drink
                        {
                            Name = name,
                            Price = price,
                            AlcoholPercent = alcoholpercent
                        };
                        store.AddProduct(drink);
                       break;

                 case "2":
                        Console.WriteLine("Dairy productun adini daxil edin");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Dairy productun qiymetini daxil edin:");
                        string priceStr1 = Console.ReadLine();
                        double price1 = double.Parse(priceStr1);
                        Console.WriteLine("Dairy productun yagliliq faizini daxil edin:");
                        string fatpercentStr = Console.ReadLine();
                        double fatpercent = double.Parse(fatpercentStr);
                        Dairy dairy = new Dairy
                        {
                            Name = name1,
                            Price = price1,
                            FatPercent= fatpercent
                        };
                        store.AddProduct(dairy);
                        break;

                 case "3":
                        foreach(Product item in store.Products)
                        {
                            item.ShowInfo();
                        }
                       break;

                 case "4":
                        Console.WriteLine("No: ");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);

                        try
                        {
                            var wantedProduct = store.GetProductByNo(no);
                            wantedProduct.ShowInfo();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"{no} nomreli mehsul yoxdur!");
                        }

                        break;

                 case "5":
                        foreach (Drink item in store.Products)
                        {
                            item.DrinkShowInfo();
                        }
                        break;

                 case "6":
                        foreach (Dairy item in store.Products)
                        {
                            item.DairyShowInfo();
                        }
                        break;

                 case "7":
                        Console.WriteLine();
                        break;
                 case "8":
                        Console.WriteLine();
                       break;
                 case "9":
                        Console.WriteLine();
                       break;
                 case "0":
                        Console.WriteLine("Menudan cixis etdiniz.");
                       break;
                 default: 
                        Console.WriteLine("Sehv secim.");
                       break;
                }

            } while (option != "0");
        }
    }
}
