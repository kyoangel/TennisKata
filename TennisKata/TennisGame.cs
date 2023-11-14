namespace TennisKata;

public class TennisGame
{
    private int _firstPlayerScoreTime;
    Dictionary<int, string> _scoreLookup = new Dictionary<int, string> {
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
    public string Score()
    {
        if (_firstPlayerScoreTime>0)
        {
            return $"{_scoreLookup[_firstPlayerScoreTime]} Love";
        }

        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _firstPlayerScoreTime++;
    }
}