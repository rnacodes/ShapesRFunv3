using ShapesRFun.Bases;

internal class Triangle : SpecialShapeBase
{
    public override int GetArea()
    {
        return (int)Math.Round((Dimension * Dimension2)/2.0);
    }

    public static void TriangleSpecial ()
    {
        Console.WriteLine("What is a triangle’s favorite newspaper? The HypotoNews!");
    }

}


