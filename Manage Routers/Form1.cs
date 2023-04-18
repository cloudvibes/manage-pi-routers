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
            if (args[1] == "--reboot")
            {
                System.Diagnostics.Process.Start("cmd.exe", "ssh cedri@192.168.178.1 ./reboot.sh");
                this.Close();
            }
            else if (args[1] == "--restart-vpn")
            {
                System.Diagnostics.Process.Start("cmd.exe", "ssh cedri@10.2.2.1 sudo service openvpn restart");
                this.Close();
            }
            else this.Close();
        }
    }
}