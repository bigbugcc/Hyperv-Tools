using Hyperv_Tools.Resources;
using Hyperv_Tools.Views.Dialog;
using MaterialDesignThemes.Wpf;
using System.Configuration;
using System.Data;
using System.Security.Principal;
using System.Windows;

namespace Hyperv_Tools
{
    public partial class App : Application
    {
        public App()
        {
            ChechAdmin();
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
