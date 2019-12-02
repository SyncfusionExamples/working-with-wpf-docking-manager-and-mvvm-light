using GalaSoft.MvvmLight;
using DockingManagerMVVMLight.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
using DockingAdapterMVVM;

namespace DockingManagerMVVMLight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });

            Workspaces = new ObservableCollection<Workspace>();

            string exepath = Assembly.GetExecutingAssembly().Location;

            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                Workspaces.Add(new Document() { Path = Path.GetDirectoryName(@"..\..\") + @"\Samples\Sample 1.txt", Header = "Sample 1.txt" });
                Workspaces.Add(new Document() { Header = "Sample 2.txt", Path = Path.GetDirectoryName(@"..\..\") + @"\Samples\Sample 2.txt" });
                Workspaces.Add(new Document() { Header = "Sample 3.txt", Path = Path.GetDirectoryName(@"..\..\") + @"\Samples\Sample 3.txt" });
            }

            PropertiesViewModel = new DockingManagerMVVMLight.ViewModel.PropertiesViewModel() { MainViewModel = this };
            DocumentsViewModel = new DockingManagerMVVMLight.ViewModel.DocumentsViewModel() { MainViewModel = this };

            Workspaces.Add(DocumentsViewModel);
            Workspaces.Add(PropertiesViewModel);
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}

        private ObservableCollection<IDockElement> documents;

        public ObservableCollection<IDockElement> Documents
        {
            get { return documents; }
            set { documents = value; }
        }

        private ObservableCollection<Workspace> workspaces;

        public ObservableCollection<Workspace> Workspaces
        {
            get { return workspaces; }
            set { workspaces = value; }
        }

        private Document activeDocument;

        public Document ActiveDocument
        {
            get { return activeDocument; }
            set { activeDocument = value; RaisePropertyChanged("ActiveDocument"); }
        }

        private PropertiesViewModel propertiesViewModel;

        public PropertiesViewModel PropertiesViewModel
        {
            get { return propertiesViewModel; }
            set { propertiesViewModel = value; }
        }

        private DocumentsViewModel documentsViewModel;

        public DocumentsViewModel DocumentsViewModel
        {
            get { return documentsViewModel; }
            set { documentsViewModel = value; }
        }

        private void OpenDocument()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            if (dialog.ShowDialog().Value)
            {
                Document document = new Document() { Path = dialog.FileName, Header = dialog.SafeFileName };
                Workspaces.Add(document);
                ActiveDocument = document;
                DocumentsViewModel.RaiseDocumentsPropertyChanged();
            }
        }

        private void Exit()
        {
            Application.Current.MainWindow.Close();
        }

        private DelegateCommand<object> openDocumentCommand;

        public DelegateCommand<object> OpenDocumentCommand
        {
            get
            {
                if (openDocumentCommand == null)
                {
                    openDocumentCommand = new DelegateCommand<object>(param => OpenDocument());
                }
                return openDocumentCommand;
            }
        }

        private DelegateCommand<object> closeCommand;

        public DelegateCommand<object> CloseCommand
        {
            get
            {
                if (closeCommand == null)
                {
                    closeCommand = new DelegateCommand<object>(param => Exit());
                }
                return closeCommand;
            }
        }
    }
}