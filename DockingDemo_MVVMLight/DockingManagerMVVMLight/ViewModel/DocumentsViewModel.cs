﻿using DockingAdapterMVVM;
using Syncfusion.Windows.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockingManagerMVVMLight.ViewModel
{
    public class DocumentsViewModel : PaneViewModel
    {
        public DocumentsViewModel()
        {
            Header = "All Documents";
        }

        public void RaiseDocumentsPropertyChanged()
        {
            RaisePropertyChanged("Documents");
        }

        public IEnumerable<IDockElement> Documents
        {
            get
            {
                return from IDockElement document in MainViewModel.Workspaces
                       where document.State == DockingAdapterMVVM.DockState.Document
                       select document;
            }
        }

    }
}
