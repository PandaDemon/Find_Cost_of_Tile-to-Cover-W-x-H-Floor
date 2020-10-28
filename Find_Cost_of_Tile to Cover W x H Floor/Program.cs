using System;

namespace Find_Cost_of_Tile_to_Cover_W_x_H_Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePrice();
        }

        public static void CalculatePrice()
        {
            double price;
            double area;
            double priceArea;
            area = CalculateArea();

            Console.WriteLine("Input the price per square meter");
            while (true)
            {
                try
                {
                    price = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            priceArea = Math.Round(area * price, 2);
            Console.WriteLine($"Price per square meter: {priceArea}$");
        }

        public static double CalculateArea() 
        {
            double width;
            double height;

            Console.WriteLine("Input width in 'mm'");
            width = Convert.ToDouble(Console.ReadLine()) / 1000;
            Console.WriteLine("Input height in 'mm'");
            height = Convert.ToDouble(Console.ReadLine()) / 1000;
            return (width * height);
        }
    }
}
