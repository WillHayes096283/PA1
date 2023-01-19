# Programming Assignment 1

* **Name:** William Hayes
* **Date:** 1/19/2023

This program is for the Programming Assignment 1 for CSCI 352. It allows the user interact with a list of Animal class objects in a various ways: adding a new object to the list, print infomation (an animal's name, age, and weight) of an object from the list, have an animal from the list make a noise, increase the age of animal from the list, and print the entire list to console.

## Animal Class
This class is an abstract class that declares data members and abstract methods that will be used by and implemented by the program's concrete classes.

## Cat, Cassowary, and Programmer Class
These classes are the concrete classes, they implement the abstract methods/operations of the Animal Class.

## Menu Interaction
This program use menu driven interaction to interact with the list in various ways. Here is an image of said menu:

![Screenshot (1)](https://user-images.githubusercontent.com/97753129/213544423-279e049a-f0db-43ec-bdfc-d182259e790a.png)

Simply, enter the characters: 1, 2, 3, 4, 5, and q to select the various options, and enter any other required information/inputs.

## Notes
* I thought about adding checks for the user input to see if the list was empty or if the name they entered existed in the list. However, given that this is supposed to be a short warm-up assignment, I decided not to and to trust that the user knows what they are doing for simplicity.
* I did add a printAll method as an extra function for the program, since it was fairly simple to include.
* I didn't include a default constructor, since the user will input any required info for any newly created class objects.
* The was some issues in connecting to the repo through visual studio which slowed down implementation and coding. Ultimately, I was able to figure things out just in time to finish adding in documentation.
* Another issue was implement code that interacted with elements of the List<Animal>. I had to rely on Microsoft's tutorials on C# but even then the program was still throwing errors, so I had to rely on pure trial and error at one point. Thankfully the code is now working properly.
* In order to get the concrete class methods to work properly, I had to add accessors and mutators for the private Animal class members.
