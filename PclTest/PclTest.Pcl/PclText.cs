using Autofac;

namespace PclTest.Pcl
{
    public class PclText
    {
        public string GetSomeText()
        {
            return "Some Shared Text";
        }

        public string GetPlatformText()
        {
            return IoC.Container.Resolve<IPlatformText>().GetSomeText();
        }
    }
}
