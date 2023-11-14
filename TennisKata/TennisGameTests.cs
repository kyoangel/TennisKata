using FluentAssertions;

namespace TennisKata;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Love_All()
    {
        var tennisGame = new TennisGame();
        var score = tennisGame.Score();
        score.Should().Be("Love All");
    }
}