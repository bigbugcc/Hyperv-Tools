using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Resources;
using System.Threading.Tasks;

namespace Hyperv_Tools.Resources
{
    public class LanguageManager : INotifyPropertyChanged
    {
        private readonly ResourceManager _resourceManager;
        
        public static LanguageManager Instance => _lazy.Value;

        public event PropertyChangedEventHandler PropertyChanged;

        private static readonly Lazy<LanguageManager> _lazy = new Lazy<LanguageManager>(() => new LanguageManager());

        public LanguageManager()
        {
            // _resourceManager = new ComponentResourceManager(typeof(LanguageResource));
            _resourceManager = new ResourceManager("Hyperv_Tools.Resources.Lang", typeof(LanguageManager).Assembly);
        }

        public string this[string name]
        {
            get
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                return _resourceManager.GetString(name);
            }
        }

        public void ChangeLanguage(CultureInfo cultureInfo)
        {
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("item[]"));
        }
    }
}
