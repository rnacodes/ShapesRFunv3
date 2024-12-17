using ShapesRFun.Bases;

internal class Triangle : SpecialShapeBase
{
    public override int GetArea()
    {
        return (int)(Dimension * Dimension2)/2;
    }

    public void TriangleSpecial ()
    {
        Console.WriteLine("What is a triangle’s favorite newspaper? The HypotoNews!");
    }

}


