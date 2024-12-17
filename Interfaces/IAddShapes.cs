using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
public abstract class AddShapes : SpecialShapeBase
{
    public int AddShapesHere(ShapeBase shapeToAdd1, ShapeBase shapeToAdd2)
    {
        return shapeToAdd1.GetArea + shapeToAdd2.GetArea;
    }
}

