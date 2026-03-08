namespace TP_MODUL3_103022400122
{
    public partial class Form1 : Form
    {
        string masukkan_numbers = "";
        int angkapertama = 0;
        bool isPlusCLicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(masukkan_numbers != "")
            {
                angkapertama = int.Parse(masukkan_numbers);
                masukkan_numbers = "";
                isPlusCLicked = true;
                textBox1.Text = "+";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan_numbers += btn.Text;
            textBox1.Text = masukkan_numbers;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(isPlusCLicked && masukkan_numbers != "")
            {
                int angkakedua = int.Parse(masukkan_numbers);
                int hasil = angkapertama + angkakedua;
                textBox1.Text = hasil.ToString();
                masukkan_numbers = hasil.ToString() + masukkan_numbers;
                isPlusCLicked = false;
            }
        }
    }
}
