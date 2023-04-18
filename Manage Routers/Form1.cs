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
            else if (args[1] == "--switch-wifi")
            {
                try
                {
                    if (args[2] != "fritz" && args[2] != "hotspot") throw new ArgumentException(args[2].ToString() + " is not a valid Wifi-name.";
                    else System.Diagnostics.Process.Start("cmd.exe", "ssh cedri@10.2.2.1 ./switch_wifi_" + args[2] + ".sh");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.ToString());
                    this.Close();
                    throw;
                }
            }
            else if (args[1] == "htop")
            {
                try
                {
                    if (args[2] == null && args[2] != "1" && args[2] != "2") throw new ArgumentException(args[2].ToString() + " is not a valid Device ID.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.ToString());
                    this.Close();
                    throw;
                }
                if (args[2] == "1")
                {
                    System.Diagnostics.Process.Start("cmd.exe", "ssh cedri@192.168.178.1 htop");
                    this.Close();
                }
                System.Diagnostics.Process.Start("cmd.exe", "ssh cedri@10.2.2.1 htop");
                this.Close();
            }
        }
    }
}