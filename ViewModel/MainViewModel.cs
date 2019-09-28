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
        public MainViewModel()
        {

        }



    }
}