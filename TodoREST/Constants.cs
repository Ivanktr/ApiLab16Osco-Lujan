using Xamarin.Forms;

namespace TodoREST
{
    public static class Constants
    {
        // URL of REST service
        public static string RestUrl = Device.RuntimePlatform == Device.Android ? "http://127.0.0.1:3000/personas/{0}" : "http://localhost:3000/personas/{0}";
        //public static string RestUrl = "http://localhost:3000/personas/{0}";

    }
}
