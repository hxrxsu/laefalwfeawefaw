namespace LeasingCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разин Кирилл", "Автор");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дорабатываем", "Ошибка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 lc = new Form2();
            lc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 lc = new Form3();
            lc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 lc = new Form4();
            lc.ShowDialog();
        }
    }
}