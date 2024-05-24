namespace cs0524
{
    public partial class Form1 : Form
    {
        int vx = 20;

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
            label1.Top -= 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vx = 5;
            MessageBox.Show($"{vx}");

            vx = 10;
            MessageBox.Show($"{vx}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{vx}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx += 10;
            MessageBox.Show($"{vx}");
        }
    }
}