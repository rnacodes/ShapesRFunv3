using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
//Circle - simple shape
//Inherits from AbstractShapeBase class
//Has dimension property and ability to calculate area from the AbstractShapeBase class
//Implenets IGetPerimeter interface

public class Circle(Dictionary<string, int> dimensions) : AbstractShapeBase, IGetPerimeter
{
    //Circle constructor
    public Circle : base(new )


    /*
    public Circle(IList<int> dimensions) : base(dimensions)
    {
    }
    */


    public override int GetArea()
    {
        return (int)(Math.PI * Math.Pow(DimensionSize[0], 2));
    }
    public override int GetPerimeter()
    {
        return (int)(2 * Math.PI * DimensionSize[0]);
    }
}

    /*
    public override int GetArea()
    {
        return (int)(Math.PI * (Dimensions.FirstOrDefault() ^2));
    }


    public int GetPerimeter()
    {
        return (int)(2 * Math.PI * Dimensions.FirstOrDefault());
    }
    
    */



