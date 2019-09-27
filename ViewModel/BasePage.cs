using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExperit.ViewModel
{
    public class BasePage: ViewModelBase
    {
        private MainViewModel _parentViewModel;
        public MainViewModel ParentViewModel{
            get { return _parentViewModel; }
            set
            {
                _parentViewModel = value;
            }
        }
    }
}
