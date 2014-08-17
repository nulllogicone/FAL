using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using LumenWorks.Framework.IO.Csv;
using MessageBox = System.Windows.MessageBox;

namespace ExcelMailer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataTable CsvTable;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void ButtonSelectFile_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.Title = "Select csv file";
            dlg.DefaultExt = ".csv";
            dlg.Filter = "Text Files (.csv)|*.csv";

            // Display OpenFileDialog by calling ShowDialog method 
            var result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Open document 
                var filename = dlg.FileName;
                using (var sr = new StreamReader(filename, Encoding.UTF8))
                {
                    CsvTable = new DataTable();
                    var csvReader = new CsvReader(sr, true);
                    CsvTable.Load(csvReader);
                    DataGridCsvTable.ItemsSource = CsvTable.DefaultView;
                }
            }
        }

        private void ButtonSendEmails_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
