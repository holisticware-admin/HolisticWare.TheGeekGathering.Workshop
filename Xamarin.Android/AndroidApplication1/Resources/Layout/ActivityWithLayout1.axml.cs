using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace AndroidApplication1.Resources.Layout
{
	[Activity
		(
		// 
		  Label = "ActivityWithLayout1"
		// 
		, MainLauncher = true
		//
		, Icon = "@drawable/icon"
		)
	]
	public
		partial
		class
		ActivityWithLayout1
		:
		Activity
	{

		protected override void OnCreate(Bundle bundle_applicationState)
		{
			// Invoke the base class ctor to bind with Android Activity
			// if not problems might be expected!
			base.OnCreate(bundle_applicationState);

			// Set the view of the activity to resource layout object 
			SetContentView(Resource.Layout.ActivityWithLayout1);

			// The layout contains a button. You can find it using FindViewById.
			// Resource.Id contains every id you used in the resource files.
			Button button1 = FindViewById<Button>(Resource.Id.button1);
			Button button2 = FindViewById<Button>(Resource.Id.button2);

			LoadData();

			//=================================================================
			// 1. classic c# idioms: EventHandling
			button1.Click += new EventHandler(button1_Click);


			// 2. anonymous delegates + type inference
			button2.Click +=
				//delegate (object s, EventArgs e)
					delegate
					{
						Intent i;
						i = new Intent(this, typeof(ActivityWithLayout1));
						StartActivityForResult(i, 42);
					};
			/* 
			 * ================================================================ 
			 * java code
			buttonMediaPlayer1.setOnClickListener
			(
				new View.OnClickListener() 
				{
					public void onClick(View view) 
					{
						Intent i;
						i = new Intent(view.getContext(), ActivityMediaPlayer.class);
						startActivityForResult(intent, 42);
					}
				}
			);
			 * =================================================================
			*/


			return;
		}

		// Just starting activities isn’t the only thing you can do. You can also start an 
		// activity as if it is a dialog and get a result back when the activity is completed. 
		// To do this you need to start the activity using StartActivityForResult and specify 
		// a resultcode to identify the action by. 
		// When the activity is finished you will get the results back in the 
		// OnActivityFinished method that you can override in the parent activity.
		private void button1_Click(object sender, EventArgs e)
		{
			Toast.MakeText(this, "button1", ToastLength.Short).Show();

			return;
		}



		//Inside the OnActivityFinished method you can check the result of the user 
		//action and get any data returned by the activity by invoking Get…Extra methods 
		//on the Intent instance that is returned by the activity after it’s finished.
		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (requestCode == 42)
			{
				if (resultCode == Result.Ok)
				{
					int selectedItem = data.GetIntExtra("Question", 0);
				}
			}

			return;
		}

		// Explicitly finish an Activity by invoking the Finish activity inside the 
		// activity.
		// To return a result to the parent activity you need to use 
		// the SetResult method and call the Finish method directly after that.
		private void button_Click(object sender, EventArgs e)
		{
			Intent intent = new Android.Content.Intent();
			intent.SetClassName(this.ApplicationContext, "MySecondActivity");

			// Place the selected item in the intent     
			intent.PutExtra("Question", 10);

			// Set the result of the activity     
			SetResult(Result.Ok, intent);
			Finish();

			return;
		}




		private void LoadData()
		{


			//=================================================================
			// 3. LINQ
			List<string> data =
				//new List<string>(b.MediaPlayer.PlayList)
				new List<string>()
				;

			string[] data_audio =
				(
				 from d in data
				 where (d.EndsWith(".mp3") || d.EndsWith(".wma"))
				 select d
				 ).ToArray();

			return;
		}

		/// <summary>
		/// Invoked when the OS decides to nominate the activity for cleanup.
		/// </summary>
		/// <param name="applicationState">Container for the application state</param>
		protected override void OnSaveInstanceState(Bundle bundle_applicationState)
		{
			base.OnSaveInstanceState(bundle_applicationState);
			//TODO: Save any information you want to be kept alive in the application state

			return;
		}


		// http://answers.unity3d.com/questions/50944/ho-do-i-read-a-text-file-on-android-and-iphone.html
		// http://answers.unity3d.com/questions/132753/how-do-i-read-xml-on-iphone.html
		// http://stackoverflow.com/questions/2396718/whats-the-best-way-to-store-and-access-xml-in-android
		// http://stackoverflow.com/questions/5815625/failure-install-failed-media-unavailable

	}
}

