/*
 * @file Animal.cs
 * @author William Hayes
 * @date 1/18/2023
 * @brief This file declares the abstract Animal class.
 * 
 * This file declares the data members and abstract operations
 * for the Animal class. Implementation will be handled by the
 * concrete classes.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI352_PA1
{
 /*
 * This is the abstract Animal class, it declares members like
 * an animal's name, their age, the noise they make, and their
 * weight, and declares abstract operators that will allow
 * interaction with these members.
 * 
 * @class Animal Animal.cs
 * @brief Abstract class that declares data members and methods.
 */

    public abstract class Animal
    {
        //data members

        private string Name;

        private int Age;

        private string Noise;

        private int Weight;

        //abstract operations below

        /*
         * This method assigns information to an Animal object.
         * 
         * @para string nStr this is the string for the Animal object's new name
         * @para int aNum this integer is the Animal object's new age
         * @para int wNum this integer is the Animal object's new weight
         * @pre there needs to be a properly declared animal object
         * @post changes the Animal object's name = nStr, age = aNum, and weight = wNum
         * 
         */
        public abstract void nAnimal(string nStr, int aNum, int wNum);

        /*
         * This method prints info (name, age, and weight) on a specific Animal object.
         * 
         * @pre there needs to be a properly declared animal object
         *
         */
        public abstract void printInfo();

        /*
         * This method prints an Animal object's noise to console.
         * 
         * @pre there needs to be a properly declared animal object
         */
        public abstract void makeNoise();

        /*
         * This method increases an Animal object's age by 1.
         * 
         * @pre there needs to be a properly declared animal object
         */
        public abstract void ageUp();


        //setters and getters below

        /*
         * This method acts as an accessor and mutator for the Age member, returning and reassigning an
         * Animal object's Age value.
         * 
         * @pre there needs to be a properly declared Animal object
         * @return int returns the Age integer value
         * @post assigns some value to Age
         */
        public int age
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }

        }

        /*
         * This method acts as an accessor and mutator for the Name member, returning and reassigning an
         * Animal object's Name string.
         * 
         * @pre there needs to be a properly declared Animal object
         * @return string returns the Name string
         * @post assigns some value to Name
         */
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        /*
         * This method acts as an accessor and mutator for the Noise member, returning and reassigning an
         * Animal object's Noise string.
         * 
         * @pre there needs to be a properly declared Animal object
         * @return string returns the Noise string
         * @post assigns some value to Noise
         */
        public string noise
        {
            get
            {
                return Noise;
            }

            set
            {
                Noise = value;
            }
        }

        /*
         * This method acts as an accessor and mutator for the Weight member, returning and reassigning an
         * Animal object's Weight value.
         * 
         * @pre there needs to be a properly declared Animal object
         * @return int returns the Weight integer value
         * @post assigns some value to Weight
         */
        public int weight
        {
            get
            {
                return Weight;
            }

            set
            {
                Weight = value;
            }
        }
    }
}