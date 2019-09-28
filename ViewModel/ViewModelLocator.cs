/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:ListExperit"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace ListExperit.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        GuiConfigViewModel _guiConfigViewModel;
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //if (ViewModelBase.IsInDesignModeStatic)
            //{
            //    // Create design time view services and models
            //    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            //}
            //else
            //{
            //    // Create run time view services and models
            //    SimpleIoc.Default.Register<IDataService, DataService>();
            //}
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<StudentViewModel>();
            SimpleIoc.Default.Register<NodeListViewModel>();
            _guiConfigViewModel = new GuiConfigViewModel();
        }

        public MainViewModel Main
        {
            get
            {

                MainViewModel mainViewModel = ServiceLocator.Current.GetInstance<MainViewModel>();
                if (mainViewModel.CurrentPage == null) {
                    mainViewModel.CurrentPage = ServiceLocator.Current.GetInstance<StudentViewModel>();
                    //mainViewModel.CurrentPage = ServiceLocator.Current.GetInstance<NodeListViewModel>();
                }
                return mainViewModel;
            }
        }

        public StudentViewModel Student
        {
            get
            {
                StudentViewModel studentViewModel = ServiceLocator.Current.GetInstance<StudentViewModel>();
                if (studentViewModel.ParentViewModel == null) {
                    studentViewModel.ParentViewModel = ServiceLocator.Current.GetInstance<MainViewModel>();
                }
                if (studentViewModel.StudentModel == null) {
                    studentViewModel.StudentModel = _guiConfigViewModel.Student;
                }
                return studentViewModel;
            }
        }

        public NodeListViewModel NodeList
        {
            get
            {
                NodeListViewModel nodeListViewModel = ServiceLocator.Current.GetInstance<NodeListViewModel>();
                if (nodeListViewModel.ParentViewModel == null) {
                    nodeListViewModel.ParentViewModel = ServiceLocator.Current.GetInstance<MainViewModel>();
                }
                if (nodeListViewModel.NodeListModel == null) {
                    nodeListViewModel.NodeListModel = _guiConfigViewModel.NodeList;
                }
                return nodeListViewModel;
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}