using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
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
        public ObservableCollection<string> Products { get; set; } = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        // Добавление продукта
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                Products.Add(txtProduct.Text);
                txtProduct.Clear();
            }
            else
            {
                MessageBox.Show("Введите название продукта", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Удаление выбранного продукта
        private void RemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                Products.Remove((string)lstProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Сохранение списка 
        private void SaveList_Click(object sender, RoutedEventArgs e)
        {
            if (Products.Count == 0)
            {
                MessageBox.Show("Список покупок пуст", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                DefaultExt = "txt",
                FileName = "Список покупок.txt"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, Products);
                    MessageBox.Show("Список успешно сохранен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // Очистка списка
        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            if (Products.Count > 0)
            {
                var result = MessageBox.Show("Очистить весь список покупок?", "Подтверждение",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Products.Clear();
                }
            }
        }
    }
}