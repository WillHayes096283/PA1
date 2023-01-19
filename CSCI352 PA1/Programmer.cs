/*
* @file Programmer.cs
* @author William Hayes
* @date 1/18/2023
* @brief This file implements the Animal class methods.
* 
* This file implements the Animal class methods for the
* Programmer class.
*/
using System;

namespace CSCI352_PA1
{

    /*
     * This is the concrete Programmer class, it implements the Animal class's abstract
     * operations/methods.
     * 
     * @class Programmer Programmer.cs
     * @brief Implements Animal class's declared methods.
    */

    public class Programmer : Animal
    {
        /*
         * This is the overrided aAnimal method. It assigns nStr to a Programmer object's Name,
         * assigns aNUm to a Programmer object's Age, assigns "Hello World!" as a Programmer 
         * object's Noise, and assigns wNum as a Programmer object's Weight.
         * 
         * @para string nStr the string being assigned to Name
         * @para int aNum the integer being assigned to Age
         * @para int wNum the integer being assigned to Weight
         * @pre there be needs to be a properly declared Programmer object
         * @post nStr is assigned to Name, aNum is assigned to Age,
         * noise equals "Hello World!", and wNum is assigned to Weight.
         * 
         */
        public override void nAnimal(string nStr, int aNum, int wNum)
        {
            name = nStr;
            age = aNum;
            noise = "Hello World!";
            weight = wNum;
        }

        /*
         * This is the overrided printInfo method, it prints a Programmer object's Name,
         * Age, and Weight information to console.
         * 
         * @pre there needs to be a properly declared Programmer object
         * 
         */
        public override void printInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight + " pounds");
        }

        /*
         * This is the overrided makeNoise method, it prints a Programmer object's Noise
         * to console.
         * 
         * @pre there needs to be a properly declared Programmer object
         * 
         */
        public override void makeNoise()
        {
            Console.WriteLine(name + ", the programmer goes: " + noise);
        }

        /*
         * This is the overrided ageUp method, it increases a Programmer object's Age value
         * by 1.
         * 
         * @pre there needs to be a properly declared Programmer object
         * @post increase Programmer object's Age by 1
         * 
         */
        public override void ageUp()
        {
            age = age + 1;
        }

    }
}