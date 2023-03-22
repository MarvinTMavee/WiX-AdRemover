using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WiX_AdRemover
{
    public partial class Form1 : Form
    {


        //Define vars
        public bool FolderExists(string path)
        {
            return Directory.Exists(path);
        }
        public string time = System.DateTime.Now.ToString();

        //Define custom vars for function
        public string adBanner = "<div id=\"WIX_ADS\" class=\"WIX_ADS L27qsU c7bzh_\"><a data-testid=\"linkElement\" href=\"//www.wix.com/lpviral/enviral?utm_campaign=vir_wixad_live&amp;adsVersion=white&amp;orig_msid=aba0b793-4e80-44e6-a47d-d05f19d6e2d0\" target=\"_blank\" rel=\"nofollow\" class=\"Oxzvyr YD5pSO has-custom-focus\"><span class=\"aGHwBE\"><span class=\"areOb6\">Diese Website wurde mit dem Homepage-Baukasten von <div data-testid=\"bannerLogo\" style=\"direction:ltr;display:inline-flex\"><div><svg class=\"e5cW_9\" viewBox=\"0 0 28 10.89\" aria-label=\"wix\"><path d=\"M16.02.2c-.55.3-.76.78-.76 2.14a2.17 2.17 0 0 1 .7-.42 3 3 0 0 0 .7-.4A1.62 1.62 0 0 0 17.22 0a3 3 0 0 0-1.18.2z\" class=\"o4sLYL\"></path><path d=\"M12.77.52a2.12 2.12 0 0 0-.58 1l-1.5 5.8-1.3-4.75a4.06 4.06 0 0 0-.7-1.55 2.08 2.08 0 0 0-2.9 0 4.06 4.06 0 0 0-.7 1.55L3.9 7.32l-1.5-5.8a2.12 2.12 0 0 0-.6-1A2.6 2.6 0 0 0 0 .02l2.9 10.83a3.53 3.53 0 0 0 1.42-.17c.62-.33.92-.57 1.3-2 .33-1.33 1.26-5.2 1.35-5.47a.5.5 0 0 1 .34-.4.5.5 0 0 1 .4.5c.1.3 1 4.2 1.4 5.5.4 1.5.7 1.7 1.3 2a3.53 3.53 0 0 0 1.4.2l2.8-11a2.6 2.6 0 0 0-1.82.53zm4.43 1.26a1.76 1.76 0 0 1-.58.5c-.26.16-.52.26-.8.4a.82.82 0 0 0-.57.82v7.36a2.47 2.47 0 0 0 1.2-.15c.6-.3.75-.6.75-2V1.8zm7.16 3.68L28 .06a3.22 3.22 0 0 0-2.3.42 8.67 8.67 0 0 0-1 1.24l-1.34 1.93a.3.3 0 0 1-.57 0l-1.4-1.93a8.67 8.67 0 0 0-1-1.24 3.22 3.22 0 0 0-2.3-.43l3.6 5.4-3.7 5.4a3.54 3.54 0 0 0 2.32-.48 7.22 7.22 0 0 0 1-1.16l1.33-1.9a.3.3 0 0 1 .57 0l1.37 2a8.2 8.2 0 0 0 1 1.2 3.47 3.47 0 0 0 2.33.5z\"></path></svg></div><div class=\"uJDaUS\">.com</div></div></span><span class=\"O0tKs2 Oxzvyr\"></span></span></a></div>";
        public Form1()
        {
            InitializeComponent();
        }


        bool mouseDown;
        private Point offset;
        private void Form1_Load(object sender, EventArgs e)
        {
            pathbox.Enabled = true;
        }


        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public void addConsole(string msg)
        {
            if (msg == "clear")
            {
                console_box.Text = " ";
                return;
            }
            console_box.AppendText(msg + Environment.NewLine);
            return;
        }

        private void console_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void cure_btn_Click(object sender, EventArgs e)
        {
            Cure(adBanner, " ");
        }

        private void exit_ico_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void selectfolder_Click(object sender, EventArgs e)
        {
            if (pathbox.TextLength > 10 && FolderExists(pathbox.Text))
            {
                string path = pathbox.Text;
                pathbox.Text = path.ToString();
                path_btn.Text = "Done";
                path_btn.Enabled = true;
                path_btn.ForeColor = Color.Gray;
                ProcessFolder(path);
            } else
            {
                ///Explorer
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string path = fbd.SelectedPath;
                    // do something with the selected folder path
                    if (FolderExists(path))
                    {
                        pathbox.Text = path.ToString();
                        path_btn.Text = "Done";
                        path_btn.Enabled = true;
                        path_btn.ForeColor = Color.Gray;
                        ProcessFolder(path);
                    }
                }
            }
        }
        private string[] files;
        public void ProcessFolder(string path)
        {

            addConsole("Start processing folder..");
            addConsole("Scanning files..");
            files = Directory.GetFiles(path, "*.html*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                addConsole(file);

            }
        }
        public void Cure(string oldWord, string newWord)
        {
            addConsole("Starting Cure proccess for " + files);
            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);
                addConsole("File curing w/ Content:");
                addConsole(fileContent);
                fileContent = fileContent.Replace(oldWord, newWord);
                addConsole("Replacing Content:");
                addConsole(oldWord + "to");
                addConsole(newWord + "replaced");
                File.WriteAllText(file, fileContent);
                addConsole("Current file done!");
            }
            addConsole(Environment.NewLine);
            addConsole("Creating Log..");
            File.WriteAllText(pathbox.Text + time + ".log", console_box.Text);
            addConsole(Environment.NewLine);
            addConsole("clear");
            addConsole("Saved security log at:");
            addConsole(pathbox.Text + time + ".log");
        }

        private void pathbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}