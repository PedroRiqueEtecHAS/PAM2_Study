using CommunityToolkit.Mvvm.ComponentModel;
using PAM2_Study.Services;
using PAM2_Study.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAM2_Study.ViewModels
{
    public partial class MonitorViewModel:ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Models.Monitor> monitores;

        public async void getMonitores()
        {
            monitores = await new MonitorService().getAllMonitorsAsync();
        }
    }
}
