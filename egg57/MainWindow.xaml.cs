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
using System.IO;
using System.Drawing;

namespace egg57
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Point old;
        public MainWindow()
        {
            InitializeComponent();
            System.Drawing.Image myImg = System.Drawing.Image.FromFile("image.png");
            image.Height = myImg.Height;
            image.Width = myImg.Width;
            window.Height = image.Height; 
            window.Width = image.Width;
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            old = e.GetPosition(null);
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                System.Windows.Point cur = e.GetPosition(null);

                Left += cur.X - old.X;
                Top += cur.Y - old.Y;
                
            }
        }
    }
}
