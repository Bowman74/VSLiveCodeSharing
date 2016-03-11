using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641
using Autofac;
using PclTest.Pcl;

namespace PclTest.WP
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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var container = new ContainerBuilder();

            container.RegisterType<PlatformText>().AsImplementedInterfaces();

            IoC.Container = container.Build();

            var pclText = new PclText();
            lblPclText.Text = pclText.GetSomeText();
            lblPlatformText.Text = pclText.GetPlatformText();
        }
    }
}
