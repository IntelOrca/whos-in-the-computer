using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WITC
{
	enum Sounds
	{
		Correct,
		Pass,
		Foul,
		Tick,
		Bell,
		Count,
	}

	struct RegSettings
	{
		public int mTurnTime;
		public int mMaxPasses;
		public bool mObjRounds;
		public bool mObjTime;
		public int mRounds;
		public int mGameTime;
		public string mCategory;
		public bool mResetCards;
		public int mCorrect;
		public int mPass;
		public int mFoul;
		public bool mSounds;
	}

	static class WITC
	{
		public const string PATH_CARD_BANK = "save\\cards.csv";
		public const string PATH_USED_BANK = "save\\used.csv";
		public const string PATH_SAVED_GAME = "save\\game.sav";
		public const string PATH_CFG = "save\\options.cfg";

		public static void Init()
		{
			mSettings.mTurnTime = 60;
			mSettings.mMaxPasses = 3;
			mSettings.mObjRounds = false;
			mSettings.mObjTime = false;
			mSettings.mRounds = 10;
			mSettings.mGameTime = 10;
			mSettings.mCategory = String.Empty;
			mSettings.mResetCards = false;
			mSettings.mCorrect = 1;
			mSettings.mPass = 0;
			mSettings.mFoul = -1;
			mSettings.mSounds = true;

			try {
				LoadSettings();
				InitSounds();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		public static void Close()
		{
			try {
				SaveSettings();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		#region Setting Stuff

		public static RegSettings mSettings;

		public static void LoadSettings()
		{
			FileStream fs = null;
			BinaryReader br = null;

			try {
				fs = new FileStream(PATH_CFG, FileMode.Open);
				br = new BinaryReader(fs);

				mSettings.mTurnTime = br.ReadInt32();
				mSettings.mMaxPasses = br.ReadInt32();
				mSettings.mObjRounds = br.ReadBoolean();
				mSettings.mObjTime = br.ReadBoolean();
				mSettings.mRounds = br.ReadInt32();
				mSettings.mGameTime = br.ReadInt32();
				mSettings.mCategory = br.ReadString();
				mSettings.mResetCards = br.ReadBoolean();

				mSettings.mCorrect = br.ReadInt32();
				mSettings.mPass = br.ReadInt32();
				mSettings.mFoul = br.ReadInt32();

				mSettings.mSounds = br.ReadBoolean();
			} catch {

			} finally {
				if (br != null)
					br.Close();

				if (fs != null)
					fs.Close();
			}
		}

		public static void SaveSettings()
		{
			if (mSettings.mCategory == null)
				mSettings.mCategory = String.Empty;

			try {
				FileStream fs = new FileStream(PATH_CFG, FileMode.Create);
				BinaryWriter bw = new BinaryWriter(fs);

				bw.Write(mSettings.mTurnTime);
				bw.Write(mSettings.mMaxPasses);
				bw.Write(mSettings.mObjRounds);
				bw.Write(mSettings.mObjTime);
				bw.Write(mSettings.mRounds);
				bw.Write(mSettings.mGameTime);
				bw.Write(mSettings.mCategory);
				bw.Write(mSettings.mResetCards);

				bw.Write(mSettings.mCorrect);
				bw.Write(mSettings.mPass);
				bw.Write(mSettings.mFoul);

				bw.Write(mSettings.mSounds);

				bw.Close();
				fs.Close();
			} catch {

			}
		}

		static RegistryKey GetRegKey()
		{
			RegistryKey regkey =
				Registry.LocalMachine.CreateSubKey("Software\\TedTycoon");
			regkey = regkey.CreateSubKey("WITC");
			return regkey;
		}

		#endregion

		#region Sound Stuff

		public static SoundPlayer[] SoundBuffers = new SoundPlayer[(int)Sounds.Count];
		public static string []SoundFilenames = {
			"correct.wav",
			"pass.wav",
			"foul.wav",
			"tick.wav",
			"bell.wav",
		};

		public static void InitSounds()
		{
			for (int i = 0; i < (int)Sounds.Count; i++) {
				SoundBuffers[i] = new SoundPlayer();
				SoundBuffers[i].SoundLocation =
					"data\\" + SoundFilenames[i];
			}
		}

		public static void PlaySound(Sounds sound)
		{
			if (!mSettings.mSounds)
				return;
			int i = (int)sound;
			if (File.Exists(SoundBuffers[i].SoundLocation))
				SoundBuffers[i].Play();
		}

		#endregion
	}
}
