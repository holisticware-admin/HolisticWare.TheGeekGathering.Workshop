//
//  Calculator.h
//  SimpleBindingExample
//
//  Created by iki on 10/5/13.
//  Copyright (c) 2013 iki. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Calculator : NSObject

- (int)addNumber:(int)firstNumber withNumber:(int)secondNumber;
- (BOOL)firstNumber:(int)numberA isEqualToSecondNumber:(int)numberB;

@end
