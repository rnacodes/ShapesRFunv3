using ShapesRFun.Bases;
using ShapesRFun.Interfaces;

public class Rectangle : SpecialShapeBase, IChangeShapes
    {
    // Implement any additional members or override methods here
    public override int GetArea()
    {
        return Dimension * Dimension2;
    }

    internal int GimmeNumber()
    {
        return 42;
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
