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
using XMLDemoReadWrite.ViewModel;

namespace XMLDemoReadWrite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StudentViewModel studentViewModel = new StudentViewModel();
            this.DataContext = studentViewModel;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //add to list
        //    // loadtofile
        //    //show
        //}
    }
}
