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

    [Test]
    public void Thirty_Love()
    {
        GivenFirstPlayerScore(2);
        var score = _tennisGame.Score();
        score.Should().Be("Thirty Love");
    }

    [Test]
    public void Forty_Love()
    {
        GivenFirstPlayerScore(3);
        var score = _tennisGame.Score();
        score.Should().Be("Forty Love");
    }
    
    private void GivenFirstPlayerScore(int times)
    {
        for (int i = 0; i < times; i++)
        {
            _tennisGame.FirstPlayerScore();
        }
    }
}