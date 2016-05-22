using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace steam_idle
{
    public partial class frmMain : Form
    {
        private string AppId;

        public frmMain()
        {
            InitializeComponent();
            AppId = Environment.GetEnvironmentVariable("SteamAppId");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text += " : " + AppId;
            picApp.LoadAsync("https://steamcdn-a.akamaihd.net/steam/apps/" + AppId + "/header_292x136.jpg");
        }

        private void picApp_Click(object sender, EventArgs e)
        {
            Process.Start("http://store.steampowered.com/app/" + AppId);
        }
    }
}