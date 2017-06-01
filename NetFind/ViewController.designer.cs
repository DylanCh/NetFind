// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NetFind
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton button { get; set; }

		[Outlet]
		AppKit.NSButton button1 { get; set; }

		[Outlet]
		AppKit.NSImageView image { get; set; }

		[Outlet]
		AppKit.NSView mainView { get; set; }

		[Outlet]
		AppKit.NSTextField textBox { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (mainView != null) {
				mainView.Dispose ();
				mainView = null;
			}

			if (button != null) {
				button.Dispose ();
				button = null;
			}

			if (button1 != null) {
				button1.Dispose ();
				button1 = null;
			}

			if (image != null) {
				image.Dispose ();
				image = null;
			}

			if (textBox != null) {
				textBox.Dispose ();
				textBox = null;
			}
		}
	}
}
