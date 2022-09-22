namespace sqlite
{
    partial class MainHex
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Hexnum = new System.Windows.Forms.Label();
            this.CompaniesPresent = new System.Windows.Forms.Label();
            this.Terrian = new System.Windows.Forms.Label();
            this.HexNum1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hexnum
            // 
            this.Hexnum.AutoSize = true;
            this.Hexnum.Location = new System.Drawing.Point(1073, 24);
            this.Hexnum.Name = "Hexnum";
            this.Hexnum.Size = new System.Drawing.Size(0, 25);
            this.Hexnum.TabIndex = 2;
            // 
            // CompaniesPresent
            // 
            this.CompaniesPresent.AutoSize = true;
            this.CompaniesPresent.Location = new System.Drawing.Point(1073, 49);
            this.CompaniesPresent.Name = "CompaniesPresent";
            this.CompaniesPresent.Size = new System.Drawing.Size(0, 25);
            this.CompaniesPresent.TabIndex = 3;
            // 
            // Terrian
            // 
            this.Terrian.AutoSize = true;
            this.Terrian.Location = new System.Drawing.Point(1073, 74);
            this.Terrian.Name = "Terrian";
            this.Terrian.Size = new System.Drawing.Size(0, 25);
            this.Terrian.TabIndex = 4;
            // 
            // HexNum1
            // 
            this.HexNum1.FormattingEnabled = true;
            this.HexNum1.ItemHeight = 25;
            this.HexNum1.Location = new System.Drawing.Point(1024, 9);
            this.HexNum1.Name = "HexNum1";
            this.HexNum1.Size = new System.Drawing.Size(180, 129);
            this.HexNum1.TabIndex = 5;
            // 
            // MainHex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.HexNum1);
            this.Controls.Add(this.Terrian);
            this.Controls.Add(this.CompaniesPresent);
            this.Controls.Add(this.Hexnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainHex";
            this.Text = "MainHex";
            this.Load += new System.EventHandler(this.MainHex_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainHex_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label Hexnum;
        private Label CompaniesPresent;
        private Label Terrian;
        private ListBox HexNum1;
    }
}