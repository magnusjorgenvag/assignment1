using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

        [Fact]
        public void Resolutions_givenStringOfResolutions_correctTupleResolutions() {

            // Arrange
            var input = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";

            // Act
            var output = RegExpr.Resolution(input);

            // Assert
            var expected = new List<(int, int)> {(1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)};
            Assert.Equal(expected, output);
        }

        [Fact]
        public void InnerText_givenHtmlAndTag_correctInnerTextStringList() {
            // Arrange
            var html = "<p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href='/wiki/Theoretical_computer_science' title='Theoretical computer science'>theoretical computer science</a> and <a href='/wiki/Formal_language' title='Formal language'>formal language</a> theory, a sequence of <a href='/wiki/Character_(computing)' title='Character (computing)'>characters</a> that define a <i>search <a href='/wiki/Pattern_matching' title='Pattern matching'>pattern</a></i>. Usually this pattern is then used by <a href='/wiki/String_searching_algorithm' title='String searching algorithm'>string searching algorithms</a> for 'find' or 'find and replace' operations on <a href='/wiki/String_(computer_science)' title='String (computer science)'>strings</a>.</p>";
            var tag = "<a>";

            var html2 = "<p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>";
            var tag2 = "<p>";
            
            // Act
            var output = RegExpr.InnerText(html, tag);
            var output2 = RegExpr.InnerText(html2, tag2);

            // Assert
            var expected = new List<string> {"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};
            var expected2 = new List<string> {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};

            Assert.Equal(expected, output);
            Assert.Equal(expected2, output2);
        }
    }
}
