using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperv_Tools.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Hyperv_Tools.Modeles
{
    public class SettingItem: BaseViewModel
    {
        [Reactive]
        public string Name { get; set; } = string.Empty;

        [Reactive]
        public string Description { get; set; } = string.Empty;
    }
}
