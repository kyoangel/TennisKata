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

        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _firstPlayerScoreTime++;
    }
}