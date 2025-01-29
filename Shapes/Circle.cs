using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
//Circle - simple shape
//Inherits from AbstractShapeBase class
//Has dimension property and ability to calculate area from the AbstractShapeBase class
//ImpleMENTS IGetPerimeter interface

public class Circle : AbstractShapeBase, IGetPerimeter
{
    //Circle properties
    public int Radius { get; set; }
    public int Diameter { get; set; }

    //Circle constructor
    public Circle(int radius) : base(new Dictionary<string, int> { { "radius", radius }, { "diameter", radius * 2 } })
    {
        Radius = radius;
        Diameter = radius * 2;
        Area = GetArea();
        Perimeter = GetPerimeter();

    }

    public override int GetArea()
    {
        return (int)(Math.PI * Math.Pow(Dimensions["radius"], 2));
    }

    public override int GetPerimeter()
    {
        return (int)(2 * Math.PI * Dimensions["radius"]);
    }
}



