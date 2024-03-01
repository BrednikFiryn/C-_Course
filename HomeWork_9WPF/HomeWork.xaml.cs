using Module_5;
using System.Collections.ObjectModel;
using System.Windows;

namespace HomeWork_9WPF
{
    /// <summary>
    /// Логика взаимодействия для HomeWork.xaml
    /// </summary>
    public partial class HomeWork : Window
    {
        ObservableCollection<Program> listWords = new ObservableCollection<Program>();
        private string[] words;

        public HomeWork()
        {
            InitializeComponent();
            listBox.ItemsSource = listWords;
        }

        private void ButtonLabel_Click(object sender, RoutedEventArgs e)
        {
            words = Program.SentenceReverse(TextBoxLabel.Text);
            string text = string.Join("", words);
            label.Content = text;
        }

        private void ButtonList_Click(object sender, RoutedEventArgs e)
        {
           words = Program.SentenceCuter(TextBoxList.Text);
            foreach (string wrd in words)
            {
                listWords.Add(new Program()
                {
                    saidSentence = wrd
                });
            }
        }
    }
 }


