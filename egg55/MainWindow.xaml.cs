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
using Xceed.Wpf.AvalonDock.Layout;
using egg55.Models;
using System.ComponentModel;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.IO;

namespace egg55
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<TodoModel> todoData;
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("Todo.dat"))
                Load();
            else
            todoData= new BindingList<TodoModel>();
            dgTodoList.ItemsSource = todoData;
        }

        void Load()
        {
            todoData = JsonConvert.DeserializeObject<BindingList<TodoModel>>(File.ReadAllText("Todo.dat"));
        }
        void Save()
        {
            File.WriteAllText("Todo.dat", JsonConvert.SerializeObject(todoData, Formatting.Indented));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }
    }

}
