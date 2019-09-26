using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;
using ListExperit.Model;
using ListExperit.View;


namespace ListExperit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            //this.mainPage.Content = new NodeListPanel();
            this.mainPage.Content = new NodeListPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //UserControl serverItem1 = new ServerItem();
            //ListViewItem item1 = new ListViewItem();
            //item1.Content = serverItem1;

            //UserControl serverItem2 = new ServerItem();
            //ListViewItem item2 = new ListViewItem();
            //item2.Content = serverItem2;

            //UserControl serverItem3 = new ServerItem();
            //ListViewItem item3 = new ListViewItem();
            //item3.Content = serverItem3;

            //UserList.Items.Add(item1);
            //UserList.Items.Add(item2);
            //UserList.Items.Add(item3);
   
        }
    }
}
