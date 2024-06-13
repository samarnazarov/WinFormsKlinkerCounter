using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.IO.Ports;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Aztec;
using Modbus.Device;
using EasyModbus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static EasyModbus.ModbusServer;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace WinFormsKlinkerCounter
{
    public partial class Form1 : Form
    {

        int num = 0;
        ModbusClient modbusClient = new ModbusClient("COM11");

        public Form1()
        {
            InitializeComponent();
            myTimer.Tick += myTimer_Tick;
            myTimer.Interval = 1000;
            timer1.Tick += myTimer_Tick2;
            timer1.Interval = 1000;
        }        

        private void CaptureImage_button_Click(object sender, EventArgs e)
        {
            //HttpClientUsing();            
            
        }

        private async void HttpClientUsing()
            // getting image from ip-camera
        {
            try
            {
                string cameraUrl = "http://172.16.29.5/ISAPI/Streaming/channels/101/picture";
                string username = "admin";
                string password = "qwertyu12345";
                if (!string.IsNullOrEmpty(cameraUrl))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var byteArray = new System.Text.ASCIIEncoding().GetBytes($"{username}:{password}");
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                        HttpResponseMessage response = await client.GetAsync(cameraUrl);
                        response.EnsureSuccessStatusCode();

                        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                        using (MemoryStream memstream = new MemoryStream(imageBytes))
                        {
                            Bitmap img = new Bitmap(memstream);
                            try
                            {                                
                                qrCode_pictureBox.Image = img;
                                qrCode_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                IBarcodeReader reader = new BarcodeReader();
                                var result = reader.Decode(img);
                                if(result != null)
                                {
                                    qrCodeText_textBox.Text = result.Text;
                                }
                                else
                                {
                                    qrCodeText_textBox.Text = "Error!";
                                }                                                                                               
                            }
                            catch
                            {                               
                                qrCodeText_textBox.Text = "Error!";
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            HttpClientUsing();
        }

        private void modbusOn_button_Click(object sender, EventArgs e)
        // register turn on 
        {
            try
            {                
                modbusClient.Baudrate = 9600;
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.UnitIdentifier = 16;
                
                modbusClient.Connect();                                              
                modbusClient.WriteSingleRegister(1, 1);                
                modbusClient.Disconnect();                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }        
        }

        private void modbusOff_button_Click(object sender, EventArgs e)
        // register turn off 
        {
            try
            {                
                modbusClient.Baudrate = 9600;
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.UnitIdentifier = 16;

                modbusClient.Connect();
                modbusClient.WriteSingleRegister(1, 0);
                modbusClient.Disconnect();                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }       

        private void myTimer_Tick2(object sender, EventArgs e)
        {

            try
            {
                modbusClient.Baudrate = 9600;
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.UnitIdentifier = 1;

                modbusClient.Connect();
                int[] holdingRegister = modbusClient.ReadHoldingRegisters(3,2);
                string microsimData = (holdingRegister[1]).ToString();
                //string microsimData = string.Join(" ", holdingRegister);
                brutto_textBox.Text = microsimData;                
                modbusClient.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Start();
            timer1.Start();
        }

        private void writeToDataBase_button_Click(object sender, EventArgs e)
        
            
        {
            num = num + 1;
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string taraNum = tara_textBox.Text;
            string nettoNum = netto_textBox.Text;
            string destination = "силос-склад";

            var rows = new List<object[]>
        {
            new object[] { $"{num}", date, $"{qrCodeText_textBox.Text}", taraNum, nettoNum, $"{brutto_textBox.Text}", destination},
        };

            foreach (var row in rows)
            {
                licencePlate_dataGridView.Rows.Add(row);
                saveToDataBase(num,date,qrCodeText_textBox.Text,taraNum,nettoNum,brutto_textBox.Text,destination);

            }            
        }

        private void saveToDataBase(int id, string date, string licencePlate, string tara, string netto, string brutto, string destination)
        {
            // database type is MSSQL SERVER 2014

            string connectionString = "Server=NAZAROV-S\\SQLEXPRESS;Database=klinkerDataBase;Integrated Security=SSPI;";
            /*int id = 1;
            DateTime date = DateTime.Now;
            string licencePlate = "ABC123";
            double tara = 20.0;
            double netto = 100.0;
            double brutto = 120.0;
            string destination = "Warehouse 1";*/

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO klinkerTable (ID, date, licencePlate, tara, netto, brutto, destination) " +
                                   "VALUES (@ID, @Date, @LicencePlate, @Tara, @Netto, @Brutto, @Destination)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@LicencePlate", licencePlate);
                        command.Parameters.AddWithValue("@Tara", tara);
                        command.Parameters.AddWithValue("@Netto", netto);
                        command.Parameters.AddWithValue("@Brutto", brutto);
                        command.Parameters.AddWithValue("@Destination", destination);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            //MessageBox.Show("Data inserted successfully.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.");
                        }
                    }
                }
                //MessageBox.Show("DataSaved");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void checkLicencePlateFromDataBase(string licencePlate)
        {
            string connectionString = "Server=NAZAROV-S\\SQLEXPRESS;Database=klinkerDataBase;Integrated Security=SSPI;";

            string licencePlateToSearch = licencePlate;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT tara FROM licencePlateList WHERE licencePlate = @licencePlate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@licencePlate", licencePlateToSearch);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int taraValue = Convert.ToInt16((reader[0]));
                                //double tara = reader.GetDouble(0); // Assuming 'tara' is of type float in SQL Server
                                tara_textBox.Text=taraValue.ToString();
                                
                            }
                            else
                            {
                                tara_textBox.Text = "not found!";
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }       

        private void qrCodeText_textBox_TextChanged(object sender, EventArgs e)
        {
            checkLicencePlateFromDataBase(qrCodeText_textBox.Text);
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            return;
        }

        private void brutto_textBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                netto_textBox.Text = (Convert.ToInt16(brutto_textBox.Text) - Convert.ToInt16(tara_textBox.Text)).ToString();
            }
            
            catch
            {
                netto_textBox.Text = "0";
            }    
        }
    }
}
