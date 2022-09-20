namespace Students.Tests;

public class StudentTest
{
        [Fact]
    public void ImmmutableStudent_Active_ToString()
    {
        var s = new ImmutableStudent(1, "Silas", "Arildsen", Students.StudentStatus.New,  new DateTime(2021, 8, 1), new DateTime(2024, 6, 1), new DateTime(2024, 6, 1));
        var expected = "ImmutableStudent { Id = 1, GivenName = Silas, Surname = Arildsen, Status = New, StartDate = 01/08/2021 00:00:00, EndDate = 01/06/2024 00:00:00, GraduationDate = 01/06/2024 00:00:00 }";
        s.ToString().Should().Be(expected);
    }

    [Fact]
    public void ImmstaticStudent_Equality() {
        var s1 = new ImmutableStudent(1, "Silas", "Arildsen", Students.StudentStatus.New,  new DateTime(2021, 8, 1), new DateTime(2024, 6, 1), new DateTime(2024, 6, 1));
        var s2 = new ImmutableStudent(1, "Silas", "Arildsen", Students.StudentStatus.New,  new DateTime(2021, 8, 1), new DateTime(2024, 6, 1), new DateTime(2024, 6, 1));
        (s1 == s2).Should().Be(true);
        s1.Should().Be(s2);
    }
}