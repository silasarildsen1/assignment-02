namespace Student;
public class Student
{
    public Student(int _id, string _givenName, string _surname, DateTime _startDate, DateTime _endDate, DateTime _graduationDate) {
        id = _id;
        givenName = _givenName;
        surname = _surname;
        startDate = _startDate;
        endDate = _endDate;
        graduationDate = _graduationDate;
    }
    public int id {get; init;}
    public string givenName {get; set;} = "";
    public string surname {get; set;} = "";
    public Status status
    {
        get {
            var now = DateTime.Now;
            if (now < startDate) {
                return Status.New;
            } else if (endDate < graduationDate) {
                return Status.Dropout;
            } else if ((now >= graduationDate) && (graduationDate >= endDate)){
                return Status.Graduated;
            } else {
                return Status.Active;
            }
            
        }
    }
    public DateTime startDate {get; set;}
    public DateTime endDate {get; set;}
    public DateTime graduationDate {get; set;}
    public enum Status {
        New,
        Active,
        Dropout,
        Graduated
    }
    public override string ToString() => $"{id}, {givenName}, {surname}, {status.ToString()}, {startDate.ToString("dd/MM/yyyy")}, {endDate.ToString("dd/MM/yyyy")}, {graduationDate.ToString("dd/MM/yyyy")}";
}
