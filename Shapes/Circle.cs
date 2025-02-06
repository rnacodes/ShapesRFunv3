using ShapesRFun.Bases;
using ShapesRFun.Interfaces;

namespace ShapesRFun.Shapes;
//Circle - simple shape
//Inherits from AbstractShapeBase class
//Has dimension property and ability to calculate area from the AbstractShapeBase class

public class Circle : AbstractShapeBase, ITellJokes
{
    //Circle properties
    public int Radius { get; set; }

    //Circle constructor
    public Circle(int radius)
    {
        Radius = radius;
    }

    public int Diameter {
        get { return Radius * 2; }
    }

    public override int GetArea()
    {
        return (int)(Math.PI * Math.Pow(Radius, 2));
    }

    public override int GetPerimeter()
    {
        return (int)(2 * Math.PI * Radius);
    }

    public static List<string> DimensionNames = new List<string> { "radius" };

    public static List<string> GetDimensionNames()
    {
        return DimensionNames;
    }

    public string TellFunnyJoke()
    {
        return "Circles are pointless. Now that's a well rounded joke. Not edgy or anything.";
    }
}



