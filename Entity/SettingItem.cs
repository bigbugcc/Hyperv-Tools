using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace Hyperv_Tools.Entity
{
    public class SettingItem: ReactiveObject
    {
        private string _name;
        private string _description;
        private string _icon;

        public string Name
        {
            get { return _name; }
            set 
            { 
                //SetProperty(ref _name, value); 
            }
        }

        public string Description{ get;set;}

        public string Icon
        {
            get { return _icon; }
            set
            {
                //SetProperty(ref _icon, value);
            }
        }
    }
}
