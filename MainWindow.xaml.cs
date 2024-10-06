using DynamicData;
using Hyperv_Tools.Entity;
using Hyperv_Tools.Tools;
using MaterialDesignThemes.Wpf;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hyperv_Tools
{
    public partial class MainWindow : Window
    {
        //Init dialog components
        private DialogTools dialog = new DialogTools();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Test_Click(object sender, RoutedEventArgs e)
        {
            //dialog.PromptDialog(Hyperv_Tools.Resources.Lang.Test);
        }
    }
}
