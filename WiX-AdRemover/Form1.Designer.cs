namespace WiX_AdRemover
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.path_btn = new System.Windows.Forms.Button();
            this.pathbox = new System.Windows.Forms.TextBox();
            this.console_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_input = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "WIX-Ad Remover made by Maeve Development (for educational purposes only!)";
            // 
            // path_btn
            // 
            this.path_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.path_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.path_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.path_btn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_btn.ForeColor = System.Drawing.Color.White;
            this.path_btn.Location = new System.Drawing.Point(334, 82);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(214, 33);
            this.path_btn.TabIndex = 4;
            this.path_btn.Text = "Select Folder";
            this.path_btn.UseVisualStyleBackColor = false;
            this.path_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pathbox
            // 
            this.pathbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pathbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathbox.ForeColor = System.Drawing.Color.DimGray;
            this.pathbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pathbox.Location = new System.Drawing.Point(0, 33);
            this.pathbox.Name = "pathbox";
            this.pathbox.ReadOnly = true;
            this.pathbox.Size = new System.Drawing.Size(800, 13);
            this.pathbox.TabIndex = 5;
            // 
            // console_box
            // 
            this.console_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.console_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console_box.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.console_box.Location = new System.Drawing.Point(12, 82);
            this.console_box.Multiline = true;
            this.console_box.Name = "console_box";
            this.console_box.Size = new System.Drawing.Size(146, 310);
            this.console_box.TabIndex = 6;
            this.console_box.TextChanged += new System.EventHandler(this.console_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Console";
            // 
            // cmd_input
            // 
            this.cmd_input.BackColor = System.Drawing.Color.Black;
            this.cmd_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmd_input.ForeColor = System.Drawing.Color.White;
            this.cmd_input.Location = new System.Drawing.Point(12, 404);
            this.cmd_input.Name = "cmd_input";
            this.cmd_input.Size = new System.Drawing.Size(146, 13);
            this.cmd_input.TabIndex = 8;
            this.cmd_input.Visible = false;
            this.cmd_input.TextChanged += new System.EventHandler(this.cmd_input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.console_box);
            this.Controls.Add(this.pathbox);
            this.Controls.Add(this.path_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button path_btn;
        private System.Windows.Forms.TextBox pathbox;
        private System.Windows.Forms.TextBox console_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmd_input;
    }
}

