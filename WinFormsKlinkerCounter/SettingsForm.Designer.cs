namespace WinFormsKlinkerCounter
{
    partial class SettingsForm
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
            this.rs232_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBaseName_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activationMaxWeight_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.writingBeginInterval_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rs485_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iniFileReading_button = new System.Windows.Forms.Button();
            this.cameraUrl_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RS-232 Port";
            // 
            // rs232_comboBox
            // 
            this.rs232_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rs232_comboBox.FormattingEnabled = true;
            this.rs232_comboBox.Location = new System.Drawing.Point(144, 28);
            this.rs232_comboBox.Name = "rs232_comboBox";
            this.rs232_comboBox.Size = new System.Drawing.Size(121, 28);
            this.rs232_comboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название базы данных (лат.)";
            // 
            // dataBaseName_textBox
            // 
            this.dataBaseName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBaseName_textBox.Location = new System.Drawing.Point(288, 71);
            this.dataBaseName_textBox.Name = "dataBaseName_textBox";
            this.dataBaseName_textBox.Size = new System.Drawing.Size(460, 26);
            this.dataBaseName_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Макс. вес для страбатывания";
            // 
            // activationMaxWeight_textBox
            // 
            this.activationMaxWeight_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activationMaxWeight_textBox.Location = new System.Drawing.Point(305, 150);
            this.activationMaxWeight_textBox.Name = "activationMaxWeight_textBox";
            this.activationMaxWeight_textBox.Size = new System.Drawing.Size(102, 26);
            this.activationMaxWeight_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Интрервал записи данных в мил.сек.";
            // 
            // writingBeginInterval_textBox
            // 
            this.writingBeginInterval_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writingBeginInterval_textBox.Location = new System.Drawing.Point(363, 191);
            this.writingBeginInterval_textBox.Name = "writingBeginInterval_textBox";
            this.writingBeginInterval_textBox.Size = new System.Drawing.Size(128, 26);
            this.writingBeginInterval_textBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(550, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить настройки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rs485_comboBox
            // 
            this.rs485_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rs485_comboBox.FormattingEnabled = true;
            this.rs485_comboBox.Location = new System.Drawing.Point(420, 28);
            this.rs485_comboBox.Name = "rs485_comboBox";
            this.rs485_comboBox.Size = new System.Drawing.Size(121, 28);
            this.rs485_comboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(299, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "RS-485 Port";
            // 
            // iniFileReading_button
            // 
            this.iniFileReading_button.Location = new System.Drawing.Point(550, 276);
            this.iniFileReading_button.Name = "iniFileReading_button";
            this.iniFileReading_button.Size = new System.Drawing.Size(198, 35);
            this.iniFileReading_button.TabIndex = 12;
            this.iniFileReading_button.Text = "button1";
            this.iniFileReading_button.UseVisualStyleBackColor = true;
            this.iniFileReading_button.Click += new System.EventHandler(this.iniFileReading_button_Click);
            // 
            // cameraUrl_textBox
            // 
            this.cameraUrl_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cameraUrl_textBox.Location = new System.Drawing.Point(144, 113);
            this.cameraUrl_textBox.Name = "cameraUrl_textBox";
            this.cameraUrl_textBox.Size = new System.Drawing.Size(604, 26);
            this.cameraUrl_textBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "URL камеры";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 381);
            this.Controls.Add(this.cameraUrl_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iniFileReading_button);
            this.Controls.Add(this.rs485_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.writingBeginInterval_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activationMaxWeight_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataBaseName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rs232_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rs232_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataBaseName_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox activationMaxWeight_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox writingBeginInterval_textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox rs485_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button iniFileReading_button;
        private System.Windows.Forms.TextBox cameraUrl_textBox;
        private System.Windows.Forms.Label label6;
    }
}