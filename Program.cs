using ShapesRFun.Bases;

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

        //ADD in try/catch for null input

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
        } //This closes the first while loop

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
            };
            break;
            /*
            catch ()
            {

            }
            */
        } //Closes the second while loop


        

        //This sets up the program to handle more complex shapes with two dimensions
        //The second dimension is height for rectangle and base for triangle
        //Triangle is assumed to be equilateral or isoceles
        

        if (shapeToBuild == "rectangle" || shapeToBuild == "triangle")
        {
            Console.WriteLine("What is the second dimension of the " + shapeToBuild +"?");
            shapeSize2 = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Thank you! I will now calculate the area of the shape.");

        Thread.Sleep(500);

        Console.WriteLine("Calculating.....................");

        if (shapeToBuild == "square" || shapeToBuild == "circle")
        {
            area = ProgramHelpers.CreateShape(shapeToBuild, shapeSize1);
            //Environment.Exit(0);
        } else
        {
            area = ProgramHelpers.CreateShape(shapeToBuild, shapeSize1, shapeSize2);
        }
        Console.WriteLine("The area of the " + shapeToBuild + " is " + area + ".");

        Thread.Sleep(500);

        Console.WriteLine("Would you like to add another shape to this one? If so, please enter another.");

        string secondShapeToBuild = Console.ReadLine();
        secondShapeToBuild = secondShapeToBuild.ToLower();
        int secondShapeSize1 = 0;
        int secondShapeSize2 = 0;
        int secondShapeArea = 0;
        int combinedShapeArea = 0;

        Console.WriteLine("For Shape Number 2: What is the first dimension of the " + secondShapeToBuild + "?");

        secondShapeSize1 = int.Parse(Console.ReadLine());

        if (secondShapeToBuild == "rectangle" || secondShapeToBuild == "triangle")
        {
            Console.WriteLine("What is the second dimension of the " + secondShapeToBuild + "?");
            secondShapeSize2 = int.Parse(Console.ReadLine());
            secondShapeArea = ProgramHelpers.CreateShape(secondShapeToBuild, secondShapeSize1, secondShapeSize2);
        } else
        {
            secondShapeArea = ProgramHelpers.CreateShape(secondShapeToBuild, secondShapeSize1);
        }

        AddShapes addShapesInstantiation = new();
        combinedShapeArea = addShapesInstantiation.AddShapesHere(area, secondShapeArea);

        Thread.Sleep(500);
        Console.WriteLine("Calculating combined area.....................");

        Console.WriteLine("The combined area of the two shapes is " + combinedShapeArea + ".");

        

        /*
        Console.WriteLine("Would you like to hear a joke about your first shape?");
        string jokeAnswer = Console.ReadLine();
        ProgramHelpers.TellShapeJoke(shapeToBuild);
        */

        // string jokeShape = Console.ReadLine();
        // jokeShape = jokeShape.ToLower();

        //Console.WriteLine("What is the name of the shape you would like a joke for?");




    }

}
