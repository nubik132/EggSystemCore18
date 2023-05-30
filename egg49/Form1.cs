namespace egg49
{
    public partial class Form1 : Form
    {
        string[] employee;
        string[] came;
        string notCame;
        int i, j;
        public Form1()
        {
            InitializeComponent();
            i = 0;
            j = 0;
            notCame = "Не пришли:\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee ??= new string[int.Parse(maskedTextBox1.Text)];

            if (!label5.Visible)
            {
                label5.Visible = true;
            }

            employee[i] = maskedTextBox2.Text;

            string elemCount = "Сейчас элементов: ";
            label5.Text= elemCount + ++i;
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            foreach (var item in employee)
            {
                if (!came.Contains(item))
                {
                    notCame += item + '\n';
                }
                if (notCame == "Не пришли:\n")
                {
                    notCame = "Все пришли";
                }
            }
            MessageBox.Show(notCame);
            notCame = "Не пришли:\n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(came == null)
            {
                came = new string[int.Parse(maskedTextBox4.Text)];
            }
            

            if (!label6.Visible)
            {
                label6.Visible = true;
            }
            came[j] = maskedTextBox3.Text;

            string elemCount = "Сейчас элементов: ";
            label6.Text = elemCount + ++j;
        }
    }
}