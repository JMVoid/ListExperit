using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace ListExperit.Model
{
    public class GuiConfig : ObservableObject
    {
        private int _localSocks;
        private int _localHttp;
        private int _index;
        private string _logLevel;
        private ObservableCollection<Node> _nodeList;
        private StudentModel _studentModel;

        public int LocalSocks
        {
            get { return _localSocks; }
            set
            {
                _localSocks = value;
                RaisePropertyChanged(() => LocalSocks);
            }
        }
        public int LocalHttp
        {
            get { return _localHttp; }
            set
            {
                _localHttp = value;
                RaisePropertyChanged(() => LocalHttp);
            }

        }

        public int Index {
            get { return _index; }
            set {
                _index = value;
                RaisePropertyChanged(() => Index);
            }
        }
        public string LogLevel {
            get { return _logLevel; }
            set {
                _logLevel = value;
                RaisePropertyChanged(() => LogLevel);
            }
        }
        public ObservableCollection<Node> NodeList{
            get { return _nodeList; }
            set
            {
                _nodeList = value;
                RaisePropertyChanged(() => NodeList);
            }
        }
        public StudentModel StudentModel {
            get { return _studentModel; }
            set
            {
                _studentModel = value;
            }
        }
    }
}
