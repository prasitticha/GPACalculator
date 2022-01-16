namespace GPAxCalculator01
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int n = 0;
        double Num = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4.00
            string number = textBoxGPA_input.Text;
            double dInput = double.Parse(number);

            if (dInput > 4)
                textBoxGPAx.Text = "error";
            if (dInput < 0)
                textBoxGPAx.Text = "error";
            if (Num > 4)
                textBoxGPAx.Text = "error";


            n = n + 1;

            sum = sum + dInput;

            double num = sum / n;

            double Num = num;

            textBoxGPAx.Text = Num.ToString();

            textBoxGPA_input.Text = "";
        }
    }
}