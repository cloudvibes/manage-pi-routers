namespace Manage_Routers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args[0] == "--restart")
            {
                System.Diagnostics.Process.Start("cmd.exe", "ssh cedri@192.168.178.1 ./reboot.sh");
            }
        }
    }
}