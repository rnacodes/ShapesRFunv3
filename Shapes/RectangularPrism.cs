using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
namespace ShapesRFun.Shapes;

public class RectangularPrism : AbstractShapeBase, IGetVolume
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public RectangularPrism(int height, int width, int depth) : base(new Dictionary<string, int>
    {
        { "height", height },
        { "width", width },
        { "depth", depth }
    })
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

    public static string RectangleMagicNumber()
    {
        return "The answer to all questions is 42.";
    }

    public int DoubleArea()
    {
        return GetArea() * 2;
    }

    public int HalveArea()
    {
        return GetArea() / 2;
    }
}

