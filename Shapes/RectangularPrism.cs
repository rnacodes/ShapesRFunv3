using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
namespace ShapesRFun.Shapes;


public class RectangularPrism : AbstractShapeBase, ITellJokes
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public RectangularPrism(int height, int width, int depth)
    {
        Height = height;
        Width = width;
        Depth = depth;
    }
    public override int GetArea()
    {
        return 2 * (Height * Width + Height * Depth + Width * Depth);
    }
   
    public int GetVolume()
    {
        return Height * Width * Depth;
    }

    public string TellFunnyJoke()
    {
        return "So a rectangular prism walks into a bar And the bartender asks, \"Why the four long faces?\".";
    }

    public override int GetPerimeter()
    {
        return 4 * (Height + Width + Depth);
    }

    public static List<string> DimensionNames = new List<string> { "height", "width", "depth" };

    public static List<string> GetDimensionNames()
    {
        return DimensionNames;
    }

}