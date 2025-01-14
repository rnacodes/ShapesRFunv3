﻿using ShapesRFun.Bases;

namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        //Initialize variables for first shape
        
        //int area = 0;
        //string shapeToBuild = "";
        //int shapeSize1 = 0;
        //int shapeSize2 = 0;
        

        Console.WriteLine("Welcome to the shape builder!");

        Console.WriteLine("Which shape would you like me to build? Enter square, circle, triangle or square.");

        var shapeToBuild = Console.ReadLine().ToLower();

        var shapeArea1 = ProgramHelpers.CreateShape(shapeToBuild);

        Console.WriteLine("The area of the " + shapeToBuild + " is " + shapeArea1 + ".");
        
        Thread.Sleep(300);
        
        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another shape. Otherwise enter 'No.'");
        
        var secondShapeToBuild = Console.ReadLine().ToLower();

        var shapeArea2 = ProgramHelpers.CreateShape(secondShapeToBuild);

        if (secondShapeToBuild == "no")
        {
            ShowFunTrick();
            return;
        }


        //Ask user for shape to build -> converted to lowercase for standardization





        /*
        Console.WriteLine("Calculating.....................");

        if (shapeToBuild == "square" || shapeToBuild == "circle")
        {
            area = ProgramHelpers.CreateShape(shapeToBuild, shapeSize1);
        } else
        {
            area = ProgramHelpers.CreateShape(shapeToBuild, shapeSize1, shapeSize2);
        }
        Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");

        Thread.Sleep(500);

        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another shape. Otherwise enter 'No.'");
        string secondShapeAnswer = Console.ReadLine();
        secondShapeAnswer = secondShapeAnswer.ToLower();

        if (secondShapeAnswer == "no")
        {
            ShowFunTrick();
            return;
        }

        var secondShapeToBuild = secondShapeAnswer;
        //string secondShapeToBuild = Console.ReadLine();
       // secondShapeToBuild = secondShapeToBuild.ToLower();

        //Initialize variables for second shape
        int secondShapeSize1 = 0;
        int secondShapeSize2 = 0;
        int secondShapeArea = 0;
        int combinedShapeArea = 0;

        Console.WriteLine("For Shape Number 2: What is the first dimension of the " + secondShapeToBuild + "?");


        while (true)
        {
            try
            {
                secondShapeSize1 = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (secondShapeToBuild == "rectangle" || secondShapeToBuild == "triangle")
        {
            Console.WriteLine("What is the second dimension of the " + secondShapeToBuild + "?");

            try
            {
                secondShapeSize2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            secondShapeArea = ProgramHelpers.CreateShape(secondShapeToBuild, secondShapeSize1, secondShapeSize2);
        } else
        {
            secondShapeArea = ProgramHelpers.CreateShape(secondShapeToBuild, secondShapeSize1);
        }

        //Instantiation of AddShapes class to add the area of two shapes together
        AddShapes addShapesInstantiation = new();
        combinedShapeArea = addShapesInstantiation.AddShapesHere(area, secondShapeArea);

        Thread.Sleep(500);
        Console.WriteLine("Calculating combined area.....................");

        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");

        Thread.Sleep(500);
        */
    }
    
private static void ShowFunTrick()
    {
        Console.WriteLine("Would you like to see a fun trick? Enter the name of a shape to see their unique secrets!");
        while (true)
        {
            try
            {
                string funTrickResponse = Console.ReadLine();
                funTrickResponse = funTrickResponse.ToLower();
                ProgramHelpers.DoFunTrick(funTrickResponse);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid shape.");
            }
        }
    }

    }


