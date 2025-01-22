namespace ShapesRFun.Bases;
//SpecialShapeBase inherits from AbstractShapeBase
//This class is for creating shapes with a second dimension
//SpecialShapeBase inherits the Dimension property and the GetArea method from the AbstractShapeBase class
//SpecialShapeBase adds a property for the second dimension

public abstract class SpecialShapeBase : AbstractShapeBase
    {
        //Property for second dimension
        public int Dimension2 { get; set; }
    }
