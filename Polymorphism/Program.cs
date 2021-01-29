using System;

namespace Polymorphism
{
    class Program
    {
        class Product //Base Class
        {
            public string Name { get; set; }
            public string Outlet { get; set; }
            public decimal Price { get; set; }
            public virtual decimal TaxInclusivePrice() // Virtual ile işaretlenmiş metotlar Derived Class'larda ezilebilir.
            {
               return Price + Price * (0.10m);
            }
        }
        class GameConsole:Product //Derived Class
        {
            public override decimal TaxInclusivePrice() //override (geçersiz kılmak) keyword'u ile Base Class'tan kalıtılmış metot ezilir.
            {
                return Price + Price * (1.27m);
            }
        }
        static void Main(string[] args)
        {
            Product prd = new Product();
            prd.Name = "Xbox Series X";
            prd.Outlet = "USA";
            prd.Price = 454;
            prd.TaxInclusivePrice();

            Console.WriteLine(prd.Outlet + "\n" + "Product Name: " + prd.Name +"\n"+"Price: " + prd.Price+" $" +"\n"+ "Tax Inclusive Price: "+ prd.TaxInclusivePrice()+" $"+"\n");

            GameConsole gc = new GameConsole();
            gc.Name = "Xbox Series X";
            gc.Outlet = "Turkey";
            gc.Price = 3315;
            gc.TaxInclusivePrice();

            Console.WriteLine(gc.Outlet+"\n"+"Product Name: " + gc.Name + "\n" + "Price: " + gc.Price + " TL" + "\n" + "Tax Inclusive Price: " + gc.TaxInclusivePrice() + " TL" + "\n");
        }
    }
}
