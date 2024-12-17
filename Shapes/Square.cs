using ShapesRFun.Bases;
using ShapesRFun.Interfaces;

//Square inherits from the basic ShapeBase class for shapes with only one Dimension required
//This class that inherits from the ShapeBase class and IChangeShapes interface
//ShapeBase class gives the Square class the the Dimension property and the GetArea method
//Square implements the IChangeShapes interface and inherits the DoubleArea and HalveArea methods
internal class Square : ShapeBase, IChangeShapes
{
    //Inherited from the ShapeBase class
    public override int GetArea()
    {
        return SquareAreaCalculation(Dimension);
    }

    //DoubleArea and HalveArea methods are inherited from the IChangeShapes interface

    //Inherited from the IChangeShapes interface
    public int DoubleArea()
    {
        return SquareAreaCalculation(Dimension) * 2;
    }

    //Inherited from the IChangeShapes interface
    public int HalveArea()
    {
        return SquareAreaCalculation(Dimension) / 2;
    }

    //Simple method to calculate area of a square to prevent repeating code
    public int SquareAreaCalculation(int Dimension)
    {
        return Dimension * Dimension;
    }

    public void SquareSpecial()
    {
        Console.WriteLine("What is a square's favorite song? Hip to be Square!");

    }


}



