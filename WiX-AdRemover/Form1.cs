﻿using System;
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void ProcessFolder(string path)
        {
            string[] files = Directory.GetFiles(path, "*.html*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                addConsole(fileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void addConsole(string msg)
        {
            if(msg == "clear")
            {
                console_box.Text = " ";
                return;
            }
            console_box.AppendText(msg + Environment.NewLine);
            return;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            }
        }

        private void cmd_input_TextChanged(object sender, EventArgs e)
        {

        }


        private void cure(string path, string[] files, string oldWord, string newWord)
        {
            foreach (string file in files)
            {
                string filePath = Path.Combine(path, file);
                string fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace(oldWord, newWord);
                File.WriteAllText(filePath, fileContent);
            }
        }
    }
}