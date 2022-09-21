namespace Assignment2;

public class Queries
{
    static WizardCollection wc = WizardCollection.Create();

    public static IEnumerable<string> WizardsByRowling() {
        var a = from w in wc.Cast<Wizard>()
                where w.Creator == "J.K. Rowling"
                select w.Name;
        return a;
    }

    public static IEnumerable<int?> FirstSithLord() {    
        var a = from w in wc.Cast<Wizard>()
                where w.Name.StartsWith("Darth")
                orderby w.Year
                select w.Year;
        return a.Take(1);
    }

    public static IEnumerable<(string?, int?)> DistinctHarryPotter() {    
        var a = from w in wc.Cast<Wizard>()
                where w.Medium == "Harry Potter"
                orderby w.Year
                select (w.Name, w.Year);
        return a.Distinct();
    }

    public static IEnumerable<(string, string)> WizardByCreator() {    
        var a = from w in wc.Cast<Wizard>()
                orderby w.Name descending
                orderby w.Creator descending
                select (w.Creator, w.Name);
        return a;
    }
}
