using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using WpfAnimation.MyCode;

namespace egg58
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ColorBrushAnimation colorAnimationK;

        SolidColorBrush brush;
        Image image;
        StackPanel instance;
        List<string> Directories;
        string path = "E:\\";
        List<string> history;

        public MainWindow()
        {
            brush = new();
            Background = brush;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            history = new List<string>() { path };
            UpdateDirectories();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                path += ((TextBlock)((StackPanel)list.SelectedItem).Children[1]).Text + "\\";
                history.Add(path);
                list.Items.Clear();
                UpdateDirectories();
                
            }
        }
        
        void UpdateDirectories()
        {

            Directories = Directory.EnumerateDirectories(path).ToList();

            foreach (string dir in Directories)
            {
                instance = new StackPanel();
                instance.Orientation = Orientation.Horizontal;
                image = new Image();
                var bi = new BitmapImage();
                bi.BeginInit();
                bi.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.UriSource = new Uri("folder.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                image.Source = bi;
                image.Width = 15;
                image.Height = 15;
                instance.Children.Add(image);

                TextBlock textBlock = new();
                textBlock.Text = dir[(dir.LastIndexOf('\\') + 1)..];
                instance.Children.Add(textBlock);

                list.Items.Add(instance);
                
                
            }
        }


        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            colorAnimationK = new ColorBrushAnimation(this);
            colorAnimationK.ColorRectangleAnimation(rect, Colors.White, Colors.Lime);
        }

        private void MenuItem_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            path = history[^2];
            history.RemoveAt(history.Count - 1);
            list.Items.Clear();
            UpdateDirectories();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            path = history[^2];
            history.RemoveAt(history.Count - 1);
            list.Items.Clear();
            UpdateDirectories();
        }

        private void list_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            colorAnimationK = new ColorBrushAnimation(this);
            colorAnimationK.ColorRectangleAnimation(rect2, Colors.White, Colors.Red);
            
        }
    }
}
