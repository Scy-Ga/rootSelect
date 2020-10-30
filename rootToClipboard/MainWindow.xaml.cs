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

using rootToClipboard.Classes;
using Microsoft.Win32;

namespace rootToClipboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_searce_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog keres = new OpenFileDialog();
            keres.Multiselect = true;
            keres.Filter = "PDF Files|*.pdf";
            keres.DefaultExt = ".pdf";

            Nullable<bool> keresOk = keres.ShowDialog();

            if (keresOk == true)
            {
                string FileNames = "";


                foreach (string FileName in keres.FileNames)
                {
                    FileNames += " ; " + FileName;
                    
                    
                }

                FileNames = FileNames.Substring(3);

                txb_root.Text = FileNames;

                

            }

        }

        private void Btn_copy_Click(object sender, RoutedEventArgs e)
        {
            string clipboard = "";

            clipboard = txb_root.Text;

            Clipboard.SetText(clipboard);

            this.Close();
        }
        
    }
}
