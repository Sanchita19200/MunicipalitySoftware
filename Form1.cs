namespace ST10097535APPR
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the ReportIssue form
            ReportIssue reportIssuesForm = new ReportIssue();

            // Show the ReportIssues form
            reportIssuesForm.Show();

            // Optionally, hide the current form (main menu)
            this.Hide();
        }
    }
}
