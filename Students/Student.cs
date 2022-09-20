namespace Students;
public class Student
{
    public int Id {get; init;}
    public string? GivenName {get; set;}
    public string? Surname {get; set;}
    public StudentStatus Status
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
    public enum StudentStatus{
        New, Active, Dropout, Graduated
    }
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime GraduationDate {get; set;}

    public Student(int id) => Id = id;

    public override string ToString() => $"{GivenName} {Surname}, ID: {Id}. Start: {StartDate.Date.ToString("d")}. Status: {Status}. Graduates: {GraduationDate.Date.ToString("d")}.";
}

