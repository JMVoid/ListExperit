using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ListExperit.Model
{
    public class Node : ObservableObject
    {
        bool _activate;
        string _nodeAddr;
        int _nodePort;
        string _nodeGroup;

        public bool Activate {
            get { return _activate; }
            set { _activate = value; RaisePropertyChanged(() => Activate); }
        }

        public string NodeAddr {
            get { return _nodeAddr; }
            set { _nodeAddr = value; RaisePropertyChanged(() => NodeAddr); }

        }
         public int NodePort {
            get { return _nodePort; }
            set { _nodePort = value;  }
        }

        public string NodeGroup {
            get { return _nodeGroup; }
            set { _nodeGroup = value; RaisePropertyChanged(() => NodeGroup); }
        }

    }
}
