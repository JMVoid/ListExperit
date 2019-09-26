using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using ListExperit.Model;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.CommandWpf;

namespace ListExperit.ViewModel
{
    public class NodeListViewModel : ViewModelBase
    {

        public NodeListViewModel()
        {
            if (IsInDesignMode)
            {
                NodeListModel = new ObservableCollection<Node>()
                {
                    new Node() {Activate=true, NodeAddr="hk01f.bitstunnel.online", NodePort=10080, NodeGroup="bitstunnel"},
                    new Node() {Activate=false, NodeAddr="hk02f.bitstunnel.online", NodePort= 7071, NodeGroup="bitstunnel"}
                };
            }
            else
            {
                NodeListModel = new ObservableCollection<Node>()
                {
                    new Node() {Activate=false,  NodeAddr="hk01.bitstunnel.online", NodePort=10080, NodeGroup="bitstunnel"},
                    new Node() {Activate=true, NodeAddr="hk02.bitstunnel.online", NodePort= 7071, NodeGroup="bitstunnel"}
                };

            }

        }
        //public ObservableCollection<Node> NodeListModel {
        //    get {
        //        return NodeListModel;
        //    } 
        //    set {
        //        NodeListModel = value;
        //        RaisePropertyChanged(() => NodeListModel);
        //    }
        //}

        public ObservableCollection<Node> NodeListModel { get; set; }

        private RelayCommand _editNodeCmd;

        public RelayCommand EditNodeCmd{
            get {
                if (_editNodeCmd == null) return new RelayCommand(() => )
            }
        }

    }
}
