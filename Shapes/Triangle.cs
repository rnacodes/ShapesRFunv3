using ShapesRFun.Bases;
using ShapesRFun.Interfaces;    

namespace ShapesRFun.Shapes;


public class Triangle : AbstractShapeBase, ITellJokes
{
    public Triangle(int baseLength, int height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public int BaseLength { get; set; }

    public int Height { get; set; }

    public override int GetArea()
    {
        return (int)Math.Round((BaseLength * Height) / 2.0);
    }

    public override int GetPerimeter()
    {
        return 3 * (BaseLength + Height * 2);
    }

    public string TellFunnyJoke()
    {
        return "What is a triangle’s favorite newspaper? The HypotoNews!";
    }

    private static readonly List<string> DimensionNames = new List<string> { "length of base", "height" };

    public static List<string> GetDimensionNames()
    {
        return DimensionNames;
    }
}


