namespace egg51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNumber_Click(object sender, EventArgs e)
        {
            field.Text += ((Button)sender).Text;
        }

        private void AddSymb_Click(object sender, EventArgs e)
        {
            
            if(!(field.Text.Contains('+') ||
                field.Text.Contains('-') ||
                field.Text.Contains('X') ||
                field.Text.Contains('÷')) &&
                field.Text.Length > 0)
            {
                field.Text += " " + ((Button)sender).Text + " ";
            }
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if(field.Text.Length > 0)
                field.Text = field.Text[..^1];
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            string[] extention = field.Text.Split();
            answer.Text = "Ответ: ";
            switch (extention[1][0])
            {
                case '+':
                    answer.Text += (double.Parse(extention[0]) + double.Parse(extention[2])).ToString();
                    break;
                case '-':
                    answer.Text += (double.Parse(extention[0]) - double.Parse(extention[2])).ToString();
                    break;
                case 'X':
                    answer.Text += (double.Parse(extention[0]) * double.Parse(extention[2])).ToString();
                    break;
                case '÷':
                    answer.Text += (double.Parse(extention[0]) / double.Parse(extention[2])).ToString();
                    break;
            }

            answer.Visible = true;

        }
    }
}