namespace HotelManagement
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReserIdtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.Reservationsearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ReservationGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.ReservationDeleteBtn = new System.Windows.Forms.Button();
            this.ReservationEditBtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.Clientcb = new System.Windows.Forms.ComboBox();
            this.Roomcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridview)).BeginInit();
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
            this.panel1.TabIndex = 15;
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
            this.label1.Size = new System.Drawing.Size(347, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Informations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReserIdtb
            // 
            this.ReserIdtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReserIdtb.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.ReserIdtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReserIdtb.HintForeColor = System.Drawing.Color.Empty;
            this.ReserIdtb.HintText = "";
            this.ReserIdtb.isPassword = false;
            this.ReserIdtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ReserIdtb.LineIdleColor = System.Drawing.Color.Gray;
            this.ReserIdtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ReserIdtb.LineThickness = 4;
            this.ReserIdtb.Location = new System.Drawing.Point(34, 208);
            this.ReserIdtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReserIdtb.Name = "ReserIdtb";
            this.ReserIdtb.Size = new System.Drawing.Size(230, 52);
            this.ReserIdtb.TabIndex = 18;
            this.ReserIdtb.Text = "Reservation ID";
            this.ReserIdtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReserIdtb.OnValueChanged += new System.EventHandler(this.Roomnumtb_OnValueChanged);
            // 
            // Datein
            // 
            this.Datein.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datein.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.Datein.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.Datein.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datein.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datein.Location = new System.Drawing.Point(117, 436);
            this.Datein.Name = "Datein";
            this.Datein.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Datein.Size = new System.Drawing.Size(147, 26);
            this.Datein.TabIndex = 21;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(30, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "DateIn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(30, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "DateOut";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dateout
            // 
            this.Dateout.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dateout.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dateout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dateout.Location = new System.Drawing.Point(117, 480);
            this.Dateout.Name = "Dateout";
            this.Dateout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dateout.Size = new System.Drawing.Size(147, 26);
            this.Dateout.TabIndex = 23;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // Reservationsearch
            // 
            this.Reservationsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Reservationsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Reservationsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reservationsearch.HintForeColor = System.Drawing.Color.Empty;
            this.Reservationsearch.HintText = "";
            this.Reservationsearch.isPassword = false;
            this.Reservationsearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.Reservationsearch.LineIdleColor = System.Drawing.Color.Gray;
            this.Reservationsearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Reservationsearch.LineThickness = 3;
            this.Reservationsearch.Location = new System.Drawing.Point(708, 121);
            this.Reservationsearch.Margin = new System.Windows.Forms.Padding(4);
            this.Reservationsearch.Name = "Reservationsearch";
            this.Reservationsearch.Size = new System.Drawing.Size(164, 44);
            this.Reservationsearch.TabIndex = 32;
            this.Reservationsearch.Text = "Reservation Search";
            this.Reservationsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(965, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.TabIndex = 35;
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
            this.button4.TabIndex = 34;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReservationGridview
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ReservationGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReservationGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationGridview.BackgroundColor = System.Drawing.Color.White;
            this.ReservationGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReservationGridview.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationGridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReservationGridview.EnableHeadersVisualStyles = false;
            this.ReservationGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridview.Location = new System.Drawing.Point(360, 175);
            this.ReservationGridview.Name = "ReservationGridview";
            this.ReservationGridview.RowHeadersVisible = false;
            this.ReservationGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationGridview.Size = new System.Drawing.Size(698, 429);
            this.ReservationGridview.TabIndex = 33;
            this.ReservationGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ReservationGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReservationGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReservationGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReservationGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReservationGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.ReservationGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReservationGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReservationGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReservationGridview.ThemeStyle.HeaderStyle.Height = 25;
            this.ReservationGridview.ThemeStyle.ReadOnly = false;
            this.ReservationGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridview.ThemeStyle.RowsStyle.Height = 22;
            this.ReservationGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridview_CellContentClick);
            // 
            // ReservationDeleteBtn
            // 
            this.ReservationDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReservationDeleteBtn.Location = new System.Drawing.Point(219, 533);
            this.ReservationDeleteBtn.Name = "ReservationDeleteBtn";
            this.ReservationDeleteBtn.Size = new System.Drawing.Size(74, 44);
            this.ReservationDeleteBtn.TabIndex = 39;
            this.ReservationDeleteBtn.Text = "DELETE";
            this.ReservationDeleteBtn.UseVisualStyleBackColor = true;
            this.ReservationDeleteBtn.Click += new System.EventHandler(this.ReservationDeleteBtn_Click);
            // 
            // ReservationEditBtn
            // 
            this.ReservationEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationEditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationEditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReservationEditBtn.Location = new System.Drawing.Point(128, 533);
            this.ReservationEditBtn.Name = "ReservationEditBtn";
            this.ReservationEditBtn.Size = new System.Drawing.Size(74, 44);
            this.ReservationEditBtn.TabIndex = 38;
            this.ReservationEditBtn.Text = "EDIT";
            this.ReservationEditBtn.UseVisualStyleBackColor = true;
            this.ReservationEditBtn.Click += new System.EventHandler(this.ReservationEditBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddRoomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRoomBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRoomBtn.Location = new System.Drawing.Point(37, 533);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(74, 44);
            this.AddRoomBtn.TabIndex = 37;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = true;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // Clientcb
            // 
            this.Clientcb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clientcb.FormattingEnabled = true;
            this.Clientcb.Location = new System.Drawing.Point(117, 292);
            this.Clientcb.Name = "Clientcb";
            this.Clientcb.Size = new System.Drawing.Size(147, 28);
            this.Clientcb.TabIndex = 40;
            this.Clientcb.Text = "Client Name";
            // 
            // Roomcb
            // 
            this.Roomcb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Roomcb.FormattingEnabled = true;
            this.Roomcb.Location = new System.Drawing.Point(117, 346);
            this.Roomcb.Name = "Roomcb";
            this.Roomcb.Size = new System.Drawing.Size(147, 28);
            this.Roomcb.TabIndex = 41;
            this.Roomcb.Text = "Room ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Client";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Room";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.button1.Location = new System.Drawing.Point(128, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 44);
            this.button1.TabIndex = 44;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Roomcb);
            this.Controls.Add(this.Clientcb);
            this.Controls.Add(this.ReservationDeleteBtn);
            this.Controls.Add(this.ReservationEditBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.Reservationsearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReservationGridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dateout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datein);
            this.Controls.Add(this.ReserIdtb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ReserIdtb;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dateout;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Reservationsearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaDataGridView ReservationGridview;
        private System.Windows.Forms.Button ReservationDeleteBtn;
        private System.Windows.Forms.Button ReservationEditBtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.ComboBox Clientcb;
        private System.Windows.Forms.ComboBox Roomcb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}