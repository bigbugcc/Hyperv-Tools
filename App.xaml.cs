using Hyperv_Tools.Resources;
using System.Globalization;
using System.Security.Principal;
using System.Windows;

namespace Hyperv_Tools
{
    public partial class App : Application
    {
        public App()
        {
            AutoLanguage();
            ChechAdmin();
        }

        private void AutoLanguage()
        {
            string lang = Convert.ToString(Thread.CurrentThread.CurrentCulture.Name);
            if (!lang.Equals("zh-CN"))
            {
                lang = "en-US";
            }
            LanguageManager.Instance.ChangeLanguage(new CultureInfo(lang));
        }

        private void ChechAdmin() {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                this.Shutdown();
                MessageBox.Show(Lang.CheckAdmin);
                return;
            }
        }
    }
}
