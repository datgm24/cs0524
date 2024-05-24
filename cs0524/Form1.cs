namespace cs0524
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            label1.Text = "Hello";
            MessageBox.Show($"‚±‚ñ‚É‚¿‚Í{textBox1.Text}‚³‚ñ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 1;
            label1.Top += 1;
        }
    }
}