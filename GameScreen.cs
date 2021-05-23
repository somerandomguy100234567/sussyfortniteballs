using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbertyX0._1
{
    public partial class GameScreen : Form
    {
public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMoveable_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public GameScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            if (Panel2.Size == Panel2.MaximumSize)
            {
                Panel2.Size = Panel2.MinimumSize;
            }
            else
            {
                Panel2.Size = Panel2.MaximumSize;
            }
        }

        private void siticoneRoundedButton11_Click(object sender, EventArgs e)
        {
            if (Panel3.Size == Panel3.MaximumSize)
            {
                Panel3.Size = Panel3.MinimumSize;
            }
            else
            {
                Panel3.Size = Panel3.MaximumSize;
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneRoundedButton8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = " ";
        }

        private void siticoneRoundedButton9_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (.txt)|.txt|Lua Files (.lua)|.lua|All Files (.)|.";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void siticoneRoundedButton10_Click(object sender, EventArgs e)
        {
            //wassup
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (.lua)|.lua|Text File (.txt)|.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text= "loadstring(game:HttpGet('https://pastebin.com/raw/GtudyLtE')();";
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(('https://pastebin.com/raw/tzTXmYf2'), true))()";

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub'))()";
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/opBandwidth/_Paragon_/main/main.lua'))()";
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:GetObjects('rbxassetid://1461971147')[1].Source)()";
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://thisstuff.xyz/Api/WOAHSCRIPTS/1257821635-9356095531/oOAfkpCWzDWsn4CjuLZLZOs3vCf4rgUMhXaJd32VyHSs2tojOCTUKINNTbAuTTCGFrYTyMeBDEIfdo7C0Sp5EnCyxN80pHf5jpqk2xU7f1LAcx2Nt1cZe', true))() ";
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://pastebin.com/3b2NF240', true))()";
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(('https://raw.githubusercontent.com/RandomAdamYT/DarkHub/master/Init'), true))()";
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(('https://pastebin.com/HzZUDxaT'', true))()";
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/Doggo-cryto/EclipseMM2/master/Script'))()";
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('http://void-scripts.com/Scripts/islands_new.lua'))()";
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://pastebin.com/jFUcWY1z'))()";
        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {

        }
    }
}
