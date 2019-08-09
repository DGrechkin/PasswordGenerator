namespace PasswordGenerator
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usersWord_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.specSymbols_field = new System.Windows.Forms.TextBox();
            this.length_field = new System.Windows.Forms.NumericUpDown();
            this.charPass_radio = new System.Windows.Forms.RadioButton();
            this.pronPass_radio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.originalWord_lable = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_field = new System.Windows.Forms.TextBox();
            this.setOfNames_field = new System.Windows.Forms.ComboBox();
            this.close_button = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.main_tab = new System.Windows.Forms.TabPage();
            this.options_tab = new System.Windows.Forms.TabPage();
            this.about_button = new System.Windows.Forms.Button();
            this.browse_button = new System.Windows.Forms.Button();
            this.path_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.length_field)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.options_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.usersWord_field);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.specSymbols_field);
            this.groupBox1.Controls.Add(this.length_field);
            this.groupBox1.Controls.Add(this.charPass_radio);
            this.groupBox1.Controls.Add(this.pronPass_radio);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "User\'s word:";
            // 
            // usersWord_field
            // 
            this.usersWord_field.Enabled = false;
            this.usersWord_field.Location = new System.Drawing.Point(234, 19);
            this.usersWord_field.Name = "usersWord_field";
            this.usersWord_field.Size = new System.Drawing.Size(164, 20);
            this.usersWord_field.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Special symbols:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length:";
            // 
            // specSymbols_field
            // 
            this.specSymbols_field.Location = new System.Drawing.Point(234, 77);
            this.specSymbols_field.Name = "specSymbols_field";
            this.specSymbols_field.Size = new System.Drawing.Size(164, 20);
            this.specSymbols_field.TabIndex = 3;
            // 
            // length_field
            // 
            this.length_field.Location = new System.Drawing.Point(64, 78);
            this.length_field.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.length_field.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.length_field.Name = "length_field";
            this.length_field.Size = new System.Drawing.Size(41, 20);
            this.length_field.TabIndex = 2;
            this.length_field.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // charPass_radio
            // 
            this.charPass_radio.AutoSize = true;
            this.charPass_radio.Checked = true;
            this.charPass_radio.Location = new System.Drawing.Point(7, 44);
            this.charPass_radio.Name = "charPass_radio";
            this.charPass_radio.Size = new System.Drawing.Size(168, 17);
            this.charPass_radio.TabIndex = 1;
            this.charPass_radio.TabStop = true;
            this.charPass_radio.Text = "Random Characters Password";
            this.charPass_radio.UseVisualStyleBackColor = true;
            this.charPass_radio.CheckedChanged += new System.EventHandler(this.charPass_radio_CheckedChanged);
            // 
            // pronPass_radio
            // 
            this.pronPass_radio.AutoSize = true;
            this.pronPass_radio.Location = new System.Drawing.Point(7, 20);
            this.pronPass_radio.Name = "pronPass_radio";
            this.pronPass_radio.Size = new System.Drawing.Size(146, 17);
            this.pronPass_radio.TabIndex = 0;
            this.pronPass_radio.Text = "Pronounceable Password";
            this.pronPass_radio.UseVisualStyleBackColor = true;
            this.pronPass_radio.CheckedChanged += new System.EventHandler(this.pronPass_radio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Original word:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.originalWord_lable);
            this.groupBox2.Controls.Add(this.save_button);
            this.groupBox2.Controls.Add(this.generate_button);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pass_field);
            this.groupBox2.Controls.Add(this.setOfNames_field);
            this.groupBox2.Location = new System.Drawing.Point(3, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // originalWord_lable
            // 
            this.originalWord_lable.AutoSize = true;
            this.originalWord_lable.Location = new System.Drawing.Point(214, 74);
            this.originalWord_lable.Name = "originalWord_lable";
            this.originalWord_lable.Size = new System.Drawing.Size(0, 13);
            this.originalWord_lable.TabIndex = 9;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(234, 36);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(98, 23);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(360, 36);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(98, 23);
            this.generate_button.TabIndex = 4;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set of names:";
            // 
            // pass_field
            // 
            this.pass_field.Location = new System.Drawing.Point(6, 90);
            this.pass_field.Name = "pass_field";
            this.pass_field.Size = new System.Drawing.Size(452, 20);
            this.pass_field.TabIndex = 1;
            this.pass_field.Click += new System.EventHandler(this.pass_field_Click);
            // 
            // setOfNames_field
            // 
            this.setOfNames_field.FormattingEnabled = true;
            this.setOfNames_field.Location = new System.Drawing.Point(6, 36);
            this.setOfNames_field.Name = "setOfNames_field";
            this.setOfNames_field.Size = new System.Drawing.Size(164, 21);
            this.setOfNames_field.Sorted = true;
            this.setOfNames_field.TabIndex = 0;
            this.setOfNames_field.SelectedIndexChanged += new System.EventHandler(this.setOfNames_field_SelectedIndexChanged);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(367, 308);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(98, 23);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.main_tab);
            this.tabControl.Controls.Add(this.options_tab);
            this.tabControl.Location = new System.Drawing.Point(0, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(474, 287);
            this.tabControl.TabIndex = 6;
            // 
            // main_tab
            // 
            this.main_tab.BackColor = System.Drawing.SystemColors.Control;
            this.main_tab.Controls.Add(this.groupBox1);
            this.main_tab.Controls.Add(this.groupBox2);
            this.main_tab.Location = new System.Drawing.Point(4, 22);
            this.main_tab.Name = "main_tab";
            this.main_tab.Padding = new System.Windows.Forms.Padding(3);
            this.main_tab.Size = new System.Drawing.Size(466, 261);
            this.main_tab.TabIndex = 0;
            this.main_tab.Text = "Main";
            // 
            // options_tab
            // 
            this.options_tab.BackColor = System.Drawing.SystemColors.Control;
            this.options_tab.Controls.Add(this.about_button);
            this.options_tab.Controls.Add(this.browse_button);
            this.options_tab.Controls.Add(this.path_field);
            this.options_tab.Controls.Add(this.label5);
            this.options_tab.Location = new System.Drawing.Point(4, 22);
            this.options_tab.Name = "options_tab";
            this.options_tab.Padding = new System.Windows.Forms.Padding(3);
            this.options_tab.Size = new System.Drawing.Size(466, 261);
            this.options_tab.TabIndex = 1;
            this.options_tab.Text = "Options";
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(363, 232);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(98, 23);
            this.about_button.TabIndex = 3;
            this.about_button.Text = "About...";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(363, 27);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(98, 23);
            this.browse_button.TabIndex = 2;
            this.browse_button.Text = "Browse...";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // path_field
            // 
            this.path_field.Location = new System.Drawing.Point(11, 30);
            this.path_field.Name = "path_field";
            this.path_field.Size = new System.Drawing.Size(331, 20);
            this.path_field.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path:";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 343);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.close_button);
            this.Name = "GUI";
            this.Text = "Password Generator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.length_field)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.main_tab.ResumeLayout(false);
            this.options_tab.ResumeLayout(false);
            this.options_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown length_field;
        private System.Windows.Forms.RadioButton charPass_radio;
        private System.Windows.Forms.RadioButton pronPass_radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox specSymbols_field;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_field;
        private System.Windows.Forms.ComboBox setOfNames_field;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage main_tab;
        private System.Windows.Forms.TabPage options_tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox path_field;
        private System.Windows.Forms.TextBox usersWord_field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Label originalWord_lable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button about_button;
    }
}