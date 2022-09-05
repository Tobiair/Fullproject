namespace sqlite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.SpecialRules = new System.Windows.Forms.TextBox();
            this.Faction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(677, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 388);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Location = new System.Drawing.Point(954, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(205, 388);
            this.listBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 115);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Character";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(106, 92);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(250, 39);
            this.name.TabIndex = 4;
            // 
            // SpecialRules
            // 
            this.SpecialRules.Location = new System.Drawing.Point(106, 171);
            this.SpecialRules.Name = "SpecialRules";
            this.SpecialRules.Size = new System.Drawing.Size(250, 39);
            this.SpecialRules.TabIndex = 5;
            // 
            // Faction
            // 
            this.Faction.Location = new System.Drawing.Point(106, 258);
            this.Faction.Name = "Faction";
            this.Faction.Size = new System.Drawing.Size(250, 39);
            this.Faction.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Special Rules";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Faction";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(974, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 68);
            this.button3.TabIndex = 10;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Faction);
            this.Controls.Add(this.SpecialRules);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private TextBox name;
        private TextBox SpecialRules;
        private TextBox Faction;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}