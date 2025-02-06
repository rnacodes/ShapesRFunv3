using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
namespace ShapesRFun.Shapes;


public class Tesseract : ThreeDPlusShapeBase
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }

    public int WDimension { get; set; }
    public Tesseract(int height, int width, int depth, int wDimension)
    {
        Height = height;
        Width = width;
        Depth = depth;
        WDimension = wDimension;
    }

    //Change this dictionary to match the properties of the Circle base
    public static List<string> DimensionNames = new List<string> { "height", "width", "depth", "w-dimension" };

    public static List<string> GetDimensionNames()
    {
        return DimensionNames;
    }

    public override int GetArea()
    {
        return 4 * (Height * Width * Depth * WDimension);
    }

    public override int GetVolume()
    {
        return Height * Width * Depth;
    }

    public static string RectangleMagicNumber()
    {
        return "The answer to all questions is 42.";
    }

    public override int GetPerimeter()
    {
        return 8 * (Height + Width + Depth + WDimension);
    }
}