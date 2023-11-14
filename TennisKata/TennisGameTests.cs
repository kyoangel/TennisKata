using FluentAssertions;

namespace TennisKata;

public class Tests
{
    private TennisGame _tennisGame;

    [SetUp]
    public void Setup()
    {
        _tennisGame = new TennisGame();
    }

    [Test]
    public void Love_All()
    {
        var score = _tennisGame.Score();
        score.Should().Be("Love All");
    }

    [Test]
    public void Fifteen_Love()
    {
        _tennisGame.FirstPlayerScore();
        var score = _tennisGame.Score();
        score.Should().Be("Fifteen Love");
    }
}