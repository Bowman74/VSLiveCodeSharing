

namespace PortableReferenceLibrary
{
    public class ReferenceTest
    {
        public string GetMessage()
        {
            var messenger = new TestLibrary.Messenger();
            return messenger.GetMessage();
        }
    }
}
