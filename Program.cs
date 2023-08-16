using System;

namespace RecapCSharp310
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car myCar = new Car();
            myCar.setName("YoCar");
            myCar.Details();
            Car audi=new Car("Audi A4",250,"blue");
            audi.Drive();
            audi.Details();
            Car bmw = new Car("BMW M5",350);
            bmw.Drive();
            bmw.Details();

            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                audi.Stop();
            }
        }
    }
}