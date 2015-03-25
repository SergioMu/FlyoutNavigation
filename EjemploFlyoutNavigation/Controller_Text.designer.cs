// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;
using MonoTouch.UIKit;

namespace EjemploFlyoutNavigation
{
	[Register ("Controller_Text")]
	partial class Controller_Text
	{
		[Outlet]
		MonoTouch.UIKit.UITextField txtNombre { get; set; }

		[Action ("btnNombre:")]
		partial void btnNombre (MonoTouch.Foundation.NSObject sender);

		partial void btnNombre (MonoTouch.Foundation.NSObject sender){
			new UIAlertView("Tu nombre es:", txtNombre.Text, null, "ok", null).Show();

		}

		
		void ReleaseDesignerOutlets ()
		{
			if (txtNombre != null) {
				txtNombre.Dispose ();
				txtNombre = null;
			}
		}
	}
}
