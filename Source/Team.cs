////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IntelOrca.WITC
{
	class Team : IEnumerable<Player>
	{
		private List<Player> mPlayers;
		private string mName;

		private int mPlayerGoIndex;
		private bool mWon;

		public Team()
		{
			mPlayers = new List<Player>();
			mName = null;
		}

		public Team(string name)
		{
			mPlayers = new List<Player>();
			mName = name;
		}

		public void AddPlayer(Player player)
		{
			mPlayers.Add(player);
		}

		public void AddPlayer(params string[] playerNames)
		{
			for (int i = 0; i < playerNames.Length; i++) {
				mPlayers.Add(new Player(playerNames[i]));
			}
		}

		public void NextPlayer()
		{
			mPlayerGoIndex = (mPlayerGoIndex + 1) % mPlayers.Count;
		}

		public IEnumerator<Player> GetEnumerator()
		{
			return mPlayers.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return mPlayers.GetEnumerator();
		}

		public Player PlayerGo
		{
			get
			{
				return mPlayers[mPlayerGoIndex];
			}
		}

		public int PlayerGoIndex
		{
			get
			{
				return mPlayerGoIndex;
			}
			set
			{
				mPlayerGoIndex = value;
			}
		}

		public List<Player> Players
		{
			get
			{
				return mPlayers;
			}
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

		public int Turns
		{
			get
			{
				return mPlayers.Sum(p => p.Turns);
			}
		}

		public int Correct
		{
			get
			{
				return mPlayers.Sum(p => p.Correct);
			}
		}

		public int Pass
		{
			get
			{
				return mPlayers.Sum(p => p.Pass);
			}
		}

		public int Foul
		{
			get
			{
				return mPlayers.Sum(p => p.Foul);
			}
		}

		public int Score
		{
			get
			{
				return (Correct * Program.Settings.CorrectScore) + (Pass * Program.Settings.PassScore) + (Foul * Program.Settings.FoulScore);
			}
		}

		public bool Won
		{
			get
			{
				return mWon;
			}
			set
			{
				mWon = value;
			}
		}
	}
}
