using System.Diagnostics;

/// <summary>
/// C# technical interview problem #4
/// </summary>
public static class Problem4
{
    public const string WhatTheCowSays = "Moo! Moo! Moo!";

    /// <summary>
    /// The cow keeps saying "Bessie makes a noise." but that's not what we want.  What we wanted was for it to say 
    /// "Moo! Moo! Moo!".  Fix the code to get the right behavior and explain why we didn't get what
    /// we expected at first.  Do not remove the cast to LivingThing.
    /// </summary>
    public static void TestLivingThingSpeak()
    {

        var cow = new Cow() { Name = "Bessie" };
        var livingThing = cow as LivingThing;

        var sound = livingThing.Speak();

        Debug.Assert(sound == WhatTheCowSays, $"Expected '{WhatTheCowSays}' but got '{sound}'");

        Console.WriteLine(sound);
    }
}


public class Cow : LivingThing
{
    public new string Speak()
    {
        return Problem4.WhatTheCowSays;
    }
}


public class LivingThing
{
    public string Name { get; set; } = "";

    public string Speak()
    {
        return $"{Name} makes a noise.";
    }
}