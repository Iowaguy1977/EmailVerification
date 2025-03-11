
namespace Emailverification
{

    public partial class Form1 : Form
    {
        EmailConformation _Emailconformation = new EmailConformation();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean Answer = _Emailconformation.VerifyEmail(EmailAddress.Text);
            if (Answer)
            {
                MessageBox.Show("Your Email is a valid Email Address");
            }
            else
            {
                MessageBox.Show("Your Email is not a valid email!");
            }

        }
    }
}
