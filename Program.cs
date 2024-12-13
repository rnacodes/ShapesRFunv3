﻿namespace ShapesRFun;



internal class Program
{
    static void Main()
    {
        int area = 0;
        Console.WriteLine("Welcome to the shape builder! Which shape can I make for you today?");

        //ADD in try/catch for null input

        //Ask user for shape to build
        //Shape name is converted to lowercase for standardization
        //User's input to shapeToBuild determines which shape ShapeBuilder will create
        string shapeToBuild = Console.ReadLine();

        shapeToBuild = shapeToBuild.ToLower();

        //Ask user for first dimension of shape 
        //For simple shapes - shapeSize1 is length for square and radius for circle
        //For simplification purposes, these are treated as a single dimension without a unit of measurement
        //If a number can be found in input, it is assigned to the variable shapeSize1
        Console.WriteLine("Thank you for choosing a " + shapeToBuild + "! What size would you like the shape to be?");

        int shapeSize1 = int.Parse(Console.ReadLine());

        //This sets up the program to handle more complex shapes with two dimensions
        //The second dimension is height for rectangle and base for triangle
        //Triangle is assumed to be equilateral or isoceles
        int shapeSize2 = 0;

        if (shapeToBuild == "rectangle" || shapeToBuild == "triangle")
        {
            Console.WriteLine("What is the second dimension of the " + shapeToBuild +"?");
            shapeSize2 = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Thank you! I will now calculate the area of the shape.");

        Thread.Sleep(1000);

        Console.WriteLine("Calculating.....................");

        if (shapeToBuild == "rectangle" || shapeToBuild == "circle")
        {
            area = ProgramHelpers.CreateShape(shapeToBuild, shapeSize1, shapeSize2);
        } else
            area = ProgramHelpers.CreateShape(shapeToBuild, shapeSize1);

        Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");
    }

}