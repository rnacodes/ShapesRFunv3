using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
public class AddShapes
{
    public int AddShapesHere(int shape1Area, int shape2Area)
    {
        return shape1Area + shape2Area;
    }


    /*
        public int AddShapesHere(ShapeBase shapeToAdd1, ShapeBase shapeToAdd2)
        {
            return shapeToAdd1.GetArea() + shapeToAdd2.GetArea();
        }
    */

    /*
    public override int GetArea()
    {
        throw new NotImplementedException();
    }
    */
}

