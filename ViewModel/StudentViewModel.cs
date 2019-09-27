using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ListExperit.Model;

namespace ListExperit.ViewModel
{
    public class StudentViewModel : BasePage
    {

        private StudentModel _studentModel;
        public StudentViewModel() {
            //GuiConfigLocator locator = (GuiConfigLocator)Application.Current.Resources["Locator"];
            //MainViewModel m = locator.Main;
            //if (IsInDesignMode)
            //{
            //    StudentModel = new StudentModel() { Id = locator.LocalSocks , Name = locator.LocalHttp.ToString() };
            //}
            //else
            //{
            //    StudentModel = new StudentModel() { Id = locator.LocalHttp , Name = locator.LocalSocks.ToString() };
            //}

            //this.ParentViewModel = locator.Main;
            //this.ParentViewModel.CurrentPage = this;
        }

        public StudentModel StudentModel
        {
            get
            {
                ViewModelLocator locator = (ViewModelLocator)Application.Current.Resources["Locator"];
                MainViewModel mainViewModel = locator.Main;
                _studentModel = mainViewModel.Student;
                return _studentModel;
            }
            set
            {
                _studentModel = value;
            }
        }
        //private RelayCommand _switchCmd;
        //public RelayCommand SwitchCmd
        //{
        //    get
        //    {
        //        if (_switchCmd == null) return new RelayCommand(() => ExecuteCmd());
        //        return SwitchCmd;
        //    }
        //    set
        //    {
        //        _switchCmd = value;
        //    }
        //}

        //private void ExecuteCmd()
        //{
        //    NodeListViewModel nodeLsitViewModel = ((ViewModelLocator)Application.Current.Resources["Locator"]).NodeList;
        //    ((MainViewModel)this.ParentViewModel).CurrentPage = nodeLsitViewModel;
        //}

    }

}
