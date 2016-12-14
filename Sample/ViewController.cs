using System;
using CoreGraphics;
using KBCustomSwitch;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.NavigationController.NavigationBar.BarTintColor = UIColor.FromRGBA(255 / 255f, 182 / 255f, 0 / 255f, 1f);
			var switch1 = new KBSwitch("Male", "Female");
			switch1.BackgroundColor = UIColor.FromRGBA(229 / 255f, 163 / 255f, 48 / 255f, 1f);
			switch1.SelectedBackgroundColor = UIColor.White;
			switch1.TintColor = UIColor.White;
			switch1.SelectedTitleColor = UIColor.FromRGBA(255 / 255f, 196 / 255f, 92 / 255f, 1f);
			switch1.TitleFont = UIFont.FromName("HelveticaNeue-Medium", 14f);
			switch1.Frame = new CGRect(30, 70, 200, 30);
			this.NavigationItem.TitleView = switch1;


			var switch2 = new KBSwitch("Male", "Female");
			switch2.BackgroundColor = UIColor.FromRGBA(229 / 255f, 163 / 255f, 48 / 255f, 1f);
			switch2.SelectedBackgroundColor = UIColor.White;
			switch2.TintColor = UIColor.White;
			switch2.SelectedTitleColor = UIColor.FromRGBA(255 / 255f, 196 / 255f, 92 / 255f, 1f);
			switch2.TitleFont = UIFont.FromName("HelveticaNeue-Medium", 14f);
			switch2.Frame = new CGRect(60, 100, 200, 30);
			this.View.AddSubview(switch2);

		}
	}
}
