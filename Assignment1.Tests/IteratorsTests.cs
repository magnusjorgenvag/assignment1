using System;
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

        [Fact]
        public void Filter_givenNumberList_returnPositiveNumbers() {

            // Arrange
            Predicate<int> predicate = isPositive;
            var list1 = new List<int>() {-2,-1,0,1,2};
            
            // Act
            var filteredList = Iterators.Filter<int>(list1, predicate);

            // Assert
            var expected = new List<int>() {1,2};
            Assert.Equal(expected, filteredList);
        }

        bool isPositive(int number) {
            return number > 0;
        }
    }
}
