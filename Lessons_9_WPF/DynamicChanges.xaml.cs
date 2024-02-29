using System;
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
using System.Windows.Shapes;

namespace Lessons_9_WPF
{
    /// <summary>
    /// Логика взаимодействия для DynamicChanges.xaml
    /// </summary>
    public partial class DynamicChanges : Window
    {
        ObservableCollection<Worker> db = new ObservableCollection<Worker>();

        public DynamicChanges()
        {
            InitializeComponent();
            ListDbView.ItemsSource = db;

        }

        int c = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.Add(new Worker()
            {
                name = $"Имя {++c}",
                age = 20 + c,
                salary = 1000 * c
            });
        }
    }
}
