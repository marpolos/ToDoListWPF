using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ToDoList
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


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (txbInput.Text.Length == 0) btnAdd.IsEnabled = false;
            else
            {
                btnAdd.IsEnabled = true;
                if(e.Key == Key.Enter)
                {
                    AddToListBox(txbInput.Text);
                }
            }
        }

        private void AddToListBox(string text)
        {
            lbxTasks.Items.Add(text);
            txbInput.Text = string.Empty;
            btnAdd.IsEnabled = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddToListBox(txbInput.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            lbxTasks.Items.Remove(lbxTasks.SelectedItem);
            btnDelete.IsEnabled = false;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelete.IsEnabled = true;
        }
    }
}
