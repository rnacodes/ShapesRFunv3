namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the shape builder!");

        Console.WriteLine("Which shape would you like me to build? Enter square, circle, triangle or square.");

        var shapeToBuild = Console.ReadLine().ToLower();
        Thread.Sleep(500);
        //Use shape an

        Console.WriteLine("Thank you for choosing a " + shapeToBuild + "!");
        Thread.Sleep(400);

        (shapeToBuild, int shapeSize, int shapeSize2) = ProgramHelpers.GetShapeInfo(shapeToBuild);

        Console.WriteLine("Creating shape....................");
        Thread.Sleep(400);

        Console.WriteLine("Calculating area....................");
        Thread.Sleep(400);

        var area = ProgramHelpers.CreateShapeAndGetArea(shapeToBuild, shapeSize, shapeSize2);

        Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");

        //var shapeArea1 = ProgramHelpers.GetShapeInfo(shapeToBuild);


        Thread.Sleep(300);
        
        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another shape. Otherwise enter 'No.'");
        
        var secondShapeToBuild = Console.ReadLine().ToLower();

       if (secondShapeToBuild == "no")
        {
            ProgramHelpers.PickFunTrick();
            return;
        }

        var shapeArea2 = ProgramHelpers.GetShapeInfo(secondShapeToBuild);

        //Instantiation of AddShapes class to add the area of two shapes together
        
        /*
        AddShapes addShapesInstantiation = new();
        var combinedShapeArea = addShapesInstantiation.AddShapesHere(shapeArea1, shapeArea2);

        Thread.Sleep(300);

        Console.WriteLine("Calculating combined area.....................");

        Thread.Sleep(300);

        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");

        Thread.Sleep(300);

        ProgramHelpers.PickFunTrick();
        */
    }
    }


