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
	[Register ("Controller_Btn")]
	partial class Controller_Btn
	{
		[Action ("btnPulsame:")]
		partial void btnPulsame (MonoTouch.Foundation.NSObject sender);

		partial void btnPulsame (MonoTouch.Foundation.NSObject sender){

			new UIAlertView("Alerta!!!",
				"Has pulsado el botón", null, "ok", null).Show();

		}

		void ReleaseDesignerOutlets ()
		{
		}
	}
}
