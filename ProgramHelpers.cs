using ShapesRFun.Bases;
using System;
using ShapesRFun.Interfaces;
namespace ShapesRFun;

//This file contains the methods that build the shapes and calculate their areas
//These are methods needed for the program to run, but are separated from the UI
public class ProgramHelpers
    {

    //CreateShape creates a shape based on the dimensions provided by the user.
    //The method can take three arguments: the shape to build, the first dimension, and the second dimension
    //For the more complex shapes, the second dimension is required
    public static int CreateShape(string shapeToBuild, int shapeSize, int shapeSize2 = 0)
    {
        int area = 0;

        switch (shapeToBuild)
        {
            case "circle": //Circle is regular shape
                Circle circleShape = new Circle();
                circleShape.Dimension = shapeSize;
                area = circleShape.GetArea();
                break;
            case "square": //Square is regular shape
                Square squareShape = new Square();
                squareShape.Dimension = shapeSize;
                area = squareShape.GetArea();
                //squareShape.GetPerimeter();
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
    public static void DoFunTrick(string funTrickResponse)
    {
        switch (funTrickResponse)
        {
            case "no":
                Console.WriteLine("You're not very much fun at parties, are you?");
                break;
            case "triangle":
                //Triangle triangleJoke = new Triangle();
                Triangle.TriangleSpecial();
                break;
            case "rectangle":
                //Rectangle rectangleJoke = new Rectangle();
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
        }
    }

    //Generates a random number between 1 and 20
    public static int GetRando()
    {
        Random rando = new Random();
        return rando.Next(1, 21);
    }
    /// //ADD IN SHAPE JOKE LATER <summary>
    /*

    public static string TellShapeJoke(string shapeToBuild)
    {
        string joke = "";
        switch (shapeToBuild)
        {
            case "square":
                Square squareJoke = new Square();
                joke = squareJoke.SquareSpecial();
                break;
            case "triangle":
                Triangle triangleJoke = new Triangle();
                triangleJoke.TriangleSpecial();
                break;
            default:
                Console.WriteLine("I'm sorry, those shapes aren't very funny.");
                break;
        }
        return joke;
    }
    */

}


