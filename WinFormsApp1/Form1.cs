namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "Hej";
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            txtInput.Text = "Hej Jonas";
            btnClickHere.Text = "Du klickat";
        }
    }
}