using ShapesRFun.Interfaces;

namespace ShapesRFun.Bases;
//SpecialShapeBase inherits from AbstractShapeBase
//This class is for creating shapes with a second dimension
//SpecialShapeBase inherits the Dimension property and the GetArea method from the AbstractShapeBase class
//SpecialShapeBase adds a property for depth and volume


public abstract class ThreeDPlusShapeBase : AbstractShapeBase
    {


    public ThreeDPlusShapeBase()
    {
    }

    public int Volume { get; set; }

    public abstract int GetVolume();


}
