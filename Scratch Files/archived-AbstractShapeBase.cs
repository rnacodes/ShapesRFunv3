﻿using ShapesRFun.Interfaces;
namespace ShapesRFun.Bases;

//This is the basic template for all shapes
//It contains the Dimension property, the GetArea method
//The abstract class AbstractShapeBase implements the IGetArea interface

/*
public abstract class AbstractShapeBase : IGetArea
    {
    public AbstractShapeBase(IList<int> dimensions)
    {
        Dimensions = dimensions;
    }
    // Property for size
    public IList<int> Dimensions { get; }
*/
// Abstract method for getting the area that is inherited from the IGetArea interface
//public abstract int GetArea();


/* UPDATE THIS ONCE IGETPERIMETER IS ADDED
    // Abstract method for getting the perimeter that is inherited from the IAddShapes interface
    public virtual int GetPerimeter()
    {
        return 4 * Dimension;
    }

}

*/