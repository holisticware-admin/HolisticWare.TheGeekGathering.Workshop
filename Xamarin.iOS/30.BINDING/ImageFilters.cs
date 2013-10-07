using System;

using MonoTouch.Foundation;

namespace HolisticWare {

	[BaseType (typeof (NSObject))]
	public partial interface ImageFilters {

		[Export ("originalImage")]
		UIImage OriginalImage { get; }

		[Export ("initWithImage:")]
		IntPtr Constructor (UIImage image);

		[Export ("grayScaleImage")]
		UIImage GrayScaleImage { get; }

		[Export ("oldImageWithIntensity:")]
		UIImage OldImageWithIntensity (float level);
	}
}
