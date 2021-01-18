using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AUCaptureInstaller.Annotations;
using MahApps.Metro.Controls.Dialogs;

namespace AUCaptureInstaller
{
    public class UserDataContext : INotifyPropertyChanged
    {
        public UserDataContext(IDialogCoordinator dialogCoordinator)
        {
            DialogCoordinator = dialogCoordinator;
        }

        public IDialogCoordinator DialogCoordinator { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
