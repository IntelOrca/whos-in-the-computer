////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System.IO;

namespace IntelOrca.WITC
{
	class Settings
	{
		private int mCorrectScore = 1;
		private int mPassScore = 0;
		private int mFoulScore = -2;
		private bool mEnableSounds = true;

		public bool Load()
		{
			bool success = false;
			FileStream fs = null;
			BinaryReader br = null;

			try {
				fs = new FileStream("witc.cfg", FileMode.Open);
				br = new BinaryReader(fs);

				mCorrectScore = br.ReadInt32();
				mPassScore = br.ReadInt32();
				mFoulScore = br.ReadInt32();
				mEnableSounds = br.ReadBoolean();

				success = true;
			} catch {
				
			} finally {
				if (br != null)
					br.Close();
				if (fs != null)
					fs.Close();
			}

			return success;
		}

		public bool Save()
		{
			bool success = false;
			FileStream fs = null;
			BinaryWriter bw = null;

			try {
				fs = new FileStream("witc.cfg", FileMode.Create);
				bw = new BinaryWriter(fs);

				bw.Write(mCorrectScore);
				bw.Write(mPassScore);
				bw.Write(mFoulScore);
				bw.Write(mEnableSounds);

				success = true;
			} catch {

			} finally {
				if (bw != null)
					bw.Close();
				if (fs != null)
					fs.Close();
			}

			return success;
		}

		public int CorrectScore
		{
			get
			{
				return mCorrectScore;
			}
			set
			{
				mCorrectScore = value;
			}
		}

		public int PassScore
		{
			get
			{
				return mPassScore;
			}
			set
			{
				mPassScore = value;
			}
		}

		public int FoulScore
		{
			get
			{
				return mFoulScore;
			}
			set
			{
				mFoulScore = value;
			}
		}

		public bool EnableSounds
		{
			get
			{
				return mEnableSounds;
			}
			set
			{
				mEnableSounds = value;
			}
		}
	}
}
