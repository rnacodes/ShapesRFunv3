using ShapesRFun.Bases;

internal class Triangle : SpecialShapeBase
{
    public override int GetArea()
    {
        return (int)(Math.PI * Dimension * Dimension);
    }


}


