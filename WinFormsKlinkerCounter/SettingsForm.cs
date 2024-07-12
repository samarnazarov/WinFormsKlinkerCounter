using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;



namespace WinFormsKlinkerCounter
{
    public partial class SettingsForm : Form
    {
        
        private string configFilePath = "config.ini";
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void LoadAvailablePorts()
        {            
            string[] ports = SerialPort.GetPortNames();            
            rs232_comboBox.Items.Clear();
            rs485_comboBox.Items.Clear();
            
            foreach (string port in ports)
            {
                rs232_comboBox.Items.Add(port);
                rs485_comboBox.Items.Add(port);
            }

            if (rs232_comboBox.Items.Count > 0)
            {
                rs232_comboBox.SelectedIndex = 0;
                rs485_comboBox.SelectedIndex = 0;
            }
        }

        private void SaveSettingsToConfig()
        {
            string configFilePath = "config.ini";
            try
            {
                using (StreamWriter writer = new StreamWriter(configFilePath))
                {
                    writer.WriteLine($"[SETTINGS]");
                    writer.WriteLine($"rs232Port = {rs232_comboBox.Text}");
                    writer.WriteLine($"rs485Port = {rs485_comboBox.Text}");
                    writer.WriteLine($"DatabaseName = {dataBaseName_textBox.Text};Database=klinkerDataBase;Integrated Security=SSPI;");
                    writer.WriteLine($"cameraUrl = {cameraUrl_textBox.Text}");
                    writer.WriteLine($"ActivationMaxWeight = {activationMaxWeight_textBox.Text}");
                    writer.WriteLine($"WritingBeginInterval = {writingBeginInterval_textBox.Text}");
                   
                }

                MessageBox.Show("Настройки сохранены в файл config.ini");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении настроек: {ex.Message}");
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadAvailablePorts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveSettingsToConfig();
        }

        private void iniFileReading()
        {
            string configFilePath = "config.ini";
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(configFilePath);

                /*string iniSerialPort = data["SETTINGS"]["rs232Port"];
                string iniModbusPort = data["SETTINGS"]["rs485Port"];
                string iniDatabase = data["SETTINGS"]["DatabaseName"];
                string iniMaxWeight = data["SETTINGS"]["ActivationMaxWeight"];
                string iniInterval = data["SETTINGS"]["WritingBeginInterval"];
                string iniCameraUrl = data["SETTINGS"]["cameraUrl"];*/

                string comPort = data["SETTINGS"]["rs232Port"];
                /*modbusPort = data["SETTINGS"]["rs485Port"];
                connectionString = data["SETTINGS"]["DatabaseName"];
                maxWeight = Convert.ToDouble(data["SETTINGS"]["ActivationMaxWeight"]);
                COUNT = Convert.ToInt32(data["SETTINGS"]["WritingBeginInterval"]);*/
                string cameraUrl = data["SETTINGS"]["cameraUrl"];

                MessageBox.Show($"{(data["SETTINGS"]["rs232Port"]).GetType()}");

                /*comPort = $"{iniSerialPort}";
                modbusPort = $"{iniModbusPort}";
                connectionString = $"{iniDatabase}";
                maxWeight = Convert.ToDouble(iniMaxWeight);
                COUNT = Convert.ToInt32(iniInterval);
                cameraUrl = $"{iniCameraUrl}";*/

                /*comPort = "COM11";
                modbusPort = "COM11";
                connectionString = "Server=Nazarov-S\\SQLEXPRESS;Database=klinkerDataBase;Integrated Security=SSPI;";
                maxWeight = 6.0;
                COUNT = 90000;
                cameraUrl = "http://172.16.29.4/ISAPI/Streaming/channels/101/picture";*/

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading serial port configuration: {ex.Message}");
            }
        }

        private void iniFileReading_button_Click(object sender, EventArgs e)
        {
            iniFileReading();
        }
    }
}
