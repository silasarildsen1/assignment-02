namespace Students.Tests;

public class StudentTest
{
    [Fact]
    public void Student_Active_ToString()
    {
        var s = new Student(1);
        s.GivenName = "Silas";
        s.Surname = "Arildsen";
        s.StartDate = new DateTime(2021, 8, 1);
        s.EndDate = new DateTime(2024, 6, 1);
        s.GraduationDate = new DateTime(2024, 6, 1);

        var actual = s.ToString();
        var expected = "Silas Arildsen, ID: 1. Start: 01/08/2021. Status: Active. Graduates: 01/06/2024.";
        actual.Should().Be(expected);
    }

    [Fact]
    public void Student_Graduated_ToString()
    {
        var s = new Student(1);
        s.GivenName = "Silas";
        s.Surname = "Arildsen";
        s.StartDate = new DateTime(2016, 8, 1);
        s.EndDate = new DateTime(2019, 6, 1);
        s.GraduationDate = new DateTime(2019, 6, 1);
        
        var actual = s.ToString();
        var expected = "Silas Arildsen, ID: 1. Start: 01/08/2016. Status: Graduated. Graduates: 01/06/2019.";
        actual.Should().Be(expected);
    }
}