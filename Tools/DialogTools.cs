using Hyperv_Tools.Views.Dialog;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Hyperv_Tools.Tools
{
    //Dialog Tools
    public class DialogTools
    {
        private PromptDialog sampleDialog;
        public DialogTools()
        {
            sampleDialog = new PromptDialog() { 
                DataContext = new {
                    Title = "XXX",
                    Message = "Message",
                    OkButton = "OK",
                }
            };
        }

        //Sample Message Dialog
        public async void PromptDialog(string message)
        {
            sampleDialog.DataContext = new
            {
                Title = "XXX",
                Message = message,
                OkButton = "OK",
            };
            await DialogHost.Show(sampleDialog, "MainRoot");
        }

        //Message Bar
        public void MessageSnackbar(SnackbarMessageQueue messageQueue, string Mes, double time = 1)
        {
            try
            {
                messageQueue.Enqueue(Mes, null, null, null, false, true, TimeSpan.FromSeconds(time));
            }
            catch (Exception ex)
            {
                Console.WriteLine("SnackBarMessage:" + ex.Message);
            }
        }
    }
}

