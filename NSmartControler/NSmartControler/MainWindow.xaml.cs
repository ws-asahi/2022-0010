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
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace NSmartControler
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

        private void Window_Loaded(Object sender, EventArgs e)
        {
            WindowStyle = WindowStyle.None;
            //WindowState = WindowState.Maximized;
        }

        private void slider_TrainSpeed_ValueChanged(Object sender, EventArgs e)
        {
            if(slider_TrainSpeed != null && textBlock_SelectedSpeed != null)
            {
                textBlock_SelectedSpeed.Text = ((int)slider_TrainSpeed.Value).ToString() + "%";


            }

        }
    }
}
