// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace M13Demo
{
	[Register ("SecViewController")]
	partial class SecViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Btn_1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Btn_2 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Btn_1 != null) {
				Btn_1.Dispose ();
				Btn_1 = null;
			}
			if (Btn_2 != null) {
				Btn_2.Dispose ();
				Btn_2 = null;
			}
		}
	}
}
