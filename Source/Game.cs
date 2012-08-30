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
		private string mCategory;
		private int mPlayedRounds;

		private int mCurrentTeamGo;
		private List<string> mCards = new List<string>();

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
				mCategory = br.ReadString();
				mPlayedRounds = br.ReadInt32();
				mCurrentTeamGo = br.ReadInt32();
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
				bw.Write(mCategory);
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

		public void FinishGame()
		{
			try {
				if (File.Exists("save.dat"))
					File.Delete("save.dat");
			} catch {

			}
		}

		public void FillBag()
		{
			Category allCards = Program.CardBank.Categories[mCategory];
			Category usedCards = Program.CardBank.UsedCards[mCategory];

			if (allCards == null)
				throw new Exception();

			IEnumerable<string> cards = allCards;

			// Remove any cards that have been used before
			if (usedCards != null)
				cards = cards.Except(usedCards);

			// Remove any cards we already have in our bag
			cards = cards.Except(mCards);

			// Check if there are any cards left
			if (cards.Count() == 0) {
				// Clear used cards
				if (usedCards.Count() > 0)
					usedCards.Clear();
			}

			mCards.AddRange(cards);
		}

		public string PopCard()
		{
			if (mCards.Count == 0)
				FillBag();
			if (mCards.Count == 0)
				throw new Exception();

			int ridx = mRandom.Next(0, mCards.Count);
			string card = mCards[ridx];
			mCards.RemoveAt(ridx);
			return card;
		}

		public void PushCard(string card)
		{
			mCards.Add(card);
		}

		public void NextTeam()
		{
			mTeams[mCurrentTeamGo].NextPlayer();
			mCurrentTeamGo = (mCurrentTeamGo + 1) % mTeams.Length;
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

		public string Category
		{
			get
			{
				return mCategory;
			}
			set
			{
				mCategory = value;
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
