// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace IBOutlets_IBActions
{
	[Register ("IBOutlets_IBActionsViewController")]
	partial class IBOutlets_IBActionsViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonClickMe { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelNumberOfClicks { get; set; }

		[Action ("buttonClickMeAction:")]
		partial void buttonClickMeAction (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (labelNumberOfClicks != null) {
				labelNumberOfClicks.Dispose ();
				labelNumberOfClicks = null;
			}

			if (buttonClickMe != null) {
				buttonClickMe.Dispose ();
				buttonClickMe = null;
			}
		}
	}
}
