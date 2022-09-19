namespace Students;
public record ImmutableStudent
{
    int Id {get; init;}
    string GivenName {get; init;}
    string Surname {get; init;}
        enum StudentStatus{
        New, Active, Dropout, Graduated
    }
    StudentStatus Status
    {
        get
        {
            var currentDate = DateTime.Now;
            if (currentDate > StartDate)
            {
                if (EndDate < GraduationDate)
                {
                    return StudentStatus.Dropout;
                }
                else
                {
                    if (currentDate < GraduationDate)
                    {
                        return StudentStatus.Active;
                    }
                    else
                    {
                        return StudentStatus.Graduated;
                    }
                }
            }
            else
            {
                return StudentStatus.New;
            }
        }
    }
    DateTime StartDate {get; init;}
    DateTime EndDate {get; init;}
    DateTime GraduationDate {get; init;}

    public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        Id = id;
        GivenName = givenName;
        Surname = surname;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;

    }
}