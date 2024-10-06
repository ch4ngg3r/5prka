using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Массив назван mas
        private ObservableCollection<string> mas = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            vstavka.ItemsSource = mas; // Привязываем ListBox (теперь vstavka) к массиву mas
        }

        // Добавление новой записи
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(input.Text))
            {
                mas.Add(input.Text);
                input.Clear();
            }
            else
            {
                MessageBox.Show("ТЫ НЕ ВЫБРАЛ ЧТО ДОБАВИТЬ");
            }
        }

        // Удаление существующей записи
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (vstavka.SelectedItem != null)
            {
                mas.Remove(vstavka.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("ТЫ НЕ ВЫБРАЛ ЧТО УДАЛИТЬ");
            }
        }

        // Изменение существующей записи
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (vstavka.SelectedItem != null && !string.IsNullOrWhiteSpace(input.Text))
            {
                int selectedIndex = vstavka.SelectedIndex;
                mas[selectedIndex] = input.Text;
                input.Clear();
            }
            else
            {
                MessageBox.Show("ТЫ НЕ ВЫБРАЛ ЧТО ИЗМЕНИТЬ");
            }
        }
    }
}