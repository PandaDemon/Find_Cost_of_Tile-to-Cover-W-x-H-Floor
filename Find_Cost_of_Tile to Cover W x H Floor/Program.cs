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
            price = ValidateInput();
            priceArea = Math.Round(area * price, 2);
            Console.WriteLine($"Price per square meter: {priceArea}$");
        }

        public static double ValidateInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        public static double CalculateArea() 
        {
            double width;
            double height;

            Console.WriteLine("Input width in 'mm'");
            width = ValidateInput() / 1000;
            Console.WriteLine("Input height in 'mm'");
            height = ValidateInput() / 1000;
            return (width * height);
        }
    }
}
