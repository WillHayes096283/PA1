using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI352_PA1
{
    class Animal
    {
    }
}
/*
 * @file Animal.cs
 * @author William Hayes
 * @date 1/18/2023
 * @brief This file declares the abstract Animal class
 * 
 * This file declares the data members and abstract operations
 * for the Animal class. Implementation will be handled by the
 * concrete classes.
 */

/*
 * This is the abstract Animal class, it declares members like
 * an animal's name, their age, the noise they make, and their
 * weight, and declares abstract operators that will allow
 * interaction with these members.
 * 
 */
public abstract class Animal
{
    //data members

    private string Name;

    private int Age;

    private string Noise;

    private int Weight;

    //abstract operations below


    public abstract void nAnimal(string nStr, int aNum, int wNum);

    public abstract void printInfo();

    public abstract void makeNoise();

    public abstract void ageUp();


    //setters and getters below

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