using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment1
{
    class World
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Animal usrAnimal = null;

            string usrChar;

            do
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("");

                Console.WriteLine("1- Add a New Animal");
                Console.WriteLine("2- Print Information on an Animal");
                Console.WriteLine("3- Have an Animal Make a Noise");
                Console.WriteLine("4- Age up an Animal");
                Console.WriteLine("5- Print a List of All Animals");
                Console.WriteLine("q- Quit the program");

                Console.WriteLine("");

                Console.Write("Please Enter a Character to Select an Option: ");
                usrChar = Console.ReadLine();

                if (usrChar == "1")
                {
                    string usrSelect;

                    Console.WriteLine("1-Cat");
                    Console.WriteLine("2-Cassowary");
                    Console.WriteLine("3-Programmer");
                    Console.WriteLine("");
                    Console.WriteLine("Please Select an Animal Type: ");

                    usrSelect = Console.ReadLine();

                    printFunct(usrSelect, usrAnimal, Animals);

                    Console.WriteLine("");
                    Console.WriteLine("New Animal Added!");
                    Console.WriteLine("");
                }

                if (usrChar == "2")
                {
                    infoFunct(usrAnimal, Animals);
                }

                if (usrChar == "3")
                {
                    noiseFunct(usrAnimal, Animals);
                }

                if (usrChar == "4")
                {
                    ageFunct(usrAnimal, Animals);
                }

                if (usrChar == "5")
                {
                    printAll(Animals);
                }

            } while (usrChar != "q");

        }

        static void printFunct(string selectStr, Animal obj, List<Animal> Animals)
        {
            string aName;
            string aAge;
            string aWeight;

            if (selectStr == "1")
            {
                obj = new Cat();
            }

            else if (selectStr == "2")
            {
                obj = new Cassowary();
            }

            else if (selectStr == "3")
            {
                obj = new Programmer();
            }

            else
            {
                obj = new Cat();
            }

            Console.Write("Please Enter The Animal's Name: ");
            aName = Console.ReadLine();

            Console.Write("Please Enter The Animal's Age (years): ");
            aAge = Console.ReadLine();

            Console.Write("Please Enter The Animal's Weight (lbs.): ");
            aWeight = Console.ReadLine();

            obj.nAnimal(aName, int.Parse(aAge), int.Parse(aWeight));

            Animals.Add(obj);

            Console.WriteLine("");
            Console.WriteLine("New Animal Added!");
            Console.WriteLine("");
        }

        static void infoFunct(Animal obj, List<Animal> Animals)
        {
            string usrSelect;

            Console.Write("Please Enter The Animal's Name: ");
            usrSelect = Console.ReadLine();

            obj = Animals.Find(x => x.name == usrSelect);

            obj.printInfo();

            Console.WriteLine("");

        }

        static void noiseFunct(Animal obj, List<Animal> Animals)
        {
            string usrSelect;

            Console.Write("Please Enter The Animal's Name: ");
            usrSelect = Console.ReadLine();

            obj = Animals.Find(x => x.name == usrSelect);

            obj.makeNoise();

            Console.WriteLine("");
        }

        static void ageFunct(Animal obj, List<Animal> Animals)
        {
            string usrSelect;

            Console.Write("Please Enter The Animal's Name: ");
            usrSelect = Console.ReadLine();

            obj = Animals.Find(x => x.name == usrSelect);

            obj.ageUp();

            Console.WriteLine("");
            Console.WriteLine(obj.name + "'s age is now: " + obj.age + " years old!");
            Console.WriteLine("");

        }

        static void printAll(List<Animal> Animals)
        {
            int count = 1;
            string animalType;

            foreach (Animal obj in Animals)
            {
                if (obj.noise == "Meow!")
                {
                    animalType = "Cat";
                }

                else if (obj.noise == "Squawk! Squawk!")
                {
                    animalType = "Cassowary";
                }

                else if (obj.noise == "Hello World!")
                {
                    animalType = "Programmer";
                }

                else
                {
                    animalType = "Unknown";
                }

                Console.Write(count + "). ");
                Console.WriteLine("Name: " + obj.name + " Type: " + animalType);

                count++;
            }

            Console.WriteLine("");
        }

    }
}
