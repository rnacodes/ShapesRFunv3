using ShapesRFun.Bases;
using ShapesRFun.Interfaces;
namespace ShapesRFun.Shapes;

//Square inherits from the basic AbstractShapeBase class for shapes with only one Dimension required
//This class that inherits from the AbstractShapeBase class and IChangeShapes interface
//AbstractShapeBase class gives the Square class the the Dimension property and the GetArea method
//Square implements the IChangeShapes interface and inherits the DoubleArea and HalveArea methods
/*
public class Square : AbstractShapeBase, IChangeShapes
{
    private int sideLength;

    public Square (int sideLength) : base(new Dictionary<string, int> { { "Side Length", sideLength } })
    {

    }
    //Inherited from the AbstractShapeBase class
    public int GetArea()
    {
        return SquareAreaCalculation(sideLength);
    }

    //DoubleArea and HalveArea methods are inherited from the IChangeShapes interface

    //Inherited from the IChangeShapes interface
    public int DoubleArea()
    {
        return SquareAreaCalculation(sideLength) * 2;
    }

    //Inherited from the IChangeShapes interface
    public int HalveArea()
    {
        return SquareAreaCalculation(sideLength) / 2;
    }

    //Simple method to calculate area of a square to prevent repeating code
    public int SquareAreaCalculation(int sideLength)
    {
        return sideLength * sideLength;
    }

 //This method is only used for testing purposes
    public static string SquareSpecial()
    {
        return "What is a square's favorite song? Hip to be Square!";
    }
}
*/


