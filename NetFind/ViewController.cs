using System;

using AppKit;
using Foundation;

namespace NetFind
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			button.Activated += (object sender, EventArgs e) =>
			{
				var dlg = NSOpenPanel.OpenPanel;
				dlg.CanChooseFiles = true;
				dlg.CanChooseDirectories = false;
				dlg.AllowedFileTypes = new string[] { "jpg", "bmp", "png", "gif" };

				if (dlg.RunModal() == 1)
				{
					// Nab the first file
					var url = dlg.Urls[0];

					if (url != null)
					{
						var path = url.Path;
						textBox.StringValue = path;
						image.Image = new NSImage(path);
					}
				} //  end if
			};
		}

		public override void ViewDidAppear()
		{
			base.ViewDidAppear();
			mainView.Window.Title = "NetFind";
		}
	}// end class
}
