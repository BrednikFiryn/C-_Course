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
using System.Windows.Shapes;

namespace Lessons_9_WPF
{
    /// <summary>
    /// Логика взаимодействия для HardButton.xaml
    /// </summary>
    public partial class HardButton : Window
    {
        Page1 pg1 = new Page1();
        Page2 pg2 = new Page2();

        public HardButton()
        {
            InitializeComponent();
        }

        private void HardBtn1Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = pg1;
        }

        private void HardBtn2Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = pg2;
        }
    }
}
