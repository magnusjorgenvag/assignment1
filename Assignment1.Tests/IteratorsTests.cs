using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_givenTwoLists_correctCombinedList() {

            // Arrange
            var list1 = new List<int>() {1,2,3};
            var list2 = new List<int>() {4,5,6};

            var superList = new List<List<int>>() {list1, list2};

            // Act
            var flatList = Iterators.Flatten<int>(superList);

            // Assert
            var expected = new List<int>() {1,2,3,4,5,6};
            Assert.Equal(expected, flatList);
        }
    }
}
