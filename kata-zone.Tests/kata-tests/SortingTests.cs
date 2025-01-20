using kata_zone.katas;
namespace kata_zone.Tests
{
    public class SortingTests
    {
        [Fact]
        public void bubbleSort_ShouldReturnAscendingOrderIntArray1()
        {
            Sort Sort = new Sort();
            int[] a = [1, 2, 4, 5, 6, 78, 1, 4, 456, 33, 7, 2];

            // Act
            int[] result = Sort.bubbleSort( a );

            // Assert
            Assert.Equal( [1, 1, 2, 2, 4, 4, 5, 6, 7, 33, 78, 456], result );
        }

        [Fact]
        public void bubbleSort_ShouldReturnAscendingOrderIntArray2()
        {
            Sort Sort = new Sort();
            int[] a = [1111, 2, 4, 5, 6, 78, 1111, 4, 456, 33, 7, 2];

            // Act
            int[] result = Sort.bubbleSort( a );

            // Assert
            Assert.Equal( [2, 2, 4, 4, 5, 6, 7, 33, 78, 456, 1111, 1111], result );
        }
    }
}