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
using AutoUpdaterDotNET;
namespace WiX_AdRemover
{
    public partial class Form1 : Form
    {

        /// Define other classes from namespace

        //Define vars
        public bool FolderExists(string path)
        {
            return Directory.Exists(path);
        }

        public string adBanner = "";
        public Form1()
        {
            InitializeComponent();
        }


        bool mouseDown;
        private Point offset;
        private void Form1_Load(object sender, EventArgs e)
        {
            pathbox.Enabled = false;
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
            if (console_box.Text == "...cmd")
            {
                addConsole("clear");
                addConsole("========================");
                addConsole("         CMD v1 activated!         ");
                addConsole("type help to get a list of all cmds");
                addConsole("========================");
                console_box.ReadOnly = true;
                cmd_input.Enabled = true;
                cmd_input.Visible = true;
                MessageBox.Show("Warning! CMD is experimental and can cause permanently damage to the program!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cure_btn_Click(object sender, EventArgs e)
        {
            Cure("Hallo123", "Hello World!!");
        }

        private void exit_ico_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void selectfolder_Click(object sender, EventArgs e)
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
                    path_btn.Enabled = false;
                    path_btn.ForeColor = Color.Gray;
                    ProcessFolder(path);
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
            File.WriteAllText(pathbox.Text + "/Log.log", console_box.Text);
            addConsole(Environment.NewLine);
            addConsole("Saved security log at:");
            addConsole(pathbox.Text + " log.log");
        }
    }
}