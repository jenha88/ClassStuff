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

namespace Class1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ansBox.Text = "";
        }

        private void btb_Click(object sender, RoutedEventArgs e) // button is clicked 
        {
            string answer = ansBox.Text;
            double TPNum;
            //trying TryParse 
            bool num = double.TryParse(answer, out TPNum);

            if (num)
            {
                NumList.Items.Add(answer);
            }
            else
            {
                WordList.Items.Add(answer);
            }
            ansBox.Clear();
        }
    }
}
