using ListExperit.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExperit.ViewModel
{


    public class GuiConfigViewModel
    {
        private GuiConfig _guiConfig;
        public GuiConfigViewModel()
        {

            ObservableCollection<Node> nodeList = new ObservableCollection<Node>()
            {
                    new Node() {Activate=true, NodeAddr="hk01f.bitstunnel.online", NodePort=10080, NodeGroup="bitstunnel"},
                    new Node() {Activate=false, NodeAddr="hk02f.bitstunnel.online", NodePort= 7071, NodeGroup="bitstunnel"}
             };

            StudentModel studentModel = new StudentModel() { Id = 99, Name = "John Smith" };

            _guiConfig = new GuiConfig()
            {
                LocalSocks = 7071,
                LocalHttp = 7072,
                Index = 1,
                LogLevel = "Warning",
                NodeList = nodeList,
                StudentModel = studentModel
            };
        }

        public StudentModel Student
        {
            get {
                return _guiConfig.StudentModel;
            }
            set {
                _guiConfig.StudentModel = value;
            }
        }

        public ObservableCollection<Node> NodeList {
            get
            {
                return _guiConfig.NodeList;
            }
            set {
                _guiConfig.NodeList = value;
            }
        }

    }
}
