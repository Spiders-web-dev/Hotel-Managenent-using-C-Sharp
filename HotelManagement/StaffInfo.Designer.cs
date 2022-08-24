namespace HotelManagement
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.StaffDeleteBtn = new System.Windows.Forms.Button();
            this.StaffEditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Staffgendercb = new System.Windows.Forms.ComboBox();
            this.Staffphonetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Staffnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Staffidtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.StaffGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.passwordtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridview)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1073, 100);
            this.panel1.TabIndex = 13;
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
            this.label1.Location = new System.Drawing.Point(300, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StaffSearch
            // 
            this.StaffSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StaffSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffSearch.HintForeColor = System.Drawing.Color.Empty;
            this.StaffSearch.HintText = "";
            this.StaffSearch.isPassword = false;
            this.StaffSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.StaffSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.StaffSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StaffSearch.LineThickness = 3;
            this.StaffSearch.Location = new System.Drawing.Point(696, 123);
            this.StaffSearch.Margin = new System.Windows.Forms.Padding(4);
            this.StaffSearch.Name = "StaffSearch";
            this.StaffSearch.Size = new System.Drawing.Size(164, 44);
            this.StaffSearch.TabIndex = 21;
            this.StaffSearch.Text = "Staff Search";
            this.StaffSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StaffDeleteBtn
            // 
            this.StaffDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.StaffDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffDeleteBtn.Location = new System.Drawing.Point(195, 562);
            this.StaffDeleteBtn.Name = "StaffDeleteBtn";
            this.StaffDeleteBtn.Size = new System.Drawing.Size(74, 44);
            this.StaffDeleteBtn.TabIndex = 20;
            this.StaffDeleteBtn.Text = "DELETE";
            this.StaffDeleteBtn.UseVisualStyleBackColor = true;
            this.StaffDeleteBtn.Click += new System.EventHandler(this.StaffDeleteBtn_Click);
            // 
            // StaffEditBtn
            // 
            this.StaffEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.StaffEditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffEditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffEditBtn.Location = new System.Drawing.Point(104, 562);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(74, 44);
            this.StaffEditBtn.TabIndex = 19;
            this.StaffEditBtn.Text = "EDIT";
            this.StaffEditBtn.UseVisualStyleBackColor = true;
            this.StaffEditBtn.Click += new System.EventHandler(this.StaffEditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBtn.Location = new System.Drawing.Point(13, 562);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 44);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Staffgendercb
            // 
            this.Staffgendercb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staffgendercb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Staffgendercb.FormattingEnabled = true;
            this.Staffgendercb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Staffgendercb.Location = new System.Drawing.Point(13, 502);
            this.Staffgendercb.Name = "Staffgendercb";
            this.Staffgendercb.Size = new System.Drawing.Size(230, 28);
            this.Staffgendercb.TabIndex = 17;
            this.Staffgendercb.Text = "Gender";
            // 
            // Staffphonetb
            // 
            this.Staffphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Staffphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Staffphonetb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Staffphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.Staffphonetb.HintText = "";
            this.Staffphonetb.isPassword = false;
            this.Staffphonetb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Staffphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.Staffphonetb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Staffphonetb.LineThickness = 3;
            this.Staffphonetb.Location = new System.Drawing.Point(13, 345);
            this.Staffphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.Staffphonetb.Name = "Staffphonetb";
            this.Staffphonetb.Size = new System.Drawing.Size(230, 44);
            this.Staffphonetb.TabIndex = 16;
            this.Staffphonetb.Text = "Phone Number";
            this.Staffphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Staffnametb
            // 
            this.Staffnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Staffnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Staffnametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Staffnametb.HintForeColor = System.Drawing.Color.Empty;
            this.Staffnametb.HintText = "";
            this.Staffnametb.isPassword = false;
            this.Staffnametb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Staffnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.Staffnametb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Staffnametb.LineThickness = 3;
            this.Staffnametb.Location = new System.Drawing.Point(13, 259);
            this.Staffnametb.Margin = new System.Windows.Forms.Padding(4);
            this.Staffnametb.Name = "Staffnametb";
            this.Staffnametb.Size = new System.Drawing.Size(230, 44);
            this.Staffnametb.TabIndex = 15;
            this.Staffnametb.Text = "Staff Name";
            this.Staffnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Staffidtb
            // 
            this.Staffidtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Staffidtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Staffidtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Staffidtb.HintForeColor = System.Drawing.Color.Empty;
            this.Staffidtb.HintText = "";
            this.Staffidtb.isPassword = false;
            this.Staffidtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Staffidtb.LineIdleColor = System.Drawing.Color.Gray;
            this.Staffidtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Staffidtb.LineThickness = 3;
            this.Staffidtb.Location = new System.Drawing.Point(13, 177);
            this.Staffidtb.Margin = new System.Windows.Forms.Padding(4);
            this.Staffidtb.Name = "Staffidtb";
            this.Staffidtb.Size = new System.Drawing.Size(230, 44);
            this.Staffidtb.TabIndex = 14;
            this.Staffidtb.Text = "Staff ID";
            this.Staffidtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(953, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.button4.Location = new System.Drawing.Point(856, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 44);
            this.button4.TabIndex = 23;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StaffGridview
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.StaffGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.StaffGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridview.BackgroundColor = System.Drawing.Color.White;
            this.StaffGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.StaffGridview.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGridview.DefaultCellStyle = dataGridViewCellStyle9;
            this.StaffGridview.EnableHeadersVisualStyles = false;
            this.StaffGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridview.Location = new System.Drawing.Point(348, 177);
            this.StaffGridview.Name = "StaffGridview";
            this.StaffGridview.RowHeadersVisible = false;
            this.StaffGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridview.Size = new System.Drawing.Size(698, 429);
            this.StaffGridview.TabIndex = 22;
            this.StaffGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.StaffGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffGridview.ThemeStyle.HeaderStyle.Height = 25;
            this.StaffGridview.ThemeStyle.ReadOnly = false;
            this.StaffGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridview.ThemeStyle.RowsStyle.Height = 22;
            this.StaffGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridview_CellContentClick);
            // 
            // passwordtb
            // 
            this.passwordtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtb.HintForeColor = System.Drawing.Color.Empty;
            this.passwordtb.HintText = "";
            this.passwordtb.isPassword = false;
            this.passwordtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.passwordtb.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passwordtb.LineThickness = 3;
            this.passwordtb.Location = new System.Drawing.Point(13, 430);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(230, 44);
            this.passwordtb.TabIndex = 25;
            this.passwordtb.Text = "Password";
            this.passwordtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(104, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 44);
            this.button1.TabIndex = 45;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StaffSearch);
            this.Controls.Add(this.StaffDeleteBtn);
            this.Controls.Add(this.StaffEditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Staffgendercb);
            this.Controls.Add(this.Staffphonetb);
            this.Controls.Add(this.Staffnametb);
            this.Controls.Add(this.Staffidtb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StaffGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StaffSearch;
        private System.Windows.Forms.Button StaffDeleteBtn;
        private System.Windows.Forms.Button StaffEditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox Staffgendercb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Staffphonetb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Staffnametb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Staffidtb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaDataGridView StaffGridview;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordtb;
        private System.Windows.Forms.Button button1;
    }
}