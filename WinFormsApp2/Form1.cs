namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNamnText.Text);
            txtNamnText.Text = "Du klickade på knappen ";
        }
    }
}