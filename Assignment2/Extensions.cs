namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<T>[] items) => items.SelectMany(item => item);
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate) => items.Where(new Func<T, bool>(predicate));

    public static int WordCount(this string self) {
        char[] delimiters = new char[] {' '};
        if (self.All(c => Char.IsLetter(c) || c == ' ' )) {
            return self.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length; 
        } else {
            throw new ArgumentException("String can only contain Letters and Spaces");
        }
    }

    public static bool IsSecure(this Uri uri) => uri.Scheme == Uri.UriSchemeHttps;
}
