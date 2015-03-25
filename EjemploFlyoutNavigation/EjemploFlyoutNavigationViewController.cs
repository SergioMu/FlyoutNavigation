using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using FlyoutNavigation;
using MonoTouch.Dialog;

namespace EjemploFlyoutNavigation
{
	public partial class EjemploFlyoutNavigationViewController : UIViewController
	{
		public EjemploFlyoutNavigationViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			var LateralBar = new FlyoutNavigationController {
				NavigationRoot = new RootElement("Menu"){ 
					new Section("Seccion 1"){
						new StringElement("Inicio"),
						new StringElement("Botón"),
						new StringElement("Imágen"),
					},
					new Section("Seccion 2"){
						new StringElement("Texto"),
					},
				},
				ViewControllers = new [] {
					new UIViewController{View=new UILabel{
							Text = "Este es el inicio."
						}},
					new Controller_Btn(),
					new Controller_Img(),
					new Controller_Text()
				}
			};

			LateralBar.ToggleMenu();
			View.AddSubview (LateralBar.View);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

