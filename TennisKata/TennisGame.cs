namespace TennisKata;

public class TennisGame
{
    private int _firstPlayerScoreTime;

    public string Score()
    {
        if (_firstPlayerScoreTime==1)
        {
            return "Fifteen Love";
        }

        if (_firstPlayerScoreTime==2)
        {
            return "Thirty Love";
        }
        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _firstPlayerScoreTime++;
    }
}