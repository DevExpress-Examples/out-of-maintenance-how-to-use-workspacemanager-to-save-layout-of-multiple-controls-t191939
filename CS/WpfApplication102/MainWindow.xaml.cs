using DevExpress.Xpf.Core;
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

namespace WpfApplication102
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            for (int i = 1; i < 30; i++)
            {
                customers.Add(new Customer() { ID = i, Name = "Name" + i });
            }
            gridControl1.ItemsSource = customers;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkspaceManager workspaceManager = WorkspaceManager.GetWorkspaceManager(dockLayoutManager) as WorkspaceManager;
            workspaceManager.CaptureWorkspace("workspace1");
            workspaceManager.SaveWorkspace("workspace1", "layout.xml");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WorkspaceManager workspaceManager = WorkspaceManager.GetWorkspaceManager(dockLayoutManager) as WorkspaceManager;
            workspaceManager.ApplyWorkspace("workspace1");
            workspaceManager.LoadWorkspace("workspace1", "layout.xml");
        }
    }


    public class Customer
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
