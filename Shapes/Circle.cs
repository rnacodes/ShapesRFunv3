using ShapesRFun.Bases;

internal class Circle : SpecialShapeBase
{
    public override int GetArea()
    {
        return (int)(Math.PI * Dimension * Dimension);
    }

    public int GetPerimeter()
    {
        return (int)(2 * Math.PI * Dimension);
    }
}


