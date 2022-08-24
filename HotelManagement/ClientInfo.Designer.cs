namespace HotelManagement
{
    partial class ClientInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientidtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clientnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clientphonetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clientctrycb = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClientSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClientGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 100);
            this.panel1.TabIndex = 0;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.BackColor = System.Drawing.Color.DimGray;
            this.Datelbl.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Datelbl.Location = new System.Drawing.Point(875, 66);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(54, 23);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            this.Datelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(316, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clientidtb
            // 
            this.clientidtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientidtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientidtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientidtb.HintForeColor = System.Drawing.Color.Empty;
            this.clientidtb.HintText = "";
            this.clientidtb.isPassword = false;
            this.clientidtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.clientidtb.LineIdleColor = System.Drawing.Color.Gray;
            this.clientidtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.clientidtb.LineThickness = 3;
            this.clientidtb.Location = new System.Drawing.Point(13, 181);
            this.clientidtb.Margin = new System.Windows.Forms.Padding(4);
            this.clientidtb.Name = "clientidtb";
            this.clientidtb.Size = new System.Drawing.Size(230, 44);
            this.clientidtb.TabIndex = 1;
            this.clientidtb.Text = "Client ID";
            this.clientidtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // clientnametb
            // 
            this.clientnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientnametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientnametb.HintForeColor = System.Drawing.Color.Empty;
            this.clientnametb.HintText = "";
            this.clientnametb.isPassword = false;
            this.clientnametb.LineFocusedColor = System.Drawing.Color.Blue;
            this.clientnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.clientnametb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.clientnametb.LineThickness = 3;
            this.clientnametb.Location = new System.Drawing.Point(13, 280);
            this.clientnametb.Margin = new System.Windows.Forms.Padding(4);
            this.clientnametb.Name = "clientnametb";
            this.clientnametb.Size = new System.Drawing.Size(230, 44);
            this.clientnametb.TabIndex = 2;
            this.clientnametb.Text = "Client Name";
            this.clientnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // clientphonetb
            // 
            this.clientphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientphonetb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.clientphonetb.HintText = "";
            this.clientphonetb.isPassword = false;
            this.clientphonetb.LineFocusedColor = System.Drawing.Color.Blue;
            this.clientphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.clientphonetb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.clientphonetb.LineThickness = 3;
            this.clientphonetb.Location = new System.Drawing.Point(13, 375);
            this.clientphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.clientphonetb.Name = "clientphonetb";
            this.clientphonetb.Size = new System.Drawing.Size(230, 44);
            this.clientphonetb.TabIndex = 3;
            this.clientphonetb.Text = "Phone Number";
            this.clientphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // clientctrycb
            // 
            this.clientctrycb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientctrycb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientctrycb.FormattingEnabled = true;
            this.clientctrycb.Items.AddRange(new object[] {
            "America",
            "Bangladesh",
            "China",
            "India",
            "France",
            "England",
            "United State",
            ""});
            this.clientctrycb.Location = new System.Drawing.Point(13, 465);
            this.clientctrycb.Name = "clientctrycb";
            this.clientctrycb.Size = new System.Drawing.Size(230, 28);
            this.clientctrycb.TabIndex = 4;
            this.clientctrycb.Text = "Country";
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBtn.Location = new System.Drawing.Point(13, 533);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 44);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditBtn.Location = new System.Drawing.Point(105, 533);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(74, 44);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteBtn.Location = new System.Drawing.Point(195, 533);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 44);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClientSearch
            // 
            this.ClientSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ClientSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSearch.HintForeColor = System.Drawing.Color.Empty;
            this.ClientSearch.HintText = "";
            this.ClientSearch.isPassword = false;
            this.ClientSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.ClientSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.ClientSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ClientSearch.LineThickness = 3;
            this.ClientSearch.Location = new System.Drawing.Point(697, 130);
            this.ClientSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ClientSearch.Name = "ClientSearch";
            this.ClientSearch.Size = new System.Drawing.Size(164, 44);
            this.ClientSearch.TabIndex = 9;
            this.ClientSearch.Text = "Client Search";
            this.ClientSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientGridview
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ClientGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ClientGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientGridview.BackgroundColor = System.Drawing.Color.White;
            this.ClientGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ClientGridview.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGridview.DefaultCellStyle = dataGridViewCellStyle9;
            this.ClientGridview.EnableHeadersVisualStyles = false;
            this.ClientGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientGridview.Location = new System.Drawing.Point(350, 181);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersVisible = false;
            this.ClientGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridview.Size = new System.Drawing.Size(689, 396);
            this.ClientGridview.TabIndex = 10;
            this.ClientGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.ClientGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientGridview.ThemeStyle.HeaderStyle.Height = 25;
            this.ClientGridview.ThemeStyle.ReadOnly = false;
            this.ClientGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClientGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClientGridview.ThemeStyle.RowsStyle.Height = 22;
            this.ClientGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClientGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridview_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(857, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(954, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(105, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 44);
            this.button1.TabIndex = 45;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1101, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.ClientSearch);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.clientctrycb);
            this.Controls.Add(this.clientphonetb);
            this.Controls.Add(this.clientnametb);
            this.Controls.Add(this.clientidtb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientidtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientnametb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientphonetb;
        private System.Windows.Forms.ComboBox clientctrycb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ClientSearch;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaDataGridView ClientGridview;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}