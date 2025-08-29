
using System.Diagnostics;

/// <summary>
/// C# technical interview problem #1
/// </summary>
public static class Problem1
{

    /// <summary>
    /// This problem is supposed to swap two integers, a and b.  Unfortunately, the end result isn't right.  
    /// The values aren't swapped.  Fix the issue and explain why it didn't initially work. Leave the return value
    /// for Swap as void.
    /// </summary>
    public static void SwapIntegers()
    {
        int a = 5;
        int b = 10;

        int aExpected = 10;
        int bExpected = 5;

        Console.WriteLine($"Before Swap: a = {a}, b = {b}");

        Swap(a, b);

        Console.WriteLine($"After Swap: a = {a}, b = {b}");

        Debug.Assert(a == aExpected);
        Debug.Assert(b == bExpected);
    }


    /// <summary>
    /// Supposedly swaps two integers.
    /// </summary>
    static void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}