namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the shape builder!");

        Console.WriteLine("Which shape would you like me to build? Enter square, circle, triangle or rectangle.");

        var shapeToBuild = "";
        
        while (true)
        {
            try
            {
                shapeToBuild = Console.ReadLine().ToLower();
                
                if (shapeToBuild != "square" && shapeToBuild != "circle" && shapeToBuild != "rectangle" && shapeToBuild != "triangle")
                {
                    throw new InvalidInputException("Please enter a valid shape (square, circle, rectangle, triangle).");
                }
                break;
            }

            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Thread.Sleep(200);

        Console.WriteLine("Thank you for choosing a " + shapeToBuild + "!");
        Thread.Sleep(200);

        (shapeToBuild, int shapeSize, int shapeSize2) = ProgramHelpers.GetShapeInfo(shapeToBuild);

        Console.WriteLine("Creating shape....................");
        Thread.Sleep(400);

        Console.WriteLine("Calculating area....................");
        Thread.Sleep(400);

        var shapeArea1 = ProgramHelpers.CreateShapeAndGetArea(shapeToBuild, shapeSize, shapeSize2);

        Console.WriteLine("The area of the " + shapeToBuild + " is " + shapeArea1 + ".");

        Thread.Sleep(300);
        
        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another shape. Otherwise enter 'No.'");
        
        var secondShapeToBuild = Console.ReadLine().ToLower();

        if (secondShapeToBuild == "no")
            {
                Thread.Sleep(200);
                ProgramHelpers.PickFunTrick();
                return;
            }

        (secondShapeToBuild, int secondShapeSize1, int secondShapeSize2) = ProgramHelpers.GetShapeInfo(secondShapeToBuild);
        Console.WriteLine("Creating second shape and calculating area....................");
        Thread.Sleep(300);

        var shapeArea2 = ProgramHelpers.CreateShapeAndGetArea(secondShapeToBuild, secondShapeSize1, secondShapeSize2);

        //Instantiation of AddShapes class to add the area of two shapes together       
        AddShapes addShapesInstantiation = new();
        var combinedShapeArea = addShapesInstantiation.AddShapesHere(shapeArea1, shapeArea2);

        Thread.Sleep(300);

        Console.WriteLine("The area of the " + secondShapeToBuild + " is " + shapeArea2 + ".");
        Console.WriteLine("Calculating combined area.....................");

        Thread.Sleep(300);


        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");

        Thread.Sleep(300);
        
        ProgramHelpers.PickFunTrick();       
    }
}


