using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace xib
{
	public partial class xibViewController : UIViewController
	{
		public xibViewController () : base ("xibViewController", null)
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
			this.NavigationItem.Title = "VIEW A";

			//outlet plus event
			buttonGoToViewB.TouchUpInside += (object sender, EventArgs e) => {

				ViewControllerB vcB = new ViewControllerB();
				this.NavigationController.PushViewController(vcB,true);
			};
		
		}

		//action
		partial void buttonGoToViewC (NSObject sender)
		{
			ViewControllerC vcC = new ViewControllerC();
			UINavigationController navController = new UINavigationController(vcC);
			this.NavigationController.PresentViewController(navController,true,null);
		}
	}
}

