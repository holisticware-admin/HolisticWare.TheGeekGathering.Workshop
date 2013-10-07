// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace ImageFiltering
{
	[Register ("ImageFilteringViewController")]
	partial class ImageFilteringViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider slider { get; set; }

		[Action ("buttonActionGrayScale:")]
		partial void buttonActionGrayScale (MonoTouch.Foundation.NSObject sender);

		[Action ("buttonActionOldImage:")]
		partial void buttonActionOldImage (MonoTouch.Foundation.NSObject sender);

		[Action ("buttonActionRestoreImage:")]
		partial void buttonActionRestoreImage (MonoTouch.Foundation.NSObject sender);

		[Action ("buttonActionTapToLoadImage:")]
		partial void buttonActionTapToLoadImage (MonoTouch.Foundation.NSObject sender);

		[Action ("sliderValueChanged:")]
		partial void sliderValueChanged (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}
		}
	}
}
