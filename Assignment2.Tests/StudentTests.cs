namespace Assignment2.Tests;

using Student;

public class StudentTests
{
    [Fact]
    public void StatusChecks()
    {
        //Arrange
        var student0 = new Student(1, "Tobias", "Spoorendonk", new DateTime(2011, 09, 3), new DateTime(2014, 09, 3), new DateTime(2017, 09, 3));
        var student1 = new Student(2, "Robin", "Hood", new DateTime(1000, 09, 3), new DateTime(1001, 09, 3), new DateTime(1001, 09, 3));
        var student2 = new Student(3, "Chuck", "Norris", new DateTime(2021, 09, 3), new DateTime(2024, 09, 3), new DateTime(2024, 09, 3));
        var student3 = new Student(4, "Seto", "Kaiba", new DateTime(2030, 09, 3), new DateTime(2034, 09, 3), new DateTime(2034, 09, 3));
        //Act
        //Assert
        Assert.Equal(Student.Status.Dropout, student0.status);
        Assert.Equal(Student.Status.Graduated, student1.status);
        Assert.Equal(Student.Status.Active, student2.status);
        Assert.Equal(Student.Status.New, student3.status);
    }

    [Fact]
    public void Student_ToString_Prints_Id_FirstName_Surname_Status_StartDate_EndDate_GraduationDate()
    {
        //ArrangeS
        var student = new Student(1, "Tobias", "Spoorendonk", new DateTime(2021, 09, 03), new DateTime(2024, 09, 03), new DateTime(2027, 09, 03));
        var answer = "1, Tobias, Spoorendonk, Dropout, 03/09/2021, 03/09/2024, 03/09/2027";

        //Act
        var output = student.ToString();

        //Assert
        Assert.Equal(answer, output);
    }
}
