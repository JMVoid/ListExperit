using GalaSoft.MvvmLight;
using ListExperit.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace ListExperit.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        private BasePage _currentPage;

        public BasePage CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (this._currentPage != value) {
                    _currentPage = value;
                    RaisePropertyChanged(() => CurrentPage);
                }

            }
        }
        private GuiConfig _guiConfig;
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ObservableCollection<Node> nodeList = new ObservableCollection<Model.Node>()
            {
                    new Node() {Activate=true, NodeAddr="hk01f.bitstunnel.online", NodePort=10080, NodeGroup="bitstunnel"},
                    new Node() {Activate=false, NodeAddr="hk02f.bitstunnel.online", NodePort= 7071, NodeGroup="bitstunnel"}
             };

            StudentModel studentModel = new StudentModel() { Id = 1, Name = "John" };

            _guiConfig = new GuiConfig()
            {
                LocalSocks = 7071,
                LocalHttp = 7072,
                Index = 1,
                LogLevel = "Warning",
                NodeList = nodeList,
                StudentModel = studentModel
            };
            this.CurrentPage = new StudentViewModel();
        }
        public StudentModel Student {
            get
            {
                return _guiConfig.StudentModel;
            }
            set {
                _guiConfig.StudentModel = value;
            }
        }


    }
}