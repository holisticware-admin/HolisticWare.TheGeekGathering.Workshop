using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace IBOutlets_IBActions
{
	public partial class IBOutlets_IBActionsViewController : UIViewController
	{
		int i = 0;

		public IBOutlets_IBActionsViewController (IntPtr handle) : base (handle)
		{
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			//INFO:
			//IBOutlet == creating property of an item
			//IBAction == "Target - Action", event

			//Accessing outlet

			buttonClickMe.TouchUpInside += (object sender, EventArgs e) => {


				labelNumberOfClicks.Text = (++i).ToString();

			};

		}

		//Accessing action
		partial void buttonClickMeAction (NSObject sender)
		{
			labelNumberOfClicks.Text = (++i).ToString();
		}



		#endregion

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

