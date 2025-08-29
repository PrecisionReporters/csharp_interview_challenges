using System.IO;

/// <summary>
/// C# technical interview problem #2
/// </summary>
public static class Problem2
{

    /// <summary>
    /// This function is meant to generate a bunch of test files.  Unfortunately it causes
    /// the app to crash with a fatal error (oh no!).  Fix the bug and explain why it happened.
    /// </summary>
    public static void CreateTestFiles()
    {
        var streams = new List<FileStream>();
        for (int i = 0; i < 100000; i++)
        {
            string filePath = Path.Combine("problem2-output", $"tempfile_{i}.tmp");

            FileStream fs = new FileStream(filePath, FileMode.Create);

            streams.Add(fs);
        }
    }
}
