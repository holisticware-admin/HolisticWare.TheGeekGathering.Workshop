using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using ImageFilters;

namespace ImageFiltering
{
	public partial class ImageFilteringViewController : UIViewController
	{
		ImageFilters.ImageFilters imageFilters;
		UIImagePickerController imagePicker;

		public ImageFilteringViewController (IntPtr handle) : base (handle)
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

			// UIImagePicker
			this.imagePicker = new UIImagePickerController ();
			this.imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			this.imagePicker.Delegate = this;


			this.imagePicker.FinishedPickingMedia += HandleFinishedPickingMedia;
			this.imagePicker.Canceled += HandleCanceled;

		}
		#endregion

		#region UIImagePicker
		void HandleCanceled (object sender, EventArgs e)
		{
			this.imagePicker.DismissViewController (true, null);
		}

		void HandleFinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs e)
		{
			this.imageView.Image = e.OriginalImage;
			this.imagePicker.DismissViewController (true, null);
		}
		#endregion

		#region UIElements Action
		partial void buttonActionTapToLoadImage (NSObject sender)
		{
			this.PresentViewController(this.imagePicker,true,null);
		}

		partial void buttonActionGrayScale (NSObject sender)
		{
			if(this.imageFilters != null) {

				this.imageView.Image = this.imageFilters.OriginalImage;
			}

			this.imageFilters = new ImageFilters.ImageFilters(this.imageView.Image);
			this.imageView.Image = this.imageFilters.GrayScaleImage;
		}

		partial void buttonActionOldImage (NSObject sender)
		{
			if(this.imageFilters != null) {

				this.imageView.Image = this.imageFilters.OriginalImage;
			}

			this.imageFilters = new ImageFilters.ImageFilters(this.imageView.Image);
			this.imageView.Image = this.imageFilters.OldImageWithIntensity(this.slider.Value);

		}

		partial void sliderValueChanged (NSObject sender)
		{
			if(this.imageView.Image != null){

				this.imageView.Image = this.imageFilters.OldImageWithIntensity(this.slider.Value);

			}

		}

		partial void buttonActionRestoreImage (NSObject sender)
		{
			this.imageView.Image = this.imageFilters.OriginalImage;
		}
		#endregion
	
	
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

