using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DELEGATION_PROTOCOLS_C
{
	public partial class DELEGATION_PROTOCOLS_C_ViewController : UIViewController
	{
		public DELEGATION_PROTOCOLS_C_ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			// Solution 1 (nested class)
			//this.textField.Delegate = new TextFieldDelegate();

			// Solution 2
			buttonAlert.TouchUpInside += (object sender, EventArgs e) => 
			{
				UIAlertView alertView = new UIAlertView("ALERT","AAAAAAA",null,"OK");
				alertView.Show();

				alertView.Clicked += (object senderAlertView, UIButtonEventArgs eAlertView) => 
				{
					if(eAlertView.ButtonIndex == 0) {

						System.Console.WriteLine("Button at index 0 touched");
					}

				};


			};

			// Solution 1 (inline,event + )
			this.textField.ShouldReturn += (textField) => { 
				textField.ResignFirstResponder();
				return true; 
			};

		}

	
		#endregion

		public partial class TextFieldDelegate : UITextFieldDelegate
		{

			public override bool ShouldReturn (UITextField textField)
			{
				textField.ResignFirstResponder ();
				return true;
			}

		}
	}


}

