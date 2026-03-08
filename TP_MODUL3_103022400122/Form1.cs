namespace TP_MODUL3_103022400122
{
    public partial class Form1 : Form
    {
        string masukkan = "";
        int angkapertama = 0;
        bool isPlusCLicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(masukkan != "")
            {
                angkapertama = int.Parse(masukkan);
                masukkan = "";
                isPlusCLicked = true;
                textBox1.Text = "+";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukkan += btn.Text;
            textBox1.Text = masukkan;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(isPlusCLicked && masukkan != "")
            {
                int angkakedua = int.Parse(masukkan);
                int hasil = angkapertama + angkakedua;
                textBox1.Text = hasil.ToString();
                masukkan = hasil.ToString() + masukkan;
                isPlusCLicked = false;
            }
        }
    }
}
