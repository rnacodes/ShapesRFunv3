namespace ShapesRFun.Bases;

//This is the basic template for all shapes
//It contains the Dimension property, the GetArea method
//The abstract class AbstractShapeBase implements the IGetArea interface

public abstract class AbstractShapeBase : IGetArea
{
    public AbstractShapeBase(Dictionary<string, int> dimensions)
    {
        Dimensions = dimensions;
    }

    // Property for size - name and number
    public Dictionary<string, int> Dimensions { get; set; }

    public int Area { get; set; }

    public abstract int GetArea();

    public int Perimeter { get; set; }

    public abstract int GetPerimeter();

    // Property for number of dimensions
    // This could get the number of dimensions from the length of AbstractShapeBase
    //public abstract int TotalDimensions { get; }

    // Abstract method for getting the area that is inherited from the IGetArea interface
    //public int GetArea();


}

/* UPDATE THIS ONCE IGETPERIMETER IS ADDED
    // Abstract method for getting the perimeter that is inherited from the IAddShapes interface
    public virtual int GetPerimeter()
    {
        return 4 * Dimension;
    }

} */