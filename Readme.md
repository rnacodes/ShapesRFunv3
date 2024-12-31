# ShapeMaker project
This project includes both the ShapeMaker program and the ShapeMaker unit tests

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
	* Contains a Circle-specific "GetPerimeter" method 
		* When a circle is chosen in the final user prompt, the program calculates a random number and uses this as Dimension1 of a circle. This is then used to calculate Perimeter.
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
* DoFunTrick: user can choose one of the special abilities each shape has.

Program itself:
* Initializes variables for first shape
* While loop - console asks user which shape to build
	* try/catch loop: Error is thrown if input other than a valid shape is enteredm asking for valid shape
	* Once valid shape is entered, the user's input is converted to lowercase
* Second while loop - console asks user for 1st dimension of 1st shape
	* User's input is validated for a valid number and error is thrown otherwise, and user is asked for valid number.
* The next part depends on which shape is chosen.
	* If a shape with two dimensions is chosen, the user is prompted for a second dimension. This structure follows the same as when the user is asked for the first dimension.
* Console prints messages about calculating area
* ProgramHelpers.CreateShape create a shape based on user input
* Second shape - asks user if they want to add a second shape to the first
	* If user wants to build second shape, program asks for input and validates it the same as the first shape
* Program builds second shape
* Area for Shape2 is calculated
* Areas for both shapes are added together
* Console prints result of added areas
* Fun trick - each of the shapes has its own built in fun method or property. I did these to test out how different methods, properties and return types function both when used and in testing.

//IN PROGRESS
- Special stuff for shape-specific methods
- Validating user input for second half of program
- Creating tests for desired user input and incorrect user input
- Test for fun trick responses

//Ideas for improvement
* Is there any code on the program file that can be modulated into resuable methods? Specifically the try/catch loops.

## Shapemaker Tests