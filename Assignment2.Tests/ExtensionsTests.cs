namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_numbers_in_xs()
    {
        //Arrange
        var a1 = new List<int> {1, 2, 7};
        var a2 = new List<int> {10, 15};
        var a3 = new List<int> {};
        IEnumerable<int>[] xs = {a1, a2, a3};
        var expected = new [] {1, 2, 7, 10, 15};

        //Act
        var actual = xs.Flatten();

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_Numbers_Div_By_7_And_Greater_Than_42()
    {
        //Arrange
        var xs = new List<int>{15, 21, 50, 63, 70, 49, 16};
        var expected = new [] {63, 70, 49};
        Predicate<int> pred = Pred;

        bool Pred(int i) => i > 42 && i % 7 == 0;

        //Act
        var actual = xs.Filter(pred);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_Leap_Years()
    {
        //Arrange
        var xs = new List<int>{1604, 1607, 1608, 2001, 2120};
        var expected = new [] {1604, 1608, 2120};
        Predicate<int> pred = Pred;

        bool Pred(int i) => i % 4 == 0;

        //Act
        var actual = xs.Filter(pred);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}
