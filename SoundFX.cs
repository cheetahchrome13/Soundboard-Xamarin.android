using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Soundboard
{
	class SoundFX
	{
		protected static MediaPlayer player;

		/// <summary>
		/// Plays mp3 corresponding to resource id param
		/// </summary>
		/// <param name="context"></param>
		/// <param name="resourceId"></param>
		public static void PlayClip(Context context, int resourceId)
		{
			if (player == null)
			{
				player = MediaPlayer.Create(context, resourceId);
				player.Start();
			}
			else
			{
				player.Reset();
				player = MediaPlayer.Create(context, resourceId);
				player.Start();
			}
		}
	}
}