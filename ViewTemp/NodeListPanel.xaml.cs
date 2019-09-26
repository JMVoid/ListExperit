using ListExperit.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListExperit.View
{
    /// <summary>
    /// Interaction logic for ServerItem.xaml
    /// </summary>
    public partial class NodeListPanel : UserControl
    {
        private static ObservableCollection<Node> nodeList = new ObservableCollection<Node>()
        {
            new Node() {NodeAddr="hk01.bitstunnel.online", NodePort=10080, NodeGroup="bitstunnel"},
            new Node() { NodeAddr="hk02.bitstunnel.online", NodePort= 7071, NodeGroup="bitstunnel"}
        };
        public NodeListPanel()
        {
            InitializeComponent();
            nodeListBox.ItemsSource = nodeList;
        }

        private void NodeListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Node activeNode = this.nodeListBox.SelectedItem as Node;
            if (activeNode != null)
            {
                this.LabelText.Text = "You select" + activeNode.NodePort;
                activeNode.NodePort = 99999;
            }
            else
            {
                this.LabelText.Text = "lbi is null";
            }
        }

        private void NodeListBox_MouseClick(object sender, MouseButtonEventArgs e)
        {
            Node activeNode = this.nodeListBox.SelectedItem as Node;
            if (activeNode != null)
            {
                //this.LabelText1.Text =  
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Node node3 = new Node() { NodeAddr = "admin.seaus.bitstunnel.online", NodePort = 7072, NodeGroup = "vps" };
            nodeList.Add(node3);

            //int indx = this.nodeListBox.SelectedIndex;
            //Node selectedNode = this.nodeListBox.SelectedItem as Node;
            //if (selectedNode != null)
            //{
            //    this.LabelText.Text = selectedNode.NodeAddr;
            //    selectedNode.NodeAddr = "bitstunnel";
            //}
            //else
            //{
            //    this.LabelText1.Text = "lbi is null";
            //}

        }
    }
}
