namespace HotelManagement
{
    partial class RoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Roomphonetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Roomnumtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yesradio = new Guna.UI.WinForms.GunaRadioButton();
            this.Noradio = new Guna.UI.WinForms.GunaRadioButton();
            this.StaffDeleteBtn = new System.Windows.Forms.Button();
            this.StaffEditBtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.RoomSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RoomGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1070, 100);
            this.panel1.TabIndex = 14;
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
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Informations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Roomphonetb
            // 
            this.Roomphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Roomphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Roomphonetb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Roomphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.Roomphonetb.HintText = "";
            this.Roomphonetb.isPassword = false;
            this.Roomphonetb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Roomphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.Roomphonetb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Roomphonetb.LineThickness = 3;
            this.Roomphonetb.Location = new System.Drawing.Point(13, 279);
            this.Roomphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.Roomphonetb.Name = "Roomphonetb";
            this.Roomphonetb.Size = new System.Drawing.Size(230, 44);
            this.Roomphonetb.TabIndex = 17;
            this.Roomphonetb.Text = "Room Phone";
            this.Roomphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Roomnumtb
            // 
            this.Roomnumtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Roomnumtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Roomnumtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Roomnumtb.HintForeColor = System.Drawing.Color.Empty;
            this.Roomnumtb.HintText = "";
            this.Roomnumtb.isPassword = false;
            this.Roomnumtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Roomnumtb.LineIdleColor = System.Drawing.Color.Gray;
            this.Roomnumtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Roomnumtb.LineThickness = 3;
            this.Roomnumtb.Location = new System.Drawing.Point(13, 197);
            this.Roomnumtb.Margin = new System.Windows.Forms.Padding(4);
            this.Roomnumtb.Name = "Roomnumtb";
            this.Roomnumtb.Size = new System.Drawing.Size(230, 44);
            this.Roomnumtb.TabIndex = 16;
            this.Roomnumtb.Text = "Room Number";
            this.Roomnumtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Free";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Yesradio
            // 
            this.Yesradio.BaseColor = System.Drawing.SystemColors.Control;
            this.Yesradio.CheckedOffColor = System.Drawing.Color.Gray;
            this.Yesradio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Yesradio.FillColor = System.Drawing.Color.White;
            this.Yesradio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesradio.Location = new System.Drawing.Point(77, 358);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(56, 22);
            this.Yesradio.TabIndex = 18;
            this.Yesradio.Text = "YES";
            this.Yesradio.CheckedChanged += new System.EventHandler(this.gunaRadioButton1_CheckedChanged);
            // 
            // Noradio
            // 
            this.Noradio.BaseColor = System.Drawing.SystemColors.Control;
            this.Noradio.CheckedOffColor = System.Drawing.Color.Gray;
            this.Noradio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Noradio.FillColor = System.Drawing.Color.White;
            this.Noradio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noradio.Location = new System.Drawing.Point(160, 357);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(56, 22);
            this.Noradio.TabIndex = 19;
            this.Noradio.Text = "NO";
            // 
            // StaffDeleteBtn
            // 
            this.StaffDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.StaffDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffDeleteBtn.Location = new System.Drawing.Point(197, 437);
            this.StaffDeleteBtn.Name = "StaffDeleteBtn";
            this.StaffDeleteBtn.Size = new System.Drawing.Size(74, 44);
            this.StaffDeleteBtn.TabIndex = 23;
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
            this.StaffEditBtn.Location = new System.Drawing.Point(106, 437);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(74, 44);
            this.StaffEditBtn.TabIndex = 22;
            this.StaffEditBtn.Text = "EDIT";
            this.StaffEditBtn.UseVisualStyleBackColor = true;
            this.StaffEditBtn.Click += new System.EventHandler(this.StaffEditBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddRoomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRoomBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRoomBtn.Location = new System.Drawing.Point(15, 437);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(74, 44);
            this.AddRoomBtn.TabIndex = 21;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = true;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // RoomSearch
            // 
            this.RoomSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RoomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoomSearch.HintForeColor = System.Drawing.Color.Empty;
            this.RoomSearch.HintText = "";
            this.RoomSearch.isPassword = false;
            this.RoomSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.RoomSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.RoomSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.RoomSearch.LineThickness = 3;
            this.RoomSearch.Location = new System.Drawing.Point(708, 121);
            this.RoomSearch.Margin = new System.Windows.Forms.Padding(4);
            this.RoomSearch.Name = "RoomSearch";
            this.RoomSearch.Size = new System.Drawing.Size(164, 44);
            this.RoomSearch.TabIndex = 28;
            this.RoomSearch.Text = "Room Search";
            this.RoomSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(965, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.TabIndex = 31;
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
            this.button4.Location = new System.Drawing.Point(868, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 44);
            this.button4.TabIndex = 30;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomGridview
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.RoomGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.RoomGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomGridview.BackgroundColor = System.Drawing.Color.White;
            this.RoomGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.RoomGridview.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGridview.DefaultCellStyle = dataGridViewCellStyle9;
            this.RoomGridview.EnableHeadersVisualStyles = false;
            this.RoomGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridview.Location = new System.Drawing.Point(360, 175);
            this.RoomGridview.Name = "RoomGridview";
            this.RoomGridview.RowHeadersVisible = false;
            this.RoomGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridview.Size = new System.Drawing.Size(698, 429);
            this.RoomGridview.TabIndex = 29;
            this.RoomGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.RoomGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.RoomGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomGridview.ThemeStyle.HeaderStyle.Height = 25;
            this.RoomGridview.ThemeStyle.ReadOnly = false;
            this.RoomGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGridview.ThemeStyle.RowsStyle.Height = 22;
            this.RoomGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridview_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(106, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 44);
            this.button1.TabIndex = 45;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RoomSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RoomGridview);
            this.Controls.Add(this.StaffDeleteBtn);
            this.Controls.Add(this.StaffEditBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Roomphonetb);
            this.Controls.Add(this.Roomnumtb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Roomphonetb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Roomnumtb;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaRadioButton Yesradio;
        private Guna.UI.WinForms.GunaRadioButton Noradio;
        private System.Windows.Forms.Button StaffDeleteBtn;
        private System.Windows.Forms.Button StaffEditBtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RoomSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaDataGridView RoomGridview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}