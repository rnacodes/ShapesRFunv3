using ShapesRFun.Bases;
namespace ShapesRFun.Shapes;
//Circle - simple shape
//Inherits from AbstractShapeBase class
//Has dimension property and ability to calculate area from the AbstractShapeBase class
//ImpleMENTS IGetPerimeter interface

public class Circle : AbstractShapeBase
{
    //Circle properties
    public int Radius { get; set; }

    //Circle constructor
    public Circle(int radius)
    {
        Radius = radius;
        //Dimensions = new Dictionary<string, int> { { "radius", radius } };
    }

    public int Diameter {
        get { return Dimensions["radius"] * 2; }
    }

    public override int GetArea()
    {
        return (int)(Math.PI * Math.Pow(Dimensions["radius"], 2));
    }

    public override int GetPerimeter()
    {
        return (int)(2 * Math.PI * Dimensions["radius"]);
    }

    public static List<string> DimensionNames = new List<string> { "radius" };

    public static List<string> GetDimensionNames()
    {
        return DimensionNames;
    }

    /*
    public new Dictionary<string, int> GetDimensions()
        {
            return Dimensions;
        }
    */

    public static string TellFunnyJoke()
    {
        return "Circles are pointless. Now that's a well rounded joke. Not edgy or anything.";
    }
}



