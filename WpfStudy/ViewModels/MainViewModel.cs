using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.ViewModels
{
     class MainViewModel : INotifyPropertyChanged
    {
        private int progressValue;

        public int ProgressValue
        {
            get { return progressValue; }
            set { progressValue = value;
                  NotifyPropertyChanged(nameof(ProgressValue));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
