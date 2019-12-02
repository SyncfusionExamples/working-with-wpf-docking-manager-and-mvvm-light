using DockingAdapterMVVM;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockingManagerMVVMLight.ViewModel
{
    public class PaneViewModel : Model.Workspace
    {
        public PaneViewModel()
        {
            State = DockState.Dock;
        }

        private MainViewModel viewModel;

        public MainViewModel MainViewModel
        {
            get { return viewModel; }
            set { viewModel = value; }
        }

    }
}
