using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product();

            productOne.Id = 1;

            productOne.Name = "Mobile Phone";

            Console.WriteLine("-----Methods-----");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(productOne);
        }
    }
}