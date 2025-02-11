using System.Drawing;
using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
using ShapesRFun.Shapes;

namespace ShapesRFun;

//This file contains the methods that build the shapes and calculate their areas
//These are methods needed for the program to run, but are separated from the UI
public class ProgramHelpers
{

    private static readonly Dictionary<string, List<string>> allShapeDimensions = new Dictionary<string, List<string>>
    {
        {"circle", Circle.GetDimensionNames()},
        {"triangle", Triangle.GetDimensionNames()},
        {"rectangular prism", RectangularPrism.GetDimensionNames()},
        {"tesseract", Tesseract.GetDimensionNames()}
    };


    // Method to get the names of the shapes
    public static List<string> GetShapeNames()
    {
        return allShapeDimensions.Keys.ToList();
    }

    public static AbstractShapeBase CreateShapeFromUserInput(string shapeToBuild)
    {
        if (!allShapeDimensions.ContainsKey(shapeToBuild.ToLower()))
        {
            throw new ArgumentException("Invalid shape type.");
        }

        /*
        if (!allShapeDimensions.TryGetValue(shapeToBuild.ToLower(), out List<string> dimensionNames))
        {
            throw new ArgumentException("Invalid shape type.");
        }
        */

        List<string> dimensionNames = allShapeDimensions[shapeToBuild.ToLower()];

        for (int i = 0; i < dimensionNames.Count; i++)
        {
            Console.WriteLine($"What is the {dimensionNames[i]} of the {shapeToBuild}?");
            while (true)
            {
                try
                {
                    int dimension = int.Parse(Console.ReadLine());
                    dimensionNames.Add(dimension);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        return CreateShape(shapeToBuild, dimensions);
    }

    public static AbstractShapeBase CreateShape(string shapeToBuild, List<int> dimensions)
    {
        AbstractShapeBase userCreatedShape;

        switch (shapeToBuild.ToLower())
        {
            case "circle":
                userCreatedShape = new Circle(dimensions[0]);
                break;
            case "triangle":
                userCreatedShape = new Triangle(dimensions[0], dimensions[1]);
                break;
            case "rectangular prism":
                userCreatedShape = new RectangularPrism(dimensions[0], dimensions[1], dimensions[2]);
                break;
            case "tesseract":
                userCreatedShape = new Tesseract(dimensions[0], dimensions[1], dimensions[2], dimensions[3]);
                break;
            default:
                throw new ArgumentException("Invalid shape type.");
        }

        return userCreatedShape;
    }

    /*
     
    public static Dictionary<string, List<string>> GetAllShapeDimensions()
    {
        return allShapeDimensions;
    }
     
     * 
    ITellJokes liveComedian;
    string joke;

    
    public static string TellFunnyJoke(string shapeToBuild)
    {
        return TellFunnyJoke(shapeToBuild, liveComedian);
    }
    */

    /*
    public static string TellFunnyJoke(string shapeToBuild, ITellJokes liveComedian, string joke)
    {
        switch (shapeToBuild.ToLower())
        {
            case "circle":
            liveComedian = new Circle(5);
            joke = liveComedian.TellFunnyJoke();
                break;
            default:
                joke = "I'm sorry, I don't know any jokes about that shape.";
                break;

        }
        return joke;
    }

    */
    public static int GetShapeArea(AbstractShapeBase shape)
    {
        var areaHolder = shape.GetArea();
        return areaHolder;
    }


    //Generates a random number between 1 and 20
    public static int GetRando()
    {
        Random rando = new Random();
        return rando.Next(1, 21);
    }
}



/* //EXAMPLE SYNTAX BELOW///////////////////////////////////////
        
            public static int CreateShapeAndGetArea(string shapeToBuild, int shapeSize, int shapeSize2)
            {
                int area = 0;
                IGetArea tal; 

                switch (shapeToBuild)
                {
                    case "circle": 
                    tal = new Circle(shapeSize);
                    area = tal.GetArea();


                        
                        // In this syntax, all that needs to change is the shape name and the shape size

                        //Circle newShape = new Circle(shapeSize);
                        break;
                        /*
                         THIS IS THE SYNTAX TAL AND I WERE DISCUSSING 
                        case "circle": //Circle is simple shape

                            //Circle circleShape = new Circle();
                            //circleShape.Dimension = shapeSize;
                            tal = new Circle(new List<int> {shapeSize});
                            area = tal.GetArea();
                            break;
                        case "square": //Square is simple shape
                            Square squareShape = new Square();
                            squareShape.Dimension = shapeSize;
                            area = squareShape.GetArea();
                            break;
                        
           
        case "rectangle": //Rectangle is complex shape
            Rectangle rectangleShape = new Rectangle();
            //tal = new Rectangle(new List<int> { shapeSize, shapeSize2 });
            //rectangleShape.Dimension = shapeSize;
            //rectangleShape.Dimension2 = shapeSize2;
            //area = tal.GetArea();
            break;
        case "triangle": //Triangle is complex shape
            Triangle triangleShape = new Triangle();
            triangleShape.Dimension = shapeSize;
            triangleShape.Dimension2 = shapeSize2;
            area = triangleShape.GetArea();
            break;

        }
        //return tal.GetArea(); 
        //return 0; 
        return area;
        }

    /*
    public static List<string> GetFirstValues()
    {
        return allShapeDimensions.Values.Select(dimensions => dimensions.First()).ToList();
    }
    */



