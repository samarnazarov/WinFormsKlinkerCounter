namespace WinFormsKlinkerCounter
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qrCode_pictureBox = new System.Windows.Forms.PictureBox();
            this.qrCodeText_textBox = new System.Windows.Forms.TextBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.brutto_textBox = new System.Windows.Forms.TextBox();
            this.writeDataTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНастроекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sensor_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.destination_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.test_button = new System.Windows.Forms.Button();
            this.weightIndicator_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.licencePlate_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NullIndicator_panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.NULL_button = new System.Windows.Forms.Button();
            this.StabIndicator_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.netto_textBox = new System.Windows.Forms.TextBox();
            this.tara_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPort = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qrCode_pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencePlate_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrCode_pictureBox
            // 
            this.qrCode_pictureBox.Location = new System.Drawing.Point(11, 44);
            this.qrCode_pictureBox.Name = "qrCode_pictureBox";
            this.qrCode_pictureBox.Size = new System.Drawing.Size(423, 344);
            this.qrCode_pictureBox.TabIndex = 0;
            this.qrCode_pictureBox.TabStop = false;
            // 
            // qrCodeText_textBox
            // 
            this.qrCodeText_textBox.Location = new System.Drawing.Point(9, 64);
            this.qrCodeText_textBox.Name = "qrCodeText_textBox";
            this.qrCodeText_textBox.Size = new System.Drawing.Size(194, 29);
            this.qrCodeText_textBox.TabIndex = 1;
            this.qrCodeText_textBox.TextChanged += new System.EventHandler(this.qrCodeText_textBox_TextChanged);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // brutto_textBox
            // 
            this.brutto_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brutto_textBox.Location = new System.Drawing.Point(118, 129);
            this.brutto_textBox.Multiline = true;
            this.brutto_textBox.Name = "brutto_textBox";
            this.brutto_textBox.Size = new System.Drawing.Size(134, 30);
            this.brutto_textBox.TabIndex = 7;
            this.brutto_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.brutto_textBox.TextChanged += new System.EventHandler(this.brutto_textBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem});
            this.стартToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.стартToolStripMenuItem.Text = "Файл";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.CheckOnClick = true;
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.CheckedChanged += new System.EventHandler(this.запуститьToolStripMenuItem_CheckedChanged);
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click_1);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьНастроекToolStripMenuItem});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // записьНастроекToolStripMenuItem
            // 
            this.записьНастроекToolStripMenuItem.Name = "записьНастроекToolStripMenuItem";
            this.записьНастроекToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.записьНастроекToolStripMenuItem.Text = "Запись настроек";
            this.записьНастроекToolStripMenuItem.Click += new System.EventHandler(this.записьНастроекToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетToolStripMenuItem});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер автомобиля";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.sensor_label);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.destination_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.infoLabel);
            this.groupBox1.Controls.Add(this.test_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.qrCodeText_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(440, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 352);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные авто";
            // 
            // sensor_label
            // 
            this.sensor_label.AutoSize = true;
            this.sensor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensor_label.Location = new System.Drawing.Point(82, 276);
            this.sensor_label.Name = "sensor_label";
            this.sensor_label.Size = new System.Drawing.Size(20, 24);
            this.sensor_label.TabIndex = 21;
            this.sensor_label.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sensor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Camera";
            // 
            // destination_textBox
            // 
            this.destination_textBox.Location = new System.Drawing.Point(6, 133);
            this.destination_textBox.Name = "destination_textBox";
            this.destination_textBox.Size = new System.Drawing.Size(194, 29);
            this.destination_textBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Маршрут";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(82, 312);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(15, 24);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = ":";
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(6, 188);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(64, 39);
            this.test_button.TabIndex = 13;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // weightIndicator_label
            // 
            this.weightIndicator_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weightIndicator_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightIndicator_label.ForeColor = System.Drawing.Color.Red;
            this.weightIndicator_label.Location = new System.Drawing.Point(5, 169);
            this.weightIndicator_label.Name = "weightIndicator_label";
            this.weightIndicator_label.Size = new System.Drawing.Size(316, 74);
            this.weightIndicator_label.TabIndex = 14;
            this.weightIndicator_label.Text = "0.0";
            this.weightIndicator_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(259, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "тн.";
            // 
            // licencePlate_dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.licencePlate_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.licencePlate_dataGridView.ColumnHeadersHeight = 25;
            this.licencePlate_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.licencePlate_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.plateNumber,
            this.tara,
            this.netto,
            this.brutto,
            this.destination});
            this.licencePlate_dataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.licencePlate_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.licencePlate_dataGridView.EnableHeadersVisualStyles = false;
            this.licencePlate_dataGridView.Location = new System.Drawing.Point(10, 399);
            this.licencePlate_dataGridView.Name = "licencePlate_dataGridView";
            this.licencePlate_dataGridView.RowHeadersVisible = false;
            this.licencePlate_dataGridView.RowTemplate.Height = 30;
            this.licencePlate_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licencePlate_dataGridView.Size = new System.Drawing.Size(993, 245);
            this.licencePlate_dataGridView.TabIndex = 11;
            this.licencePlate_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.licencePlate_dataGridView_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 40;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.Width = 180;
            // 
            // plateNumber
            // 
            this.plateNumber.HeaderText = "Номер авто";
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.Width = 220;
            // 
            // tara
            // 
            this.tara.HeaderText = "Тара";
            this.tara.Name = "tara";
            // 
            // netto
            // 
            this.netto.HeaderText = "Нетто";
            this.netto.Name = "netto";
            // 
            // brutto
            // 
            this.brutto.HeaderText = "Брутто";
            this.brutto.Name = "brutto";
            // 
            // destination
            // 
            this.destination.HeaderText = "Маршрут";
            this.destination.Name = "destination";
            this.destination.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weightIndicator_label);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.netto_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tara_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.brutto_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(674, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 349);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные весов";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.NullIndicator_panel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.NULL_button);
            this.panel1.Controls.Add(this.StabIndicator_panel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(24, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 86);
            this.panel1.TabIndex = 20;
            // 
            // NullIndicator_panel
            // 
            this.NullIndicator_panel.BackColor = System.Drawing.Color.Red;
            this.NullIndicator_panel.Location = new System.Drawing.Point(73, 35);
            this.NullIndicator_panel.Name = "NullIndicator_panel";
            this.NullIndicator_panel.Size = new System.Drawing.Size(41, 15);
            this.NullIndicator_panel.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(71, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "НОЛЬ";
            // 
            // NULL_button
            // 
            this.NULL_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NULL_button.Location = new System.Drawing.Point(63, 57);
            this.NULL_button.Name = "NULL_button";
            this.NULL_button.Size = new System.Drawing.Size(60, 23);
            this.NULL_button.TabIndex = 21;
            this.NULL_button.Text = "НОЛЬ";
            this.NULL_button.UseVisualStyleBackColor = true;
            // 
            // StabIndicator_panel
            // 
            this.StabIndicator_panel.BackColor = System.Drawing.Color.Red;
            this.StabIndicator_panel.Location = new System.Drawing.Point(19, 35);
            this.StabIndicator_panel.Name = "StabIndicator_panel";
            this.StabIndicator_panel.Size = new System.Drawing.Size(41, 15);
            this.StabIndicator_panel.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "СТАБ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(261, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "тн.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(260, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "тн.";
            // 
            // netto_textBox
            // 
            this.netto_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.netto_textBox.Location = new System.Drawing.Point(118, 89);
            this.netto_textBox.Multiline = true;
            this.netto_textBox.Name = "netto_textBox";
            this.netto_textBox.Size = new System.Drawing.Size(134, 30);
            this.netto_textBox.TabIndex = 16;
            this.netto_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tara_textBox
            // 
            this.tara_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tara_textBox.Location = new System.Drawing.Point(118, 49);
            this.tara_textBox.Multiline = true;
            this.tara_textBox.Name = "tara_textBox";
            this.tara_textBox.Size = new System.Drawing.Size(134, 30);
            this.tara_textBox.TabIndex = 15;
            this.tara_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Брутто:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Нетто:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тара:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // timerPort
            // 
            this.timerPort.Interval = 5000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1008, 669);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.licencePlate_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qrCode_pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа учета клинкера";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCode_pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencePlate_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCode_pictureBox;
        private System.Windows.Forms.TextBox qrCodeText_textBox;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.TextBox brutto_textBox;
        private System.Windows.Forms.Timer writeDataTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView licencePlate_dataGridView;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox netto_textBox;
        private System.Windows.Forms.TextBox tara_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel StabIndicator_panel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label weightIndicator_label;
        private System.Windows.Forms.ToolStripMenuItem записьНастроекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.Timer timerPort;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox destination_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NULL_button;
        private System.Windows.Forms.Panel NullIndicator_panel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tara;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sensor_label;
    }
}

