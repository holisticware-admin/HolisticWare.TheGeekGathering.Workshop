using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Calculator
{
	[BaseType (typeof (NSObject))]
	public partial interface Calculator {

		[Export ("addNumber:withNumber:")]
		int AddNumber (int firstNumber, int secondNumber);

		[Export ("firstNumber:isEqualToSecondNumber:")]
		bool FirstNumber (int numberA, int numberB);
	}
}

