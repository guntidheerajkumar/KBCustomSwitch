//
//  KBSwitch.h
//  KBSwitch
//
//  Created by apple on 14/12/16.
//  Copyright © 2016 Dheeraj. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface KBSwitch : UIControl
@property (nonatomic, strong) NSString *leftTitle;
@property (nonatomic, strong) NSString *rightTitle;
@property (nonatomic, assign) CGFloat selectedBackgroundInset;
@property (nonatomic, strong) UIColor *selectedBackgroundColor;
@property (nonatomic, strong) UIColor *titleColor;
@property (nonatomic, strong) UIColor *selectedTitleColor;
@property (nonatomic, strong) UIFont *titleFont;

@property (nonatomic, assign) NSTimeInterval animationDuration;
@property (nonatomic, assign) CGFloat animationSpringDamping;
@property (nonatomic, assign) CGFloat animationInitialSpringVelocity;
@property (nonatomic, assign, readonly) NSInteger selectedIndex;

- (instancetype)initWithLeftTitle:(NSString*)leftTtitle rightTitle:(NSString*)rightTitle;
- (void)setSelectedIndex:(NSInteger)selectedIndex animated:(BOOL)animated;
@end
