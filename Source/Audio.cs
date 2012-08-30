////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.IO;
using System.Media;
using IntelOrca.WITC.Properties;

namespace IntelOrca.WITC
{
	static class Audio
	{
		public enum Sounds
		{
			Correct,
			Foul,
			Pass,
			Tick,
			TimeUp,
		}

		public static void PlaySound(Sounds sound)
		{
			if (!Program.Settings.EnableSounds)
				return;

            Stream stream = Resources.ResourceManager.GetStream(sound.ToString().ToLower());
            SoundPlayer sp = new SoundPlayer(stream);
			sp.Play();
		}

		public static void RandomHadFun()
		{
			try {
				// Get random had fun sound
				string[] files = Directory.GetFiles("HadFun", "*.wav");
				int index = new Random().Next(files.Length);

				// Play sound
				SoundPlayer sp = new SoundPlayer(files[index]);
				sp.Play();
			} catch { }
		}
	}
}
