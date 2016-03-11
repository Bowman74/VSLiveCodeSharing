using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Autofac;
using PclTest.Pcl;
using System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PclTest.Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var container = new ContainerBuilder();

            container.RegisterType<PlatformText>().AsImplementedInterfaces();

            IoC.Container = container.Build();

            var pclText = new PclText();
            lblPclText.Text = pclText.GetSomeText();
            lblPlatformText.Text = pclText.GetPlatformText();

            var hasPhone = ApiInformation.IsTypePresent("Windows.ApplicationModel.Calls.CallsPhoneContract");

            if (!hasPhone)
            {
                lblNoPhone.Visibility = Visibility.Visible;
                btnMakeCall.Visibility = Visibility.Collapsed;
                lblNoPhone.Text = "Can't make calls";
            }
            else
            {
                lblNoPhone.Visibility = Visibility.Collapsed;
                btnMakeCall.Visibility = Visibility.Visible;
                btnMakeCall.Click += btnMakeCall_Click;
            }
        }

        private void btnMakeCall_Click(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallSettingsUI();
        }
    }
}
