namespace ShapesRFun.Bases;

//This is the basic template for all shapes
//It contains the Dimension property, the GetArea method
//The abstract class AbstractShapeBase implements the ICalculateArea interface

public abstract class AbstractShapeBase : ICalculateArea
{
    public AbstractShapeBase(Dictionary<string, int> dimensions)
    {
        Dimensions = dimensions;
    }

    // Property for size - name and number
    public Dictionary<string, int> Dimensions { get; set; }

    // Property for number of dimensions
    public abstract int TotalDimensions { get; }

    // Abstract method for getting the area that is inherited from the ICalculateArea interface
    public abstract int GetArea();
}

/* UPDATE THIS ONCE IGETPERIMETER IS ADDED
    // Abstract method for getting the perimeter that is inherited from the IAddShapes interface
    public virtual int GetPerimeter()
    {
        return 4 * Dimension;
    }

} */