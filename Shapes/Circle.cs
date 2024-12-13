using ShapesRFun.Bases;

internal class Circle : SpecialShapeBase, IGetPerimeter
{
    public override int GetArea()
    {
        return (int)(Math.PI * Dimension * Dimension);
    }

    public override int GetPerimeter()
    {
        return (int)(2 * Math.PI * Dimension);
    }
}


