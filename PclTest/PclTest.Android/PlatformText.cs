using PclTest.Pcl;

namespace PclTest.Android
{
    public class PlatformText : IPlatformText
    {
        public string GetSomeText()
        {
            return "Some Android Text";
        }
    }
}