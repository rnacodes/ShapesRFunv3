/*
using Moq;
using ShapesRFun.Bases;
using Xunit;

namespace ShapesRFun.Tests
{
    public class AddShapesTest
    {
        [Fact]
        public void AddShapesHere_ShouldReturnCorrectSum()
        {
            // Arrange
            var mockShape1 = new Mock<AbstractShapeBase>();
            var mockShape2 = new Mock<AbstractShapeBase>();

            mockShape1.Setup(m => m.GetArea()).Returns(25);
            mockShape2.Setup(m => m.GetArea()).Returns(25);

            var addShapes = new AddShapes();

            // Act
            var actualArea = addShapes.AddShapesHere(mockShape1.Object, mockShape2.Object);

            // Assert
            Assert.Equal(50, actualArea);
            mockShape1.Verify(m => m.GetArea(), Times.Once);
            mockShape2.Verify(m => m.GetArea(), Times.Once);
        }
    }
}
*/