namespace HotelManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.usernametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(52, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "QQ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernametb
            // 
            this.usernametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernametb.HintForeColor = System.Drawing.Color.Empty;
            this.usernametb.HintText = "";
            this.usernametb.isPassword = false;
            this.usernametb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.usernametb.LineIdleColor = System.Drawing.Color.Gray;
            this.usernametb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.usernametb.LineThickness = 3;
            this.usernametb.Location = new System.Drawing.Point(13, 103);
            this.usernametb.Margin = new System.Windows.Forms.Padding(4);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(166, 25);
            this.usernametb.TabIndex = 3;
            this.usernametb.Text = "Username";
            this.usernametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordtb
            // 
            this.passwordtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtb.HintForeColor = System.Drawing.Color.Empty;
            this.passwordtb.HintText = "";
            this.passwordtb.isPassword = true;
            this.passwordtb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.passwordtb.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordtb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.passwordtb.LineThickness = 3;
            this.passwordtb.Location = new System.Drawing.Point(13, 152);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(166, 25);
            this.passwordtb.TabIndex = 4;
            this.passwordtb.Text = "Password";
            this.passwordtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(46, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernametb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordtb;
        private System.Windows.Forms.Button button1;
    }
}

