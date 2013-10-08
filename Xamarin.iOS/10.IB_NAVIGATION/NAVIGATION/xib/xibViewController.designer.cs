// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace xib
{
	[Register ("xibViewController")]
	partial class xibViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonGoToViewB { get; set; }

		[Action ("buttonGoToViewC:")]
		partial void buttonGoToViewC (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonGoToViewB != null) {
				buttonGoToViewB.Dispose ();
				buttonGoToViewB = null;
			}
		}
	}
}
