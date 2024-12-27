## ShapeMaker App

The basic functionality of the ShapeMaker app is to present the user with a series of questions that allows the program to create a shape with user-defined parameters. The goal of this project is to demonstrate the use of classes, class inheritance, interfaces, and testing. This project has also been a great example of using the DRY method and iterating and optimizing to improve the code as I add functionality.

Shapes are divided into two categories: "Basic" shapes that contain only one user-defined dimension, and "Special/Complex" shapes that contain two user-defined dimensions.

Basic shapes:
* Circle - only radius is defined
* Square - only length/width is defined

Special shapes:
* Rectangle: length and width are defined
* Triangle: height and base are defined

**Classes:** stored in the "Classes" folder
* ShapeBase.cs - abstract class that is the basic starter for all shapes
	* Provides the "Dimension" property and the GetArea(); method
		* This class implements the ICalculateArea interface, which contains the GetArea(); method whose formula is defined by each shape.
	* All simple shapes inherit from this class
	* Special shape base also inherits from this class
	* Because this class is abstract, instantiated classes cannot be created from it
* SpecialShapeBase.cs - abstract class that is the basis for special shapes with two dimensions
	* Inherits from ShapeBase class, which means it inherits the Dimension property and GetArea methods
	* This class provides a second Dimension

**Interfaces**: contracts for behavior that classes implement

* ICalculateArea:
	* This interface provides a GetArea(); method that is defined by the class that implements the interface
* IChangeShapes - IN PROGRESS
	* This interface will provide methods that double and halve the area of the shapes that implement it
	* This class will likely be applied to only two shapes, one from each type

Shapes: these are the classes that define the available shapes that users can request the program to create
* Circle: basic shape that inherits from ShapeBase
	* Contains Dimension property, inherited from ShapeBase 
	* GetArea is implemented from the ICalculateArea interface, which ShapeBase implements - here, the formula for the method is defined.
	* Contains a Circle-specific "GetPerimeter" method - IN PROGRESS
* Square: basic shape that inherits from ShapeBase
	* Contains Dimension property, inherited from ShapeBase
	* GetArea is implemented from the ICalculateArea interface, which ShapeBase implements - this shape also defines its own GetArea method
	* Implements the IChangeShapes interface, so contains the DoubleArea and HalveArea parameters
	* Contains special method that prints a Square joke
	* Square class also defines a method to calculate the area of a square that is used in other methods to prevent repeating code (DRY method)
* Rectangle: special shape that inherits from SpecialShapeBase
	* Contains Dimension property and GetArea method, inherited from ShapeBase
	* Contains a second Dimension2 property, inherited from SpecialShapeBase
	* Implements IChangeShapes interface, so inherits the DoubleArea and HalveArea methods
	* Unique method RectangleMagicNumber that returns a special number
* Triangle: special shape that inherits from SpecialShapeBase
	* Contains Dimension property and GetArea method, inherited from ShapeBase
	* Contains a second Dimension2 property, inherited from SpecialShapeBase
	* GetArea is implemented from the ICalculateArea interface, which ShapeBase implements - this shape also defines its own GetArea method
	* Contains TriangleSpecial method that writes a joke to the console

Classes:
* AddShapes: this class contains a method that takes the area of two shapes and returns the result of both combined.

Program helpers:
* CreateShape method: contains switch statement that creates a shape based on user input

Program itself:
* Initializes variables for first shape
* While loop - console asks user which shape to build
	* IN PROGRESS: uses try/catch to validate user input or throw an error
* Console asks user for size of shape (Dimension1)
	* IN PROGRESS
* If special shapes rectangle or triangle are requested, console asks for second Dimension
* Console prints messages about calculating area
* ProgramHelpers.CreateShape create a shape based on user input
* Asks user if they want to add a second shape to the first
* If user wants to build second shape, program asks for input as above
* Program builds second shape
* Area for Shape2 is calculated
* Areas for both shapes are added together
* Console prints result of added areas

//IN PROGRESS
- Special stuff for shape-specific methods
- Validating user input
- Creating tests for desired user input and incorrect user input

