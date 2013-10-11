//
//  ViewController.m
//  DELEGATION_PROTOCOLS
//
//  Created by iki on 10/11/13.
//  Copyright (c) 2013 iki. All rights reserved.
//

#import "ViewController.h"

@interface ViewController () <UITextFieldDelegate,UIAlertViewDelegate>

@property (weak, nonatomic) IBOutlet UITextField *textField;
@property (weak, nonatomic) IBOutlet UIButton *buttonAlert;

@end

@implementation ViewController

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view, typically from a nib.
    
    //UITextField
    //self.textField.delegate = self;
    
    //UIButton
    [self.buttonAlert addTarget:self action:@selector(buttonClicked:) forControlEvents:UIControlEventTouchUpInside];
}

//UITextField delegate
- (BOOL)textFieldShouldReturn:(UITextField *)textField
{
    [textField resignFirstResponder];
    return YES;
}

//UIALertView delegate
- (void)alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{
    if (buttonIndex == 0) {
        NSLog(@"\nClicked button at index 0, usually OK or Cancel");
    }

}

//UIButtonAction
- (IBAction)buttonClicked:(id)sender
{
    UIAlertView *alertButtonClicked = [[UIAlertView alloc] initWithTitle:@"" message:@"AAAAAA" delegate:self cancelButtonTitle:@"OK" otherButtonTitles:nil, nil];
    [alertButtonClicked show];

}
@end





