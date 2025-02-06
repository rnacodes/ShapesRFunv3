using ShapesRFun.Bases;
using ShapesRFun.Shapes;

namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the shape builder!");

        Console.WriteLine("Which shape would you like me to build? You can choose from the following options:");

        var shapeNames = ProgramHelpers.GetShapeNames();
        foreach (var shapeName in shapeNames)
        {
            Console.WriteLine($"{shapeName}");
        }

        var shapeToBuildName = "";
        var shapeArea = 0;
        AbstractShapeBase userCreatedShape;

        while (true)
        {
            try
            {
                shapeToBuildName = Console.ReadLine().ToLower();

                //UPDATE WITH CURRENT LIST OF SHAPES

                if (!shapeNames.Contains(shapeToBuildName))
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

        Console.WriteLine("Thank you for choosing a " + shapeToBuildName + "!");
        Thread.Sleep(200);

        //Console.WriteLine("Creating shape....................");
        //Thread.Sleep(400);

        userCreatedShape = ProgramHelpers.CreateShapeFromUserInput(shapeToBuildName);

        Console.WriteLine("Your "+ shapeToBuildName + " has been created.");

        Console.WriteLine("Calculating area....................");
        Thread.Sleep(400);

        shapeArea = ProgramHelpers.GetShapeArea(userCreatedShape);

        Console.WriteLine("The area of the " + shapeToBuildName + " is " + shapeArea + ".");
        Thread.Sleep(300);

        /*
        Console.WriteLine("Would you like to hear a funny joke? Enter the name of a shape to see its specialty!");
        var funTrickResponse = Console.ReadLine().ToLower();
        ProgramHelpers.TellFunnyJoke(funTrickResponse);
        */

        //////Console.WriteLine("The area of the " + shapeToBuildName + " is " + shapeArea + ".");

        //var shapeArea1 = ProgramHelpers.CreateShapeAndGetArea(shapeToBuildName, shapeSize, shapeSize2);
        //var shapeArea1 = ProgramHelpers.CreateShapeAndGetArea(shapeToBuildName, shapeSize, shapeSize2);

        //Console.WriteLine("The area of the " + shapeToBuildName + " is " + shapeArea1 + ".");

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


