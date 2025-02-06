using ShapesRFun.Interfaces;

namespace ShapesRFun.Bases;

//This is the basic template for all shapes
//It contains the Dimension property, the GetArea method
//The abstract class AbstractShapeBase implements the IGetArea interface

public abstract class AbstractShapeBase : IGetArea, IGetPerimeter
{
    public AbstractShapeBase()
    {
        Dimensions = new Dictionary<string, int> { };
    }

    public Dictionary<string, int> Dimensions { get; set; }

    public int Area { get; set; }

    public abstract int GetArea();

    public int Perimeter { get; set; }

    public abstract int GetPerimeter();

    public Dictionary<string, int> GetDimensions()
    {
        return Dimensions;
    }

    // Property for number of dimensions
    // This could get the number of dimensions from the length of AbstractShapeBase
    //public abstract int TotalDimensions { get; }

}