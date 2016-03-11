using Android.App;
using Android.OS;
using Android.Widget;

namespace CodeLinking.Android
{
    [Activity(Label = "CodeLinking.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var lblLinking = FindViewById<TextView>(Resource.Id.lblLinking);
            var linkingClass = new PoundIfText();
            lblLinking.Text = linkingClass.GetSomeText();

            var lblPartial = FindViewById<TextView>(Resource.Id.lblPartial);
            var partialClass = new PartialClassText();
            lblPartial.Text = partialClass.GetSomeText();
        }
    }
}

