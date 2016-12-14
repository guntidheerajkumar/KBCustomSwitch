using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace KBCustomSwitch
{
	// @interface KBSwitch : UIControl
	[BaseType(typeof(UIControl))]
	interface KBSwitch
	{
		// @property (nonatomic, strong) NSString * leftTitle;
		[Export("leftTitle", ArgumentSemantic.Strong)]
		string LeftTitle { get; set; }

		// @property (nonatomic, strong) NSString * rightTitle;
		[Export("rightTitle", ArgumentSemantic.Strong)]
		string RightTitle { get; set; }

		// @property (assign, nonatomic) CGFloat selectedBackgroundInset;
		[Export("selectedBackgroundInset")]
		nfloat SelectedBackgroundInset { get; set; }

		// @property (nonatomic, strong) UIColor * selectedBackgroundColor;
		[Export("selectedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor SelectedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * titleColor;
		[Export("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * selectedTitleColor;
		[Export("selectedTitleColor", ArgumentSemantic.Strong)]
		UIColor SelectedTitleColor { get; set; }

		// @property (nonatomic, strong) UIFont * titleFont;
		[Export("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (assign, nonatomic) NSTimeInterval animationDuration;
		[Export("animationDuration")]
		double AnimationDuration { get; set; }

		// @property (assign, nonatomic) CGFloat animationSpringDamping;
		[Export("animationSpringDamping")]
		nfloat AnimationSpringDamping { get; set; }

		// @property (assign, nonatomic) CGFloat animationInitialSpringVelocity;
		[Export("animationInitialSpringVelocity")]
		nfloat AnimationInitialSpringVelocity { get; set; }

		// @property (readonly, assign, nonatomic) NSInteger selectedIndex;
		[Export("selectedIndex")]
		nint SelectedIndex { get; }

		// -(instancetype)initWithLeftTitle:(NSString *)leftTtitle rightTitle:(NSString *)rightTitle;
		[Export("initWithLeftTitle:rightTitle:")]
		IntPtr Constructor(string leftTtitle, string rightTitle);

		// -(void)setSelectedIndex:(NSInteger)selectedIndex animated:(BOOL)animated;
		[Export("setSelectedIndex:animated:")]
		void SetSelectedIndex(nint selectedIndex, bool animated);
	}
}
