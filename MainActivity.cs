using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Media;
using System;

namespace Soundboard
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
		public ImageView themeSong;
		public ImageView vivianQuote1;
		public ImageView vivianQuote2;
		public ImageView vivianQuote3;
		public ImageView neilQuote1;
		public ImageView neilQuote2;
		public ImageView rickQuote1;
		public ImageView rickQuote2;
		public ImageView rickQuote3;
		public ImageView mikeQuote1;

		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

			// Logo
			themeSong = FindViewById<ImageView>(Resource.Id.themeSong);
			themeSong.Click += Image_Click;

			// Vivian
			vivianQuote1 = FindViewById<ImageView>(Resource.Id.vivianQuote1);
			vivianQuote1.Click += Image_Click;
			vivianQuote2 = FindViewById<ImageView>(Resource.Id.vivianQuote2);
			vivianQuote2.Click += Image_Click;
			vivianQuote3 = FindViewById<ImageView>(Resource.Id.vivianQuote3);
			vivianQuote3.Click += Image_Click;

			// Neil
			neilQuote1 = FindViewById<ImageView>(Resource.Id.neilQuote1);
			neilQuote1.Click += Image_Click;
			neilQuote2 = FindViewById<ImageView>(Resource.Id.neilQuote2);
			neilQuote2.Click += Image_Click;

			// Rick
			rickQuote1 = FindViewById<ImageView>(Resource.Id.rickQuote1);
			rickQuote1.Click += Image_Click;
			rickQuote2 = FindViewById<ImageView>(Resource.Id.rickQuote2);
			rickQuote2.Click += Image_Click;
			rickQuote3 = FindViewById<ImageView>(Resource.Id.rickQuote3);
			rickQuote3.Click += Image_Click;

			// Mike
			mikeQuote1 = FindViewById<ImageView>(Resource.Id.mikeQuote1);
			mikeQuote1.Click += Image_Click;
		}

		/// <summary>
		/// One click handler for all imageViews
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Image_Click(object sender, EventArgs e)
		{
			// Re-cast sender as ImageView
			ImageView image = sender as ImageView;

			// Get resource id for sender
			int  id = image.Id;

			// Match resource id to proper ImageView
			switch (id)
			{
				case Resource.Id.themeSong:
					SoundFX.PlayClip(this, Resource.Raw.ThemeSong);
					break;
				case Resource.Id.vivianQuote1:
					SoundFX.PlayClip(this, Resource.Raw.VivianPissOffMum);
					break;
				case Resource.Id.vivianQuote2:
					SoundFX.PlayClip(this, Resource.Raw.VivianSmashHisFaceIn);
					break;
				case Resource.Id.vivianQuote3:
					SoundFX.PlayClip(this, Resource.Raw.VivianVideo);
					break;
				case Resource.Id.neilQuote1:
					SoundFX.PlayClip(this, Resource.Raw.NeilHassle);
					break;
				case Resource.Id.neilQuote2:
					SoundFX.PlayClip(this, Resource.Raw.NeilThePigs);
					break;
				case Resource.Id.rickQuote1:
					SoundFX.PlayClip(this, Resource.Raw.RickAcupuncture);
					break;
				case Resource.Id.rickQuote2:
					SoundFX.PlayClip(this, Resource.Raw.RickWhoLikesMe);
					break;
				case Resource.Id.rickQuote3:
					SoundFX.PlayClip(this, Resource.Raw.RickCockadoodledoo);
					break;
				case Resource.Id.mikeQuote1:
					SoundFX.PlayClip(this, Resource.Raw.MikeBoiledEgg);
					break;
				default:
					break;
			}
		}
	}
}