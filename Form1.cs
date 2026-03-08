namespace TP_MODUL3_103022400114
{
    public partial class Form1 : Form
    {
        int hasil = 0;
        int angkaPertama = 0;
        bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_output_Click(object sender, EventArgs e)
        {

        }

        private void btnAngka_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isOperatorClicked)
            {
                label_output.Text = "";
                isOperatorClicked = false;
                label_output.Text += btn.Text;
            }
            else
            {
                if (label_output.Text == "Label Output")
                {
                    label_output.Text = "";
                }
                    label_output.Text += btn.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angkaPertama = int.Parse(label_output.Text);
            isOperatorClicked = true;
            label_output.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int angkaKedua = int.Parse(label_output.Text);
            hasil = angkaPertama + angkaKedua;
            label_output.Text = hasil.ToString();
        }
    }
}
