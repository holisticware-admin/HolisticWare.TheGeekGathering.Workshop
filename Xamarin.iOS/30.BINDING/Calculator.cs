using System;

namespace HolisticWare {

	[BaseType (typeof (NSObject))]
	public partial interface Calculator {

		[Export ("AddNumber")]
		int AddNumber (int firstNumber, int secondNumber);

		[Export ("FirstNumber")]
		bool FirstNumber (int numberA, int numberB);
	}
}
