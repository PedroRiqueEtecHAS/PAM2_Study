using CommunityToolkit.Mvvm.ComponentModel;
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
        ObservableCollection<Monitor> Monitores { get; set; };
        private readonly MonitorViewModel monitorService;
        [ObservableObject]
    }
}
