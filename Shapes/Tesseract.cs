using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
namespace ShapesRFun.Shapes;

/*
public class Tesseract : ThreeDPlusShapeBase, IGetVolume  
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
    public Tesseract(int height, int width, int depth, int wDimension) : base(new Dictionary<string, int>
    {
        { "height", height },
        { "width", width },
        { "depth", depth },
        { "wDimension", wDimension }
    })
    {
        Height = height;
        Width = width;
        Depth = depth;
        WDimension = wDimension;
    }

    public override int GetArea()
    {
        return 4 * (Height * Width * Depth * WDimension);
    }
   
    public int GetVolume()
    {
        return Height * Width * Depth;
    }

    public static string RectangleMagicNumber()
    {
        return "The answer to all questions is 42.";
    }

/*
public int DoubleArea()
{
    return GetArea() * 2;
}

public int HalveArea()
{
    return GetArea() / 2;
}

}

*/