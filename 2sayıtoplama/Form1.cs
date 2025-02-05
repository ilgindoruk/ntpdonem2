namespace _2sayıtoplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttntoplam_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            int sonuc;

            sayi1 = Convert.ToInt32(txtS1.Text);
            sayi2 = Convert.ToInt32(txtS2.Text);

            //toplama işlemi

            sonuc = sayi1 + sayi2;
            txtSonuc.Text = sonuc.ToString();
        }
    }
}