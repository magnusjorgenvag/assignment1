using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_stringsWithNonAlphanumeric_splitIntoAlphanumeric() {

            // Arrange
            var list = new List<string>() {"hello!and&Welc6344Ome", "aNd//welc63ome"};

            // Act
            var output = RegExpr.SplitLine(list);

            // Assert
            var expected = new List<string>() {"hello", "and", "Welc6344Ome", "aNd", "welc63ome"};
            Assert.Equal(expected, output);
        }
    }
}
