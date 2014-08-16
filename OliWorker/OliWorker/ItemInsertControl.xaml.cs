using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OliWorker
{
    /// <summary>
    /// Interaction logic for ItemInsertControl.xaml
    /// </summary>
    public partial class ItemInsertControl : UserControl
    {
        public ItemInsertControl()
        {
            InitializeComponent();
        }

        private void buttonItemInsert_Click(object sender, RoutedEventArgs e)
        {
            WorkItem wi = new WorkItem();
            wi.created = DateTime.Now;
            wi.description = "jepp";

            OliWorkerContainer db = new OliWorkerContainer();
            db.AddToWorkItem(wi);
            db.SaveChanges();
        }
    }
}
