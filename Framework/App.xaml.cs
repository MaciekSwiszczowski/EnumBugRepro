using System.Globalization;
using System.Threading;
using System.Windows;

namespace Framework
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("En-US");
        }
    }
}
