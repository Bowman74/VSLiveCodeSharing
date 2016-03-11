using Foundation;
using System;
using System.CodeDom.Compiler;
using Autofac;
using PclTest.Pcl;
using UIKit;

namespace PclTest.Ios
{
	partial class MainViewController : UIViewController
	{
		public MainViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewDidLoad()
	    {
	        base.ViewDidLoad();

            var container = new ContainerBuilder();

            container.RegisterType<PlatformText>().AsImplementedInterfaces();

            IoC.Container = container.Build();

            var pclText = new PclText();
            lblPclText.Text = pclText.GetSomeText();
            lblPlatformText.Text = pclText.GetPlatformText();
        }
	}
}
