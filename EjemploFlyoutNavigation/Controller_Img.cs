
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace EjemploFlyoutNavigation
{
	public partial class Controller_Img : UIViewController
	{
		public Controller_Img () : base ("Controller_Img", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CntImg.Image = UIImage.FromFile ("img.jpg");
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

