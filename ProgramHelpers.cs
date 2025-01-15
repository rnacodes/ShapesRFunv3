namespace ShapesRFun;

//This file contains the methods that build the shapes and calculate their areas
//These are methods needed for the program to run, but are separated from the UI
public class ProgramHelpers
    {
    //GetShapeInfo creates a shape based on the dimensions provided by the user and performs method to calculate area for that shape.
    //The method can take three arguments: the shape to build, the first dimension, and the second dimension
    //For the more complex shapes, the second dimension is required
    public static (string shapeToBuild, int shapeSize, int ShapeSize2) GetShapeInfo(string shapeToBuild)
    {
        int shapeSize = 0;
        int shapeSize2 = 0;

        Console.WriteLine("What is the first dimension of the " + shapeToBuild + "?");

        //Validate input
        while (true)
        {
            try
            {
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


        while (true)
        {
            try
            {
                shapeSize = int.Parse(Console.ReadLine());
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
            while (true)
            {
                try
                {
                    shapeSize2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
        return (shapeToBuild, shapeSize, shapeSize2);
    }

public static int CreateShapeAndGetArea (string shapeToBuild, int shapeSize, int shapeSize2) {
        int area = 0;       
        switch (shapeToBuild)
        {
            case "circle": //Circle is simple shape
                Circle circleShape = new Circle();
                circleShape.Dimension = shapeSize;
                area = circleShape.GetArea();
                break;
            case "square": //Square is simple shape
                Square squareShape = new Square();
                squareShape.Dimension = shapeSize;
                area = squareShape.GetArea();
                break;
            case "rectangle": //Rectangle is complex shape
                Rectangle rectangleShape = new Rectangle();
                rectangleShape.Dimension = shapeSize;
                rectangleShape.Dimension2 = shapeSize2;
                area = rectangleShape.GetArea();
                break;
            case "triangle": //Triangle is complex shape
                Triangle triangleShape = new Triangle();
                triangleShape.Dimension = shapeSize;
                triangleShape.Dimension2 = shapeSize2;
                area = triangleShape.GetArea();
                break;
            default:
                Console.WriteLine("That shape will be available in a future expansion pack!");
                break;
        }
            return area; 
    }   
    
    public static void PickFunTrick()
    {
        Console.WriteLine("Would you like to see a fun trick? Enter the name of a shape to see their unique secrets!");
        while (true)
        {
            try
            {
                var funTrickResponse = Console.ReadLine().ToLower();
                DoFunTrick(funTrickResponse);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid shape.");
            }
        }
    }

    public static void DoFunTrick(string funTrickResponse)
    {
        switch (funTrickResponse)
        {
            case "no":
                Console.WriteLine("You're not very much fun at parties, are you?");
                break;
            case "triangle":
                string triangleFun = Triangle.TriangleSpecial();
                Console.WriteLine(triangleFun);
                break;
            case "rectangle":
                string rectangleFun = Rectangle.RectangleMagicNumber();
                Console.WriteLine(rectangleFun);
                break;
            case "circle":
                int perimeterNumber;
                Console.WriteLine("I can calculate perimeter for you. I'll pick a random size and calculate the perimeter.");
                Circle circleFun = new Circle();
                circleFun.Dimension = GetRando();
                Thread.Sleep(500);
                Console.WriteLine("Thinking.....................");
                Thread.Sleep(500);
                perimeterNumber = circleFun.GetPerimeter();
                Console.WriteLine("The perimeter of a circle with a radius of " + circleFun.Dimension + " is " + perimeterNumber + ".");
                break;
            case "square":
                Square squareFun = new Square();
                squareFun.Dimension = GetRando();
                int squareFunArea = squareFun.GetArea();
                Console.WriteLine("I change shapes just to hide in this place. I can perform magic on a square with the area of " + squareFunArea);
                Thread.Sleep(500);
                Console.WriteLine("Contemplating.....................");
                Thread.Sleep(500);
                int halfArea = squareFun.HalveArea();
                int doubleArea = squareFun.DoubleArea();
                Console.WriteLine("The double area of the square is " + doubleArea + " and the half area of the square is " + halfArea + ".");
                break;
        }
    }

    //Generates a random number between 1 and 20
    public static int GetRando()
    {
        Random rando = new Random();
        return rando.Next(1, 21);
    }
    internal enum ShapeType
    {
        Square,
        Circle,
        Triangle,
        Rectangle
    }
}


