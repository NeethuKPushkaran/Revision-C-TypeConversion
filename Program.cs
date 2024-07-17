using System;

namespace TypeConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            int a = 123;
            double b = a;
            Console.WriteLine("Implicit conversion: " + b);

            // Explicit conversion
            double c = 123.45;
            int d = (int)c;
            Console.WriteLine("Explicit conversion: " + d);

            // Using Convert class
            string e = "123";
            int f = Convert.ToInt32(e);
            double g = Convert.ToDouble(e);
            Console.WriteLine("Convert class: " + f + ", " + g);

            // Using Parse method
            string h = "456";
            int i = int.Parse(h);
            double j = double.Parse(h);
            Console.WriteLine("Parse method: " + i + ", " + j);

            // Using TryParse method
            string k = "789";
            if (int.TryParse(k, out int l))
            {
                Console.WriteLine("TryParse method: " + l);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

            // Using ToString method
            int o = 123;
            string p = o.ToString();
            double q = 456.78;
            string r = q.ToString();
            Console.WriteLine("ToString method: " + p + ", " + r);
        }
    }
}