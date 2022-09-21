namespace Assignment2.Tests;

public class DelegatesTests
{
    public delegate string Reverse(string s);

    static string ReverseString(string s) => new string(s.Reverse().ToArray());

    [Fact]
    public void Reverse_12abHI_gives_IHba21()
    {
        var input = "12abHI";
        var expected = "IHba21";
        Reverse rev = ReverseString;

        Assert.Equal(expected, rev(input));
    }

    public delegate double Product(double i, double j);

    static double ProductDouble(double i, double j) => i * j;

    [Fact]
    public void Product_15_3_Point_5_Is_52_Point_5() {
        var i = 15.0;
        var j = 3.5;
        Product pro = ProductDouble;

        Assert.Equal(52.5, pro(i, j));
    }

    public delegate bool StringIntEquals(string s, int i);

    static bool StringIntEquality(string s, int i) => Int32.Parse(s) == i;

    [Fact]
    public void String_000060_Equals_Int_60() {
        var s = "000060";
        var i = 60;
        StringIntEquals sie = StringIntEquality;

        Assert.True(sie(s, i));
    }
}
