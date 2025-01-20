using kata_zone.katas;
namespace kata_zone.Tests.kata_tests
{
    public class SearchTests
    {
        [Fact]
        public void linearSearch_ShouldReturnTrue()
        {
            Search Search = new Search();
            int[] haystack = [1, 2, 4, 5, 6, 78, 1, 4, 456, 33, 7, 2];
            int needle = 6;
            // Act
            bool result = Search.linearSearch( haystack, needle );

            // Assert
            Assert.True( result );
        }

        [Fact]
        public void linearSearch_ShouldReturnFalse()
        {
            Search Search = new Search();
            int[] haystack = [1, 2, 4, 5, 6, 78, 1, 4, 456, 33, 7, 2];
            int needle = 8;
            // Act
            bool result = Search.linearSearch( haystack, needle );

            // Assert
            Assert.True( !result );
        }
    }
}
