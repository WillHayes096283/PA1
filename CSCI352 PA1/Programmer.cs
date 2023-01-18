/*
* @file Programmer.cs
* @author William Hayes
* @date 1/18/2023
* @brief
* 
* 
*/
using System;

public class Programmer : Animal
{
    public override void nAnimal(string nStr, int aNum, int wNum)
    {
        name = nStr;
        age = aNum;
        noise = "Hello World!";
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
        Console.WriteLine(name + ", the programmer goes: " + noise);
    }

    public override void ageUp()
    {
        age = age + 1;
    }

}