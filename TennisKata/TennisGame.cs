namespace TennisKata;

public class TennisGame
{
    readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
    {
        {
            1, "Fifteen"
        },
        {
            2, "Thirty"
        },
        {
            3, "Forty"
        }
    };

    private int _firstPlayerScoreTime;

    private int _secondPlayerScoreTime;

    public string Score()
    {
        if (_firstPlayerScoreTime > 0)
        {
            return $"{_scoreLookup[_firstPlayerScoreTime]} Love";
        }

        if (_secondPlayerScoreTime == 1)
        {
            return "Love Fifteen";
        }

        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _firstPlayerScoreTime++;
    }

    public void SecondPlayerScore()
    {
        _secondPlayerScoreTime++;
    }
}