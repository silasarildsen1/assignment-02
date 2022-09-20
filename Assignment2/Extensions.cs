namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<T>[] items) {
        foreach (IEnumerable<T> item in items) {
            foreach (T actual in item) {
                yield return actual;
            }
        }
    }

    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate) {
        foreach (var item in items) {
            if (predicate(item)) {
                yield return item;
            }
        }
    }
}
