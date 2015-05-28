using System;
using System.Threading.Tasks;

namespace AmazonHtmlMailTesting
{
    public static class ActionExtensions
    {
        public static async void DelayFor(this Action act, TimeSpan delay)
        {
            await Task.Delay(delay);
            act();
        }
    }
}