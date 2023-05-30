using System.Windows.Forms;

namespace egg52
{
    public partial class Form1 : Form
    {
        ContextMenuStrip contextMenuStrip1;
        public Form1()
        {
            InitializeComponent();
            contextMenuStrip1 = new ContextMenuStrip();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            textBox1.Text = fileText;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox1.Text);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var fileItem = menuStrip1.Items[0];
            //contextMenuStrip1.Items.Add(fileItem);
            //ContextMenuStrip = contextMenuStrip1;
            ////menuStrip1.Items.Add(fileItem);

            //foreach (Control c in Controls)
            //{
            //    // задаем контекстное меню. 
            //    c.ContextMenuStrip = contextMenuStrip1;
            //    // Указываем для каждого элемента 
            //    // обработчик для правой кнопки мыши. 
            //    c.MouseDown += new MouseEventHandler(ShowPopupMenu);
            //}
        }
        private void ShowPopupMenu(object sender, MouseEventArgs e)
        {
            // Если нажата правая кнопка мыши. 
            if (e.Button == MouseButtons.Right)
            {
                Control c = (Control)sender;
                // Если контекстное меню у элемента существует, 
                if (c.ContextMenuStrip != null)
                {
                    // то показываем его. 
                    c.ContextMenuStrip.Show(c, new Point(e.X, e.Y));
                }
            }

        }

        private void statusStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            // Производим действие только при щелчке правой кнопкой мыши на нулевой панели. 
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Нулевая панель");
                statusStrip1.Items[0].Width= 150;
            }
            else
            {
                try
                {
                    int a = 0 / 2;
                }
                catch (DivideByZeroException ex)
                {
                    statusStrip1.Items[1].Text = ex.Message;
                }
            }
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }
    }
}
