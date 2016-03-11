using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Autofac;
using PclTest.Pcl;

namespace PclTest.Android
{
    [Activity(Label = "PclTest.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var container = new ContainerBuilder();

            container.RegisterType<PlatformText>().AsImplementedInterfaces();

            IoC.Container = container.Build();

            var pclText = new PclText();

            var lblPclText= FindViewById<TextView>(Resource.Id.lblPclText);
            lblPclText.Text = pclText.GetSomeText();

            var lblPlatformText = FindViewById<TextView>(Resource.Id.lblPlatformText);
            lblPlatformText.Text = pclText.GetPlatformText();

        }
    }
}

