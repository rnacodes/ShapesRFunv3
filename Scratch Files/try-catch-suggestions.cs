
//THIS IS JUST FOR TEST CODE
/*
using ShapesRFun.Bases;

namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        int area = 0;
        string shapeToBuild = "";
        int shapeSize1 = 0;
        int shapeSize2 = 0;

        Console.WriteLine("Welcome to the shape builder! Which shape can I make for you today?");

        // Loop for shapeToBuild input
        while (true)
        {
            try
            {
                // Ask user for shape to build
                // Shape name is converted to lowercase for standardization
                // User's input to shapeToBuild determines which shape ShapeBuilder will create
                shapeToBuild = Console.ReadLine();
                shapeToBuild = shapeToBuild.ToLower();

                // Validate input
                if (shapeToBuild != "square" && shapeToBuild != "circle" && shapeToBuild != "rectangle" && shapeToBuild != "triangle")
                {
                    throw new InvalidShapeException("Invalid shape entered. Please enter a valid shape (square, circle, rectangle, triangle).");
                }
                break;
            }
            catch (InvalidShapeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Loop for shapeSize1 input
        while (true)
        {
            try
            {
                Console.WriteLine("Thank you for choosing a " + shapeToBuild + "! What size would you like the shape to be?");
                shapeSize1 = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Loop for shapeSize2 input if needed
        if (shapeToBuild == "rectangle" || shapeToBuild == "triangle")
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the second dimension of the " + shapeToBuild + "?");
                    shapeSize2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        Console.WriteLine("Thank you! I will now calculate the area of the shape.");

        Thread.Sleep(500);

        Console.WriteLine("Calculating.....................");

        if (shapeToBuild == "square" || shapeToBuild == "circle")
        {
            area = ProgramHelpers.GetShapeInfo(shapeToBuild, shapeSize1);
        }
        else
        {
            area = ProgramHelpers.GetShapeInfo(shapeToBuild, shapeSize1, shapeSize2);
        }
        Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");

        Thread.Sleep(500);

        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another.");

        string secondShapeToBuild = "";
        int secondShapeSize1 = 0;
        int secondShapeSize2 = 0;
        int secondShapeArea = 0;
        int combinedShapeArea = 0;

        // Loop for secondShapeToBuild input
        while (true)
        {
            try
            {
                secondShapeToBuild = Console.ReadLine();
                secondShapeToBuild = secondShapeToBuild.ToLower();

                // Validate input
                if (secondShapeToBuild != "square" && secondShapeToBuild != "circle" && secondShapeToBuild != "rectangle" && secondShapeToBuild != "triangle")
                {
                    throw new InvalidShapeException("Invalid shape entered. Please enter a valid shape (square, circle, rectangle, triangle).");
                }
                break;
            }
            catch (InvalidShapeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Loop for secondShapeSize1 input
        while (true)
        {
            try
            {
                Console.WriteLine("For Shape Number 2: What is the first dimension of the " + secondShapeToBuild + "?");
                secondShapeSize1 = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Loop for secondShapeSize2 input if needed
        if (secondShapeToBuild == "rectangle" || secondShapeToBuild == "triangle")
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the second dimension of the " + secondShapeToBuild + "?");
                    secondShapeSize2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        if (secondShapeToBuild == "rectangle" || secondShapeToBuild == "triangle")
        {
            secondShapeArea = ProgramHelpers.GetShapeInfo(secondShapeToBuild, secondShapeSize1, secondShapeSize2);
        }
        else
        {
            secondShapeArea = ProgramHelpers.GetShapeInfo(secondShapeToBuild, secondShapeSize1);
        }

        AddShapes addShapesInstantiation = new();
        combinedShapeArea = addShapesInstantiation.AddShapesHere(area, secondShapeArea);

        Thread.Sleep(500);
        Console.WriteLine("Calculating combined area.....................");

        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");
    }
}

public class InvalidShapeException : Exception
{
    public InvalidShapeException(string message) : base(message)
    {
    }
}

*/
