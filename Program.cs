using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mercedes properties = new Mercedes();
            properties.brand = "Mercedes";
            Console.WriteLine(properties.brand);
            BMW property = new BMW();
            property.color = "red";
            Console.WriteLine(property.color);

        }
    }
}