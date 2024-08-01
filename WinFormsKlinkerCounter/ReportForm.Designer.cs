namespace WinFormsKlinkerCounter
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.begin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.licencePlate_comboBox = new System.Windows.Forms.ComboBox();
            this.destination_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reys_label = new System.Windows.Forms.Label();
            this.summaryNetto_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.summaryBrutto_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.licencePlate_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.excelExport_button = new System.Windows.Forms.Button();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.licencePlate_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время начала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время окончания:";
            // 
            // begin_dateTimePicker
            // 
            this.begin_dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.begin_dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.begin_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begin_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.begin_dateTimePicker.Location = new System.Drawing.Point(154, 19);
            this.begin_dateTimePicker.MinDate = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            this.begin_dateTimePicker.Name = "begin_dateTimePicker";
            this.begin_dateTimePicker.ShowUpDown = true;
            this.begin_dateTimePicker.Size = new System.Drawing.Size(143, 22);
            this.begin_dateTimePicker.TabIndex = 3;
            this.begin_dateTimePicker.Value = new System.DateTime(2024, 7, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(321, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер авто:";
            // 
            // licencePlate_comboBox
            // 
            this.licencePlate_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licencePlate_comboBox.FormattingEnabled = true;
            this.licencePlate_comboBox.Location = new System.Drawing.Point(414, 19);
            this.licencePlate_comboBox.Name = "licencePlate_comboBox";
            this.licencePlate_comboBox.Size = new System.Drawing.Size(151, 24);
            this.licencePlate_comboBox.TabIndex = 6;
            this.licencePlate_comboBox.Text = "Все";
            // 
            // destination_comboBox
            // 
            this.destination_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.destination_comboBox.FormattingEnabled = true;
            this.destination_comboBox.Location = new System.Drawing.Point(414, 46);
            this.destination_comboBox.Name = "destination_comboBox";
            this.destination_comboBox.Size = new System.Drawing.Size(151, 24);
            this.destination_comboBox.TabIndex = 8;
            this.destination_comboBox.Text = "Все";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(321, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Маршрут:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кол-во рейсов:";
            // 
            // reys_label
            // 
            this.reys_label.AutoSize = true;
            this.reys_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reys_label.Location = new System.Drawing.Point(232, 590);
            this.reys_label.Name = "reys_label";
            this.reys_label.Size = new System.Drawing.Size(20, 24);
            this.reys_label.TabIndex = 10;
            this.reys_label.Text = "0";
            // 
            // summaryNetto_label
            // 
            this.summaryNetto_label.AutoSize = true;
            this.summaryNetto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summaryNetto_label.Location = new System.Drawing.Point(502, 590);
            this.summaryNetto_label.Name = "summaryNetto_label";
            this.summaryNetto_label.Size = new System.Drawing.Size(45, 24);
            this.summaryNetto_label.TabIndex = 12;
            this.summaryNetto_label.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(344, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Всего нетто:";
            // 
            // summaryBrutto_label
            // 
            this.summaryBrutto_label.AutoSize = true;
            this.summaryBrutto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summaryBrutto_label.Location = new System.Drawing.Point(853, 590);
            this.summaryBrutto_label.Name = "summaryBrutto_label";
            this.summaryBrutto_label.Size = new System.Drawing.Size(45, 24);
            this.summaryBrutto_label.TabIndex = 14;
            this.summaryBrutto_label.Text = "0,00";
            this.summaryBrutto_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(691, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Всего брутто:";
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
            this.licencePlate_dataGridView.Location = new System.Drawing.Point(7, 83);
            this.licencePlate_dataGridView.Name = "licencePlate_dataGridView";
            this.licencePlate_dataGridView.ReadOnly = true;
            this.licencePlate_dataGridView.RowHeadersVisible = false;
            this.licencePlate_dataGridView.RowTemplate.Height = 30;
            this.licencePlate_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licencePlate_dataGridView.Size = new System.Drawing.Size(993, 490);
            this.licencePlate_dataGridView.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 40;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 180;
            // 
            // plateNumber
            // 
            this.plateNumber.HeaderText = "Номер авто";
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.ReadOnly = true;
            this.plateNumber.Width = 220;
            // 
            // tara
            // 
            this.tara.HeaderText = "Тара";
            this.tara.Name = "tara";
            this.tara.ReadOnly = true;
            // 
            // netto
            // 
            this.netto.HeaderText = "Нетто";
            this.netto.Name = "netto";
            this.netto.ReadOnly = true;
            // 
            // brutto
            // 
            this.brutto.HeaderText = "Брутто";
            this.brutto.Name = "brutto";
            this.brutto.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.HeaderText = "Маршрут";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 250;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(592, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 51);
            this.button2.TabIndex = 17;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // print_button
            // 
            this.print_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print_button.Location = new System.Drawing.Point(871, 19);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(133, 51);
            this.print_button.TabIndex = 18;
            this.print_button.Text = "Печать";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // excelExport_button
            // 
            this.excelExport_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelExport_button.Location = new System.Drawing.Point(730, 19);
            this.excelExport_button.Name = "excelExport_button";
            this.excelExport_button.Size = new System.Drawing.Size(133, 51);
            this.excelExport_button.TabIndex = 19;
            this.excelExport_button.Text = "Экспорт в Excel";
            this.excelExport_button.UseVisualStyleBackColor = true;
            this.excelExport_button.Click += new System.EventHandler(this.excelExport_button_Click);
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.end_dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.end_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_dateTimePicker.Location = new System.Drawing.Point(154, 48);
            this.end_dateTimePicker.MinDate = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.ShowUpDown = true;
            this.end_dateTimePicker.Size = new System.Drawing.Size(143, 22);
            this.end_dateTimePicker.TabIndex = 20;
            this.end_dateTimePicker.Value = new System.DateTime(2024, 7, 3, 0, 0, 0, 0);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 631);
            this.Controls.Add(this.end_dateTimePicker);
            this.Controls.Add(this.excelExport_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.licencePlate_dataGridView);
            this.Controls.Add(this.summaryBrutto_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.summaryNetto_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reys_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destination_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.licencePlate_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.begin_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licencePlate_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker begin_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox licencePlate_comboBox;
        private System.Windows.Forms.ComboBox destination_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label reys_label;
        private System.Windows.Forms.Label summaryNetto_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label summaryBrutto_label;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView licencePlate_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tara;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button excelExport_button;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}