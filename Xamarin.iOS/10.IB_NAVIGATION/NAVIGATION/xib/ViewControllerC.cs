using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace xib
{
	public partial class ViewControllerC : UIViewController
	{
		public ViewControllerC () : base ("ViewControllerC", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "VIEW C";

			UIBarButtonItem dismissButton = new UIBarButtonItem (UIBarButtonSystemItem.Done);
			dismissButton.Clicked += (object sender, EventArgs e) => {

				DismissViewController(true,null);
			};

			this.NavigationItem.LeftBarButtonItem = dismissButton;
		}
	}
}

