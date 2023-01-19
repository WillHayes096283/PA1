/*
 * @file Program.cs
 * @author William Hayes
 * @date 1/18/2023
 * @brief This is the main program file.
 * 
 * This file allows the user to interact with a list of animals.
 * Using various character inputs, the user can: add new animals
 * to the list, have an animal make a noise, increase the age of
 * an animal, print information (name, age, and weight) of an
 * animal, and print all animal within the list.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI352_PA1
{

    /*
     * This is main World class, using a menu the user can interact with Animal objects on
     * a list, including: add new Animal objects to the list, printing info on Animal object
     * in a list, printing all Animal objects in a list, having an Animal object make a noise,
     * and increase the age of an Animal by 1.
     * 
     * @class World Program.cs
     * @brief Allows the user to interact with a list of Animal objects
     */
    class World
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>(); //declares a list of Animal objects

            Animal usrAnimal = null; //set object to null to allow its usage in functions

            string usrChar;

            Console.WriteLine("Welcome!");
            Console.WriteLine("");

            do //menu loop
            {

                Console.WriteLine("1- Add a New Animal");
                Console.WriteLine("2- Print Information on an Animal");
                Console.WriteLine("3- Have an Animal Make a Noise");
                Console.WriteLine("4- Age up an Animal");
                Console.WriteLine("5- Print a List of All Animals");
                Console.WriteLine("q- Quit the program");

                Console.WriteLine("");

                Console.Write("Please Enter a Character to Select an Option: ");
                usrChar = Console.ReadLine();

                if (usrChar == "1") //add a new animal
                {
                    string usrSelect;

                    Console.WriteLine("1-Cat");
                    Console.WriteLine("2-Cassowary");
                    Console.WriteLine("3-Programmer");
                    Console.WriteLine("");
                    Console.WriteLine("Please Select an Animal Type: ");

                    usrSelect = Console.ReadLine();

                    addFunct(usrSelect, usrAnimal, Animals);

                    Console.WriteLine("");
                    Console.WriteLine("New Animal Added!");
                    Console.WriteLine("");
                }

                if (usrChar == "2") //print info an animal
                {
                    infoFunct(usrAnimal, Animals);
                }

                if (usrChar == "3") //print noise to console
                {
                    noiseFunct(usrAnimal, Animals);
                }

                if (usrChar == "4") //increase age
                {
                    ageFunct(usrAnimal, Animals);
                }

                if (usrChar == "5") //print all objects in list
                {
                    printAll(Animals);
                }

            } while (usrChar != "q"); //terminate program

        }

        /*
         * This function adds a new animal object to the list. Depending on the type selected it
         * may be new Cat, Cassowary, or Programmer object. Also allows the user to input Name,
         * Age, and Weight info for the new Animal object.
         * 
         * @para string selectStr string that is the type of Animal object the user wants to add
         * @para Animal obj an Animal obj, used to temporarily store the new object's data
         * @para List<Animal> Animals the list of Animal objects
         * @pre Animal obj needs to be properly declared, and valid string stored into selectStr
         * @post Adds new Animal object with the user's inputted info into the Animals list
         * 
         */
        static void addFunct(string selectStr, Animal obj, List<Animal> Animals)
        {
            string aName;
            string aAge;
            string aWeight;

            if (selectStr == "1") //create new Cat class object
            {
                obj = new Cat();
            }

            else if (selectStr == "2") //create new Cassowary class object
            {
                obj = new Cassowary();
            }

            else if (selectStr == "3") //crete new Programmer class object
            {
                obj = new Programmer();
            }

            else //by default make a new animal a cat (this helped test printAll by adding new Animals quickly).
            {
                obj = new Cat(); 
            }

            //input info

            Console.Write("Please Enter The Animal's Name: ");
            aName = Console.ReadLine();

            Console.Write("Please Enter The Animal's Age (years): ");
            aAge = Console.ReadLine();

            Console.Write("Please Enter The Animal's Weight (lbs.): ");
            aWeight = Console.ReadLine();

            obj.nAnimal(aName, int.Parse(aAge), int.Parse(aWeight)); //assign info to new object

            Animals.Add(obj);

            Console.WriteLine("");
            Console.WriteLine("New Animal Added!"); //little console prompt notifying that a new object was made
            Console.WriteLine("");
        }

        /*
         * This function searches the Animals list for an Animal object with a matching name.
         * Once a matching name is found, the object's Name, Age, and Weight info is printed
         * to conosle.
         * 
         * @para Animal obj some Animal obj, used to store and access data of an Animal object
         * from the list
         * @para List<Animal> Animals the list of Animal objects
         * @pre obj must be a properly declare Animal object, and the user must input a valid
         * name of an animal object in the list
         * 
         */
        static void infoFunct(Animal obj, List<Animal> Animals)
        {
            string usrSelect; //name of animal that usr selects to find

            Console.Write("Please Enter The Animal's Name: ");
            usrSelect = Console.ReadLine();
            Console.WriteLine("");

            obj = Animals.Find(x => x.name == usrSelect); //finds object in list with matching name

            obj.printInfo(); //calls overrided method

            Console.WriteLine("");

        }

        /*
         * This function, uses an Animal object's name to find it within a list. Once found
         * the object's Noise string is printed to console.
         * 
         * @para Animal obj some Animal obj, used to store and access data of an Animal object
         * from the list
         * @para List<Animal> Animals the list of Animal objects
         * @pre obj must be a properly declare Animal object, and the user must input a valid
         * name of an animal object in the list
         */
        static void noiseFunct(Animal obj, List<Animal> Animals)
        {
            string usrSelect;

            Console.Write("Please Enter The Animal's Name: ");
            usrSelect = Console.ReadLine();
            Console.WriteLine("");

            obj = Animals.Find(x => x.name == usrSelect); //search the list

            obj.makeNoise(); //calls overrided method

            Console.WriteLine("");
        }

        /*
         * This function, uses an Animal object's name to find it within a list. Once found
         * the object's Age value is increase by 1.
         * 
         * @para Animal obj some Animal obj, used to store and access data of an Animal object
         * from the list
         * @para List<Animal> Animals the list of Animal objects
         * @pre obj must be a properly declare Animal object, and the user must input a valid
         * name of an animal object in the list
         * @post the Age value of an Animal object increases 1
         */
        static void ageFunct(Animal obj, List<Animal> Animals)
        {
            string usrSelect;

            Console.Write("Please Enter The Animal's Name: ");
            usrSelect = Console.ReadLine();
            Console.WriteLine("");

            obj = Animals.Find(x => x.name == usrSelect); //search the list

            obj.ageUp(); //calls overrided method

            //prompt for notifying that Age was increased
            Console.WriteLine("");
            Console.WriteLine(obj.name + "'s age is now: " + obj.age + " years old!"); 
            Console.WriteLine("");

        }

        /*
         * This function prints the entire list of Animal objects to console, along
         * with their type (i.e. they're concrete class type).
         * 
         * @para List<Animal> Animals the list of Animal objects
         * @pre There must be a non empty list of Animal objects.
         * 
         */
        static void printAll(List<Animal> Animals)
        {
            int count = 1;
            string animalType;

            foreach (Animal obj in Animals)
            {
                /*
                 * I added these conditionals in to make printAll look fancier,
                 * because only printing the names seemed too bland and calling 
                 * printInfo() created too much clutter on console. So, I went
                 * with printing an object's Name and Type.
                 */
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

                count++; //increase count by 1
            }

            Console.WriteLine("");
        }

    }
}
