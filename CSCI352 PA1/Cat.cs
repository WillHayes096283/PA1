/*
 * @file Cat.cs
 * @author William Hayes
 * @date 1/18/2023
 * @brief This file implements the Animal class methods
 * 
 * This file implements the Animal class methods for the
 * Cat class.
 */
using System;

public class Cat : Animal
{
    public override void nAnimal(string nStr, int aNum, int wNum)
    {
        name = nStr;
        age = aNum;
        noise = "Meow!";
        weight = wNum;
    }

    public override void printInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight + " pounds");
    }

    public override void makeNoise()
    {
        Console.WriteLine(name + ", the cat goes: " + noise);
    }

    public override void ageUp()
    {
        age = age + 1;
    }
