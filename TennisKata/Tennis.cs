using System.Collections.Generic;

namespace TennisKata
{
	public class Tennis
	{
		private readonly string _firstPlayerName;
		private int _firstPlayerScoreTimes;

		private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
		{
			{0,"Love"},
			{1,"Fifteen"},
			{2,"Thirty"},
			{3,"Forty"},
		};

		private int _secondPlayerScoreTimes;

		public Tennis(string firstPlayerName)
		{
			_firstPlayerName = firstPlayerName;
		}

		public string Score()
		{
			if (IsScoreDiff())
			{
				if (_firstPlayerScoreTimes > 3)
				{
					if (_firstPlayerScoreTimes - _secondPlayerScoreTimes == 1)
					{
						return "Kyo Adv";
					}
				}

				return NormalScore();
			}

			if (IsDeuce())
			{
				return Deuce();
			}
			return SameScore();
		}

		private static string Deuce()
		{
			return "Deuce";
		}

		private bool IsDeuce()
		{
			return _firstPlayerScoreTimes >= 3;
		}

		private string NormalScore()
		{
			return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
		}

		private bool IsScoreDiff()
		{
			return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
		}

		private string SameScore()
		{
			return _scoreLookup[_firstPlayerScoreTimes] + " All";
		}

		public void FirstPlayerScore()
		{
			_firstPlayerScoreTimes++;
		}

		public void SecondPlayerScore()
		{
			_secondPlayerScoreTimes++;
		}
	}
}