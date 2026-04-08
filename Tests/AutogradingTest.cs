namespace Tests;

using System.Text.RegularExpressions;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Replace_The_Foreach_Loop_And_The_If_Condition_With_A_Linq_Statement(){
        var result = new StateLookUp().LookUp("Io");
        Assert.Single(result);
        Assert.Equal("Iowa", result.First());

        string filePath = Path.GetDirectoryName(typeof(StateLookUp).Assembly.Location) + "/../../../StateLookUp.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);
        Regex rx = new Regex(@"from.*in.*STATES");

        bool hasComment = rx.IsMatch(content);

        Assert.True(hasComment, "Should replace the `foreach` loop and the `if` condition with a `Linq` statement");
    }
}