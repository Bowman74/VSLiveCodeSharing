using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CodeLinking.iOS
{
	partial class MainViewController : UIViewController
	{
		public MainViewController (IntPtr handle) : base (handle)
		{
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var linkingClass = new PoundIfText();
            lblLinking.Text = linkingClass.GetSomeText();

            var partialClass = new PartialClassText();
            lblPartial.Text = partialClass.GetSomeText();
        }
    }
}
