using System.Text.RegularExpressions;
using NUnit.Framework;
using teach_05;

namespace test_teach_05;

public class Tests
{
    [Test]
    public void TestUniqueLetters1()
    {
        var test1 = "abcdefghjiklmnopqrstuvwxyz";
        // Expect True because all letters unique
        Assert.That(SetProblems.AreUniqueLetters(test1), Is.True);
        CheckUniqueLettersMethodHasChanged();
    }
    
    [Test]
    public void TestUniqueLetters2()
    {
        var test2 = "abcdefghjiklanopqrstuvwxyz";
        // Expect False because 'a' is repeated
        Assert.That(SetProblems.AreUniqueLetters(test2), Is.False);
        CheckUniqueLettersMethodHasChanged();
    }
    
    [Test]
    public void TestUniqueLetters3()
    {
        var test3 = "";
        // Expect True because it's an empty string
        Assert.That(SetProblems.AreUniqueLetters(test3), Is.True);
        CheckUniqueLettersMethodHasChanged();
    }
    
    [Test]
    public void TestDisplaySums1()
    {
        var results = SetProblems.FindSumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var expected = new[] { (4, 6), (3, 7), (2, 8), (1, 9) };
        // Is.EquivalentTo(...) ignores order & checks for all pairs
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }
    
    [Test]
    public void TestDisplaySums2()
    {
        var results = SetProblems.FindSumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        var expected = new[] { (0, 10), (-5, 15), (-10, 20) };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }
    
    [Test]
    public void TestDisplaySums3()
    {
        var results = SetProblems.FindSumPairs([5, 11, 2, -4, 6, 8, -1]);
        var expected = new[] { (2, 8), (-1, 11) };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }

    private static void CheckUniqueLettersMethodHasChanged()
    {
        var responseDocument = new FileInfo("../../../../teach-05/SetProblems.cs");
        Assert.That(responseDocument.Exists, Is.True);
        using var sr = new StreamReader(responseDocument.Open(FileMode.Open));
        var codeFileText = sr.ReadToEnd();
        var methodText = new Regex(@"public static bool AreUniqueLetters\(string text\)\s*\{(?:[^{}]*|\{(?:[^{}]*|\{[^{}]*\})*\})*\}")
            .Match(codeFileText).Value;
        const string originalMethodText = "public static bool AreUniqueLetters(string text)\n    {\n        // TODO Problem 1 - Replace the O(n^2) algorithm to use sets and O(n) efficiency\n        for (var i = 0; i < text.Length; ++i)\n        {\n            for (var j = 0; j < text.Length; ++j)\n            {\n                // Don't want to compare to yourself ... that will always result in a match\n                if (i != j && text[i] == text[j])\n                    return false;\n            }\n        }\n\n        return true;\n    }";
        var whitespaceTrimmer = new Regex(@"\s");
        Assert.That(whitespaceTrimmer.Replace(methodText, ""),
            Is.Not.EqualTo(whitespaceTrimmer.Replace(originalMethodText, "")),
            "AreUniqueLetters() is still the original code; use sets to run in O(n) instead of O(n^2)");
    }
}