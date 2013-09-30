
namespace IntelOrca.WITC
{
	class Player
	{
		private string mName;
		private int mCorrect;
		private int mPass;
		private int mFoul;
		private int mTurns;

		public Player(string name)
		{
			mName = name;
		}

		public string Name
		{
			get
			{
				return mName;
			}
			set
			{
				mName = value;
			}
		}

		public int Correct
		{
			get
			{
				return mCorrect;
			}
			set
			{
				mCorrect = value;
			}
		}

		public int Pass
		{
			get
			{
				return mPass;
			}
			set
			{
				mPass = value;
			}
		}

		public int Foul
		{
			get
			{
				return mFoul;
			}
			set
			{
				mFoul = value;
			}
		}

		public int Turns
		{
			get
			{
				return mTurns;
			}
			set
			{
				mTurns = value;
			}
		}

		public int Score
		{
			get
			{
				return (Correct * Program.Settings.CorrectScore) + (Pass * Program.Settings.PassScore) + (Foul * Program.Settings.FoulScore);
			}
		}
	}
}
