using ShapesRFun.Interfaces;
namespace ShapesRFun.Bases;

//This is the basic template for all shapes
//It contains the Dimension property, the GetArea method
//The abstract class ShapeBase implements the ICalculateArea interface
public abstract class ShapeBase : ICalculateArea
    {
        // Property for size
        public int Dimension { get; set; }

        // Abstract method for getting the area that is inherited from the ICalculateArea interface
        public abstract int GetArea();


    /* UPDATE THIS ONCE IGETPERIMETER IS ADDED
        // Abstract method for getting the perimeter that is inherited from the IGetPerimeter interface
        public virtual int GetPerimeter()
        {
            return 4 * Dimension;
        }
    */
}

