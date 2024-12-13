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
            case "circle":
                Circle circleShape = new Circle();
                circleShape.Dimension = shapeSize;
                area = circleShape.GetArea();
                break;
            case "square":
                Square squareShape = new Square();
                squareShape.Dimension = shapeSize;
                area = squareShape.GetArea();
                //squareShape.GetPerimeter();
                break;
            case "rectangle":
                Rectangle rectangleShape = new Rectangle();
                rectangleShape.Dimension = shapeSize;
                rectangleShape.Dimension2 = shapeSize2;
                area = rectangleShape.GetArea();
                rectangleShape.GimmeNumber();
                break;
            default:
                Console.WriteLine("That shape will be available in a future expansion pack!");
                break;
        }
            return area;
        }

    //This method adds the areas of two shapes together
    public static double AddShapes(ICalculateArea shape1, ICalculateArea shape2)
    {
        return shape1.GetArea() + shape2.GetArea();
    }
}


