using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ListExperit.Model
{
    public class StudentModel: ObservableObject  
    {
        private int _id;


        public int Id {
            get => _id;
            set {
                _id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        private string _name; 
        public string Name {
            get => _name;
            set {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

    }
}
