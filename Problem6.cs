using System.Diagnostics;

/// <summary>
/// C# technical interview problem #6
/// </summary>
public static class Problem6
{

    /// <summary>
    /// Implement a function that, given a string input that contains any combination of the letters A-Z (case insensitive),
    /// counts the occurrences of each letter and returns a string representation of the counts in the format "A2B2C3...".  
    /// The output counts must match the order of first appearance of each letter in the input string. There are multiple solutions
    /// to this problem.  Pick your favorite.
    /// </summary>
    public static void CountLettersInString()
    {
        var input = "AABBAAACCDDDDAAEEEAA";
        var expectedOutput = "A2B2A3C2D4A2E3A2";

        var result = BuildCountLetters(input);

        Debug.Assert(result == expectedOutput, $"Expected '{expectedOutput}' but got '{result}'");
        Console.WriteLine(result);
    }

    /// <summary>
    /// Given a string input that contains any combination of the letters A-Z (case insensitive),
    /// counts the occurrences of each letter and returns a string representation of the counts in the format "A2B2C3...".  
    /// The output counts must match the order of first appearance of each letter in the input string.  As an example, the input
    /// string "AABBAA" would produce the output "A2B2A2".
    /// </summary>
    /// <example>
    /// Input: "AABBAAA"
    /// Output: "A2B2A3"
    /// </example>
    /// <param name="input">
    /// The input string.  It is expected to be a series of letters from A-Z.  
    /// </param>
    /// <returns>
    /// A string representation of the counted letters in the format "A2B2C3...". The comparison is case insensitive.
    /// </returns>
    static string BuildCountLetters(string input)
    {
        // TODO: your implementation here

        return "";
    }

}