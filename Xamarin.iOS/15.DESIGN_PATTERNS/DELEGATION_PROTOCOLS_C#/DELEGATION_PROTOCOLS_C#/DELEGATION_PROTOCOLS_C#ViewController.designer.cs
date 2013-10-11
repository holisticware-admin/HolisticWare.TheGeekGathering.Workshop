// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace DELEGATION_PROTOCOLS_C
{
	[Register ("DELEGATION_PROTOCOLS_C_ViewController")]
	partial class DELEGATION_PROTOCOLS_C_ViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonAlert { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField textField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}

			if (buttonAlert != null) {
				buttonAlert.Dispose ();
				buttonAlert = null;
			}
		}
	}
}
