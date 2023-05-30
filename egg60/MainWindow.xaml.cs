using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace egg60
{
    public partial class MainWindow : Window
    {

        public Phonebook phonebook;
        string path = "C:\\Users\\Student\\Documents\\phonebook.json";
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(path))
            {
                JsonSerializer.Deserialize<Phonebook>(File.ReadAllText(path));
            }
            else
            {
                phonebook = new() { phonebook = new() };
            }
            DataContext = phonebook.phonebook;
            phonesGrid.ItemsSource = phonebook.phonebook;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            phonebook.phonebook.Add(new Phone() {
                Name = nameTextBox.Text,
                Number = phoneTextBox.Text,
                Comment = commentTextBox.Text
            });
            phonesGrid.ItemsSource = null;
            phonesGrid.ItemsSource = phonebook.phonebook;
            File.WriteAllText(path, JsonSerializer.Serialize(phonebook));
        }
    }
    [Serializable]
    public class Phone
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }
    }
    [Serializable]
    public class Phonebook
    {
       public List<Phone> phonebook { get; set; }
    }
}
