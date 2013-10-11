using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidApplication1
{
	[Activity(Label = "AndroidApplication1", MainLauncher = true, Icon = "@drawable/icon")]
	public class ActivityMain : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.TableLayout);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.buttonAddition);

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}


		# region    Navigation
		//-------------------------------------------------------------------------
		//-------------------------------------------------------------------------
		# endregion Navigation
	
	}
}

