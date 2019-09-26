using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using ListExperit.Model;

namespace ListExperit.ViewModel
{
    public class StudentViewModel : ViewModelBase
    {

        public StudentViewModel() {
            if (IsInDesignMode)
            {
                StudentModel = new StudentModel() { Id = 1, Name = "John" };

            }
            else {
                StudentModel = new StudentModel() { Id = 2, Name = "smith" };
            }
        }

        public StudentModel StudentModel { get; set; }
    }
}
