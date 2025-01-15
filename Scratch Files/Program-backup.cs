/* using ShapesRFun.Bases;

namespace ShapesRFun;
internal class Program
{
    static void Main()
    {
        //Initialize variables for first shape
        int area = 0;
        string shapeToBuild = "";
        int shapeSize1 = 0;
        int shapeSize2 = 0;

        Console.WriteLine("Welcome to the shape builder! Which shape can I make for you today?");

        //Ask user for shape to build -> converted to lowercase for standardization

        //Validate input
        while (true)
        {
            try
            {
                shapeToBuild = Console.ReadLine();
                shapeToBuild = shapeToBuild.ToLower();

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

        //Ask user for first dimension of shape 
        //For simple shapes - secondShapeSize2 is length for square and radius for circle
        //For simplification purposes, these are treated as a single dimension without a unit of measurement
        //If a number can be found in input, it is assigned to the variable secondShapeSize2
        Console.WriteLine("Thank you for choosing a " + shapeToBuild + "! What size would you like the shape to be?");

        while (true)
        {
            try
            {
                shapeSize1 = int.Parse(Console.ReadLine());
                break;
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        //This sets up the program to handle more complex shapes with two dimensions
        //The second dimension is height for rectangle and base for triangle
        //Triangle is assumed to be equilateral or isoceles

        if (shapeToBuild == "rectangle" || shapeToBuild == "triangle")
        {
            Console.WriteLine("What is the second dimension of the " + shapeToBuild + "?");
            while (true) {
                try {
                    shapeSize2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        Console.WriteLine("Thank you! I will now calculate the area of the shape.");

        Thread.Sleep(500);

        Console.WriteLine("Calculating.....................");

        if (shapeToBuild == "square" || shapeToBuild == "circle")
        {
            area = ProgramHelpers.GetShapeInfo(shapeToBuild, shapeSize1);
        } else
        {
            area = ProgramHelpers.GetShapeInfo(shapeToBuild, shapeSize1, shapeSize2);
        }
        Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");

        Thread.Sleep(500);

        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another shape. Otherwise enter 'No.'");
        string secondShapeAnswer = Console.ReadLine();
        secondShapeAnswer = secondShapeAnswer.ToLower();

        if (secondShapeAnswer == "no")
        {
            PickFunTrick();
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
            secondShapeArea = ProgramHelpers.GetShapeInfo(secondShapeToBuild, secondShapeSize1, secondShapeSize2);
        } else
        {
            secondShapeArea = ProgramHelpers.GetShapeInfo(secondShapeToBuild, secondShapeSize1);
        }

        //Instantiation of AddShapes class to add the area of two shapes together
        AddShapes addShapesInstantiation = new();
        combinedShapeArea = addShapesInstantiation.AddShapesHere(area, secondShapeArea);

        Thread.Sleep(500);
        Console.WriteLine("Calculating combined area.....................");

        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");

        Thread.Sleep(500);
    }
    
private static void PickFunTrick()
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

*/