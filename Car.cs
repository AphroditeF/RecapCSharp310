using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapCSharp310
{
    internal class Car
    {
        private string _name; //private field
        private int _hp;
        private string _color;

        //Default Constructor
        public Car() {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }
        //Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            _hp = hp;
            _color = "red";
            Console.WriteLine(name + "was created!");
        }
        //Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine(name + "was created!");
        }
        public void Drive() {
            Console.WriteLine(_name + " is driving");
        }
        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");
        }
        public void Details() {
            Console.WriteLine("The " + _color + " car " + _name + " has " + _hp + " hp.");
        }

        public void setName(string name) {
            if (name == "") {
                _name = "Default name";
            }
            else
            {
                _name = name;
            }
        }
    }
}
