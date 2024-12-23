﻿using ShapesRFun.Bases;
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
                //rectangleShape.GimmeNumber();
                break;
            case "triangle":
                Triangle triangleShape = new Triangle();
                triangleShape.Dimension = shapeSize;
                triangleShape.Dimension2 = shapeSize2;
                area = triangleShape.GetArea();
                //triangleShape.TriangleSpecial();
                break;
            default:
                Console.WriteLine("That shape will be available in a future expansion pack!");
                break;
        }
            return area;
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

    /*
    //This method adds the areas of two shapes together
    public static int AddShapes(int area, int secondShapeArea)
    {
        return Convert.ToInt32(area) + Convert.ToInt32(secondShapeArea);
    }
    */
}


