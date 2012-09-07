////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IntelOrca.WITC
{
	class Game
	{
		private Random mRandom = new Random();
		private Team[] mTeams;
		private int mRoundDuration;
		private int mMaximumPasses;
		private string[] mCategories = new string[0];
		private int mPlayedRounds;

		private int mCurrentTeamGo;
		private int mCurrentBagIndex;
		private List<Bag> mBags = new List<Bag>();

		public void LoadGame()
		{
			FileStream fs = null;
			BinaryReader br = null;

			try {
				fs = new FileStream("save.dat", FileMode.Open);
				br = new BinaryReader(fs);

				Team[] teams = new Team[br.ReadInt32()];
				for (int i = 0; i < teams.Length; i++) {
					Team team = new Team(br.ReadString());
					int players = br.ReadInt32();
					for (int j = 0; j < players; j++) {
						Player player = new Player(br.ReadString());
						player.Correct = br.ReadInt32();
						player.Pass = br.ReadInt32();
						player.Foul = br.ReadInt32();
						player.Turns = br.ReadInt32();
						team.AddPlayer(player);
					}
					team.PlayerGoIndex = br.ReadInt32();
					teams[i] = team;
				}

				mTeams = teams;
				mRoundDuration = br.ReadInt32();
				mMaximumPasses = br.ReadInt32();
				mCategories = new string[br.ReadInt32()];
				for (int i = 0; i < mCategories.Length; i++)
					mCategories[i] = br.ReadString();
				mPlayedRounds = br.ReadInt32();
				mCurrentTeamGo = br.ReadInt32();

				InitialiseBags();
			} finally {
				if (br != null)
					br.Close();
				if (fs != null)
					fs.Close();
			}
		}

		public void SaveGame()
		{
			FileStream fs = null;
			BinaryWriter bw = null;

			try {
				fs = new FileStream("save.dat", FileMode.Create);
				bw = new BinaryWriter(fs);

				bw.Write(mTeams.Length);
				foreach (Team team in mTeams) {
					bw.Write(team.Name);
					bw.Write(team.Players.Count);
					foreach (Player player in team) {
						bw.Write(player.Name);
						bw.Write(player.Correct);
						bw.Write(player.Pass);
						bw.Write(player.Foul);
						bw.Write(player.Turns);
					}
					bw.Write(team.PlayerGoIndex);
				}

				bw.Write(mRoundDuration);
				bw.Write(mMaximumPasses);
				bw.Write(mCategories.Length);
				foreach (string category in mCategories)
					bw.Write(category);
				bw.Write(mPlayedRounds);
				bw.Write(mCurrentTeamGo);
			} catch {

			} finally {
				if (bw != null)
					bw.Close();
				if (fs != null)
					fs.Close();
			}
		}

		public void InitialiseBags()
		{
			mBags.Clear();
			foreach (string category in mCategories)
				mBags.Add(new Bag(category));
			RandomizeCurrentBag();
		}

		public void RandomizeCurrentBag()
		{
			mCurrentBagIndex = mRandom.Next(mBags.Count);
		}

		public void FinishGame()
		{
			try {
				if (File.Exists("save.dat"))
					File.Delete("save.dat");
			} catch {

			}
		}

		public void NextTeam()
		{
			mTeams[mCurrentTeamGo].NextPlayer();
			mCurrentTeamGo = (mCurrentTeamGo + 1) % mTeams.Length;
		}

		public Bag CurrentBag
		{
			get
			{
				return mBags[mCurrentBagIndex];
			}
		}

		public Team CurrentTeam
		{
			get
			{
				return mTeams[mCurrentTeamGo];
			}
		}

		public Player CurrentPlayer
		{
			get
			{
				return mTeams[mCurrentTeamGo].PlayerGo;
			}
		}

		public Team[] Teams
		{
			get
			{
				return mTeams;
			}
			set
			{
				mTeams = value;
			}
		}

		public int RoundDuration
		{
			get
			{
				return mRoundDuration;
			}
			set
			{
				mRoundDuration = value;
			}
		}

		public int MaximumPasses
		{
			get
			{
				return mMaximumPasses;
			}
			set
			{
				mMaximumPasses = value;
			}
		}

		public string[] Categories
		{
			get
			{
				return mCategories;
			}
			set
			{
				mCategories = value;
			}
		}

		public int PlayedRounds
		{
			get
			{
				return mPlayedRounds;
			}
			set
			{
				mPlayedRounds = value;
			}
		}

		public static bool ResumeGamePossible
		{
			get
			{
				return File.Exists("save.dat");
			}
		}
	}
}
