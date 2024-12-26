using ShapesRFun.Bases;
//Circle - simple shape
//Inherits from ShapeBase class
//Has dimension property and ability to calculate area from the ShapeBase class
//Has special GetPerimeter class unique to its own class

public class Circle : ShapeBase
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


