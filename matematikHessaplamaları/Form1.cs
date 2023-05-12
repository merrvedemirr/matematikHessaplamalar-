using System.Windows.Forms;
namespace matematikHessaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int birKenar , alan, cevre;
            int dikAlan, dikCevre, uzun;

            birKenar = Convert.ToInt32(textBox1.Text);

            alan = (int)Math.Pow(birKenar, 2); //Girilen sayının karesini alan özel fonksiyon.
            cevre = birKenar * 4;

            label4.Text = Convert.ToString(alan);
            label5.Text = cevre.ToString();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = true;
            panel1.Visible = true;
            label1.Text = "kare";
            label7.Visible = false;
            textBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "dikdörtgen";
            label7.Visible = true;
            textBox2.Visible = true;
            label2.Text = "Kısa kenar : ";
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "daire";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            int alan, cevre, uzun, kisa;

            uzun = Convert.ToInt32(textBox2.Text);
            kisa = Convert.ToInt32(textBox1.Text);

            alan = kisa * uzun;
            cevre = (2 * kisa) + (2 * uzun);

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }
    }
}