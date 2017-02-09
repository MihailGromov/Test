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

namespace Boxer_Week2
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

        private void btnAddMe_Click(object sender, RoutedEventArgs e)
        {
            //create first Boxer object (using Boxer class)
            Boxer boxer1 = new Boxer();
            //modify its properties
            boxer1.Name = "Joe";
            boxer1.Strenght = 5;
            // MessageBox.Show(boxer1.Name, "First Boxer");
            this.lbxBoxers.Items.Add(boxer1);
        } //end click handler
    } //end class
}// end ns
