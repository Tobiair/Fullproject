namespace sqlite
{
    partial class playerOptions
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
            this.playerName = new System.Windows.Forms.TextBox();
            this.ArmyName = new System.Windows.Forms.TextBox();
            this.NamedCharacters = new System.Windows.Forms.TextBox();
            this.EnterName = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(305, 74);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(173, 31);
            this.playerName.TabIndex = 0;
            this.playerName.TextChanged += new System.EventHandler(this.playerName_TextChanged);
            // 
            // ArmyName
            // 
            this.ArmyName.Location = new System.Drawing.Point(305, 111);
            this.ArmyName.Name = "ArmyName";
            this.ArmyName.Size = new System.Drawing.Size(173, 31);
            this.ArmyName.TabIndex = 1;
            this.ArmyName.TextChanged += new System.EventHandler(this.ArmyName_TextChanged);
            // 
            // NamedCharacters
            // 
            this.NamedCharacters.Location = new System.Drawing.Point(305, 148);
            this.NamedCharacters.Name = "NamedCharacters";
            this.NamedCharacters.Size = new System.Drawing.Size(173, 31);
            this.NamedCharacters.TabIndex = 2;
            this.NamedCharacters.TextChanged += new System.EventHandler(this.NamedCharacters_TextChanged);
            // 
            // EnterName
            // 
            this.EnterName.Location = new System.Drawing.Point(329, 185);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(112, 34);
            this.EnterName.TabIndex = 3;
            this.EnterName.Text = "EnterPlayer";
            this.EnterName.UseVisualStyleBackColor = true;
            this.EnterName.Click += new System.EventHandler(this.EnterName_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(329, 274);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(112, 34);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // playerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.EnterName);
            this.Controls.Add(this.NamedCharacters);
            this.Controls.Add(this.ArmyName);
            this.Controls.Add(this.playerName);
            this.Name = "playerOptions";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.playerOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox playerName;
        private TextBox ArmyName;
        private TextBox NamedCharacters;
        private Button EnterName;
        private Button Next;
    }
}