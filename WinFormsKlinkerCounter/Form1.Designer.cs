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
            this.modbusOn_button = new System.Windows.Forms.Button();
            this.modbusOff_button = new System.Windows.Forms.Button();
            this.brutto_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.test_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.writeToDataBase_button = new System.Windows.Forms.Button();
            this.licencePlate_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tara_textBox = new System.Windows.Forms.TextBox();
            this.netto_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode_pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencePlate_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrCode_pictureBox
            // 
            this.qrCode_pictureBox.Location = new System.Drawing.Point(50, 44);
            this.qrCode_pictureBox.Name = "qrCode_pictureBox";
            this.qrCode_pictureBox.Size = new System.Drawing.Size(525, 333);
            this.qrCode_pictureBox.TabIndex = 0;
            this.qrCode_pictureBox.TabStop = false;
            // 
            // qrCodeText_textBox
            // 
            this.qrCodeText_textBox.Location = new System.Drawing.Point(31, 90);
            this.qrCodeText_textBox.Name = "qrCodeText_textBox";
            this.qrCodeText_textBox.Size = new System.Drawing.Size(177, 29);
            this.qrCodeText_textBox.TabIndex = 1;
            this.qrCodeText_textBox.TextChanged += new System.EventHandler(this.qrCodeText_textBox_TextChanged);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // modbusOn_button
            // 
            this.modbusOn_button.Location = new System.Drawing.Point(220, 285);
            this.modbusOn_button.Name = "modbusOn_button";
            this.modbusOn_button.Size = new System.Drawing.Size(107, 35);
            this.modbusOn_button.TabIndex = 4;
            this.modbusOn_button.Text = "TurnOn Register";
            this.modbusOn_button.UseVisualStyleBackColor = true;
            this.modbusOn_button.Click += new System.EventHandler(this.modbusOn_button_Click);
            // 
            // modbusOff_button
            // 
            this.modbusOff_button.Location = new System.Drawing.Point(220, 241);
            this.modbusOff_button.Name = "modbusOff_button";
            this.modbusOff_button.Size = new System.Drawing.Size(107, 34);
            this.modbusOff_button.TabIndex = 5;
            this.modbusOff_button.Text = "TurnOff Register";
            this.modbusOff_button.UseVisualStyleBackColor = true;
            this.modbusOff_button.Click += new System.EventHandler(this.modbusOff_button_Click);
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
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 33);
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
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер автомобиля";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.test_button);
            this.groupBox1.Controls.Add(this.modbusOn_button);
            this.groupBox1.Controls.Add(this.modbusOff_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.qrCodeText_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(601, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 339);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные авто";
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(21, 272);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(64, 39);
            this.test_button.TabIndex = 13;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
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
            // writeToDataBase_button
            // 
            this.writeToDataBase_button.Location = new System.Drawing.Point(184, 278);
            this.writeToDataBase_button.Name = "writeToDataBase_button";
            this.writeToDataBase_button.Size = new System.Drawing.Size(123, 43);
            this.writeToDataBase_button.TabIndex = 12;
            this.writeToDataBase_button.Text = "Записать";
            this.writeToDataBase_button.UseVisualStyleBackColor = true;
            this.writeToDataBase_button.Click += new System.EventHandler(this.writeToDataBase_button_Click);
            // 
            // licencePlate_dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.licencePlate_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.licencePlate_dataGridView.ColumnHeadersHeight = 35;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.licencePlate_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.licencePlate_dataGridView.EnableHeadersVisualStyles = false;
            this.licencePlate_dataGridView.Location = new System.Drawing.Point(48, 399);
            this.licencePlate_dataGridView.Name = "licencePlate_dataGridView";
            this.licencePlate_dataGridView.RowHeadersVisible = false;
            this.licencePlate_dataGridView.RowTemplate.Height = 30;
            this.licencePlate_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licencePlate_dataGridView.Size = new System.Drawing.Size(1251, 402);
            this.licencePlate_dataGridView.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.Width = 220;
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
            this.destination.Width = 430;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.writeToDataBase_button);
            this.groupBox2.Controls.Add(this.netto_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tara_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.brutto_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(969, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 338);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные весов";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1342, 842);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.licencePlate_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qrCode_pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа учета клинкера";
            ((System.ComponentModel.ISupportInitialize)(this.qrCode_pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencePlate_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCode_pictureBox;
        private System.Windows.Forms.TextBox qrCodeText_textBox;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Button modbusOn_button;
        private System.Windows.Forms.Button modbusOff_button;
        private System.Windows.Forms.TextBox brutto_textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeToDataBase_button;
        public System.Windows.Forms.DataGridView licencePlate_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tara;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox netto_textBox;
        private System.Windows.Forms.TextBox tara_textBox;
    }
}

