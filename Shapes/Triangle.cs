using ShapesRFun.Bases;

namespace ShapesRFun.Shapes;


public class Triangle : AbstractShapeBase
{
    public Triangle(int baseLength, int height)
    {
        BaseLength = baseLength;
        Height = height;
        /*
        Dimensions = new Dictionary<string, int>
        {
            { "baseLength", baseLength },
            { "height", height }
        };
        */
    }

    public int BaseLength { get; set; }

    public int Height { get; set; }

    public override int GetArea()
    {
        return (int)Math.Round((BaseLength * Height)/2.0);
    }

    public override int GetPerimeter()
    {
        return 3 * BaseLength;
    }

    public static string TellFunnyJoke()
    {
        return "What is a triangle’s favorite newspaper? The HypotoNews!";
    }

    public static List<string> DimensionNames = new List<string> { "baseLength", "height" };

    public static List<string> GetDimensionNames()
    {
        return DimensionNames;
    }
}


