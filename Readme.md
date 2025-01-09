# ShapeMaker Project
This project includes both the ShapeMaker program and the ShapeMaker unit tests

## ShapeMaker App

The basic functionality of the ShapeMaker app is to present the user with a series of questions that allows the program to create a shape with user-defined parameters. The goal of this project is to demonstrate the use of classes, class inheritance, interfaces, and testing. This project has also been a great example of using the DRY method and iterating and optimizing to improve the code as I add functionality.

Shapes are divided into two categories: "Simple" shapes that contain only one user-defined dimension, and "Special/Complex" shapes that contain two user-defined dimensions.

**Basic shapes:**
* Circle - only radius is defined
* Square - only length/width is defined

**Special shapes:**
* Rectangle: length and width are defined
* Triangle: height and base are defined

**Classes:** stored in the "Classes" folder
* ShapeBase.cs - abstract class that is the basic starter for all shapes
	* Provides the "Dimension" property and the GetArea(); method
		* This class implements the ICalculateArea interface, which contains the GetArea(); method whose formula is defined by each shape
	* All simple shapes inherit from this class
	* Special shape base also inherits from this class
	* Because this class is abstract, instantiated classes cannot be created from it directly.
* SpecialShapeBase.cs - abstract class that is the basis for special shapes with two dimensions
	* Inherits from ShapeBase class, which means it inherits the Dimension property and GetArea methods
	* This class provides a second Dimension for these shapes

**Interfaces**: contracts for behavior that are implemented by Shape classes.

* ICalculateArea:
	* This interface provides a GetArea(); method that is defined by the shape class that implements the interface
* IChangeShapes:
	* This interface provides methods that double and halve the area of the shapes that implement it

**Shapes**: these are the classes that define the available shapes that users can request the program to create
* Circle: basic shape that inherits from ShapeBase
	* Contains Dimension property, inherited from ShapeBase 
	* GetArea is implemented from the ICalculateArea interface, which ShapeBase implements - here, the formula for the method is defined.
	* Contains a Circle-specific "GetPerimeter" method 
		* When a circle is chosen in the final user prompt, the program calculates a random number and uses this as Dimension1 of a circle. This is then used to calculate Perimeter.
* Square: basic shape that inherits from ShapeBase
	* Contains Dimension property, inherited from ShapeBase
	* GetArea is implemented from the ICalculateArea interface, which ShapeBase implements - this shape also defines its own GetArea method
	* Implements the IChangeShapes interface, so contains the DoubleArea and HalveArea parameters
	* Contains SquareSpecial method that prints a Square joke
	* Square class also defines a method to calculate the area of a square that is used in other methods to prevent repeating code (DRY principle)
* Rectangle: special shape that inherits from SpecialShapeBase
	* Contains Dimension property and GetArea method, inherited from ShapeBase
	* Contains a second Dimension2 property, inherited from SpecialShapeBase
	* Implements IChangeShapes interface, so inherits the DoubleArea and HalveArea methods
	* Unique method RectangleMagicNumber returns a special message
* Triangle: special shape that inherits from SpecialShapeBase
	* Contains Dimension property and GetArea method, inherited from ShapeBase
	* Contains a second Dimension2 property, inherited from SpecialShapeBase
	* GetArea is implemented from the ICalculateArea interface, which ShapeBase implements - this shape also defines its own GetArea method
	* Contains TriangleSpecial method that writes a joke to the console

**Classes:**
* AddShapes: this class contains a method that takes the area of two shapes and returns the result of both combined.

### Program helpers:
* CreateShape method: contains switch statement that creates a shape based on user input for shape dimensions. The area of the shape is returned.
* DoFunTrick method: user can choose one of the special abilities each shape has. This method works by taking in the user's input (which is the name of a shape) as an argument. The response changes depending on which shape is chosen. 
	* Triangle: tells a joke using a static method, which also prints to console.
		* A static method is used so that the joke can be printed without having to instantiate a Triangle object.
		* The TriangleSpecial method writes the joke to console, so that only the method needs to be called for the joke to print (as opposed to the Rectangle's special trick).
	* Rectangle: calls a static method (so that a Rectangle doesn't need to be instantiated) that returns a joke in string form. This joke is then separately printed to the console.
	* Circle: an instantiation of the Circle class is created. The GetRando method is called to generate a random number, which is then assigned as the value for the circle's dimension. The perimeter is calculated and both the Circle's dimension and perimeter are written to Console.
		* The Circle's special trick takes advantage of the Circle's special GetPerimeter method unique to its class.
	* Square: creates a square using a random number, then applies the HalveArea and DoubleArea methods.
	* Entering "no" displays a funny message
* GetRando method: this method returns a random number between 1 and 20. This is used by the Circle and Square's special tricks. (This is another method created thanks to DRY principle)

### Shapemaker Program:
* Initializes variables for first shape
**Area of first shape**
* Console asks user which shape to build
	* try/catch loop: Error is thrown if input other than a valid shape is entered, asking user for valid shape
	* Once valid shape is entered, the user's input is converted to lowercase
* Console asks user for 1st dimension of 1st shape
	* User's input is validated for a valid number and error is thrown otherwise, and user is asked for valid number.
	* If a shape with two dimensions is chosen, the user is prompted for a second dimension. This structure follows the same as when the user is asked for the first dimension.
* ProgramHelpers.CreateShape creates a shape based on user input
* Console prints message with calculated area
**Area of second shape**
* Console asks user if they want to add a second shape to the first
	* If user enters "No," the program then jumps to the Fun Trick.
	* If user wants to build second shape, program asks for input for shape and dimensions and validates it the same as the first shape
* Program builds second shape
* Area for Shape2 is calculated
* Instantiation of the AddShapes class is created, which takes the areas of both shapes as arguments
* Areas for both shapes are added together
* Console prints result of added areas
**Fun Shape Tricks**
* Console then asks user if they would like to see a fun trick. Each of the shapes has its own unique method or property that can be accessed by typing in the name of the shape. I did these to test out how different methods, properties and return types function both when used and in testing

//Ideas for improvement
- Add tests for Triangle and remaining Rectangle methods
- Ensuring that error is thrown for invalid input as needed
- Creating tests for desired user input and incorrect user input for all dialogue options
- DRY principle - Is there any code on the program file that can be modulated into resuable methods? Specifically the try/catch loops


## Shapemaker Tests

### Add Shapes - tests AddShapes helper class

**AddShapesTest1 - xUnit**
* AddShapesHereTest - provides area for two shapes. Tests addShapes method on these two values
* Arrange: Two shape areas and their combined value are provided
* Act: AddShapes is instantiated and calls the AddShapesHereMethod
* Assert: Expected value and actual value are compared

**AddShapesTest2 - Moq**
AddShapesHere_AddTwoSimpleShapes - creates two simple mock shape classes
* Arrange: create instantiations of mock shapes with specified areas
setting up the mock shapes and class to add their areas
* Act?: Calculate the area of the mocked shapes, create instantiation of AddShapes class
* Assert: Compare expected area with actually calculated area

### Overall structure of tests for Shape instantiation
* The shape-based tests create an object using specified properties
* The expected calculation is also given
* A method is called that performs on the object
* The expected and actual results of the test are compared

### Circle Tests
**xUnit**
GetArea test
Perimeter test

**Moq tests coming soon!**

### ShapesFunTricks Test
Tests for each fun methods special to each shape class are created using xUnit as they are static methods
* RectangleMagicNumber
* SquareSpecial - this test won't set up properly

### Square Tests
These unit tests confirm that methods in the Square shape class function as expected.

**xUnit Tests**
* SquareAreaTest1 - lays out a specified dimension size and expected area
	* Creates a Square object with this property
	* The GetArea method is called 
	* The actual result of the GetArea method is measured against what the expected value should be	
* SquareDoubleAreaTest1
* SquareHalveAreaTest1

**Moq Tests**
* SquareAreaTest2
* SquareDoubleAreaTest2
* SquareHalveAreaTest2

### User input - Moq
* Invalid input for first shape request

