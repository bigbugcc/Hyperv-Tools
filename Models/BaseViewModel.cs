using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperv_Tools.Models
{
    public class BaseViewModel : ReactiveObject
    {
        [Reactive]
        public string? Title { get; set; } = string.Empty;

        [Reactive]
        public string? Description { get; set; } = string.Empty;

        [Reactive]
        public string? Icon { get; set; } = string.Empty;

        [Reactive]
        public string? Image { get; set; } = string.Empty;
    }
}
