namespace CodeLinking
{
    public class PoundIfText
    {
        public string GetSomeText()
        {
#if __ANDROID__
            return "Some Android Text";
#elif WINDOWS_PHONE_APP
            return "Some Windows Phone Text";
#elif WINDOWS_UWP
            return "Sone Windows Universal Text";
#elif __IOS__
            return "Some iOS Text";
#endif
        }
    }
}