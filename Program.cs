namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the shape builder!");

        Console.WriteLine("Which shape would you like me to build? Enter square, circle, triangle or square.");

        var shapeToBuild = Console.ReadLine().ToLower();

        var shapeArea1 = ProgramHelpers.CreateShape(shapeToBuild);

        Console.WriteLine("The area of the " + shapeToBuild + " is " + shapeArea1 + ".");
        
        Thread.Sleep(300);
        
        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another shape. Otherwise enter 'No.'");
        
        var secondShapeToBuild = Console.ReadLine().ToLower();

       if (secondShapeToBuild == "no")
        {
            ProgramHelpers.PickFunTrick();
            return;
        }

        var shapeArea2 = ProgramHelpers.CreateShape(secondShapeToBuild);

        //Instantiation of AddShapes class to add the area of two shapes together
        AddShapes addShapesInstantiation = new();
        var combinedShapeArea = addShapesInstantiation.AddShapesHere(shapeArea1, shapeArea2);

        Thread.Sleep(300);

        Console.WriteLine("Calculating combined area.....................");

        Thread.Sleep(300);

        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");

        Thread.Sleep(300);

        ProgramHelpers.PickFunTrick();

    }
    }


