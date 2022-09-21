namespace Assignment2.Tests;

public class WizardTests
{
    [Fact]
    public void WizardCollection_contains_3_wizards()
    {
        var expected = new List<String>{"Harry Potter", "Ron Weasly", "Hermoine Granger"};
        Assert.Equal(expected, Queries.WizardsByRowling());
    }

    [Fact]
    public void First_Sith_Lord_1912()
    {
        var expected = new List<int?>{1912};
        Assert.Equal(expected, Queries.FirstSithLord());
    }

    [Fact]
    public void Distinct_From_Harry_Potter()
    {
        var expected = new List<(string?, int?)>{("Harry Potter", 1997), ("Ron Weasly", 1997), ("Hermoine Granger", 1997)};
        Assert.Equal(expected, Queries.DistinctHarryPotter());
    }

    [Fact]
    public void Wizards_Grouped_By_Creator()
    {
        var expected = new List<(string, string)>{("Jimmy Neutron", "Jimmy Neutron"), ("J.R.R. Tolkien", "Sauron"), ("J.R.R. Tolkien", "Legolas"), ("J.R.R. Tolkien", "Gandalf"), ("J.K. Rowling", "Ron Weasly"), ("J.K. Rowling", "Hermoine Granger"), ("J.K. Rowling", "Harry Potter"), ("God", "Tobias Gad Spoorendonk"), ("God", "Jesus Christ"), ("George Lucas", "Darth Vader"), ("George Lucas", "Darth Ajunta Pall")};
        Assert.Equal(expected, Queries.WizardByCreator());
    }

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }
}

