using ShapesRFun.Shapes;

namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the shape builder!");

        Console.WriteLine("Which shape would you like me to build? You can choose from the following options:");

        // Print each value from ProgramHelpers.GetFirstValues()
        var shapeNames = ProgramHelpers.GetShapeNames();
        foreach (var shapeName in shapeNames)
        {
            Console.WriteLine($"{shapeName}");
        }

        var shapeToBuild = "";
        var shapeArea = 0;

        while (true)
        {
            try
            {
                shapeToBuild = Console.ReadLine().ToLower();

                //UPDATE WITH CURRENT LIST OF SHAPES

                if (!shapeNames.Contains(shapeToBuild))
                {
                    throw new InvalidInputException("Please enter a valid shape.");
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

        ProgramHelpers.CreateShapeFromUserInput(shapeToBuild);

        Console.WriteLine("Creating shape....................");
        Thread.Sleep(400);
        Console.WriteLine("Your "+ shapeToBuild + " has been created.");


        Console.WriteLine("Calculating area....................");
        Thread.Sleep(400);
        Console.WriteLine("The area of the " + shapeToBuild + " is " + shapeArea + ".");

        //////Console.WriteLine("The area of the " + shapeToBuild + " is " + shapeArea + ".");

        //var shapeArea1 = ProgramHelpers.CreateShapeAndGetArea(shapeToBuild, shapeSize, shapeSize2);
        //var shapeArea1 = ProgramHelpers.CreateShapeAndGetArea(shapeToBuild, shapeSize, shapeSize2);

        //Console.WriteLine("The area of the " + shapeToBuild + " is " + shapeArea1 + ".");

        /////var myClass = new Class1();

        /*
        
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
        */
    }
}


