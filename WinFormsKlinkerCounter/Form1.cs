// WinFormsKlinkerCounter
// Version: 3.0
// Author:Sam
// Description: klinker shipment counting software
// Database: MS Sql Server 2014
// Required equipment: Hikvision Ip-camera, OWEN PR-102 programmable reley
// Connection interface: RS-485, RS-232, HTTP

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;
using IniParser;
using IniParser.Model;
using System.Xml.Linq;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace WinFormsKlinkerCounter
{
    public delegate void News();
    
    public partial class Form1 : Form
    {
        string ssuz;
        private bool isWriting = false;
        private decimal oldWeight;
        static public bool EN;
        static public bool ENport;       
        event News alwaysUpdate;
        string com;
        event News httpClientUpdate;
        event News weightIndicatorUpdate;
        ModbusClient modbusClient;
        SerialPort port;
        bool start = false;     
        bool canWriteData = true;
        int lastMaxID = 0;
        //volatile int count = 0;
        String[] str = new String[2];
        string microsimData;
        Double microsimDoubleData;
        string stabRegisters; // stabilization register
        private bool isQrCodeRecognized = false;
        public DateTime date;

        
        /*int COUNT = 5000;  
        Double maxWeight = 4.0;
        Double minWeight = 1.0;
        string comPort = "COM11";
        string modbusPort = "COM10";
        string cameraUrl = "http://172.16.29.4/ISAPI/Streaming/channels/101/picture";
        //***********************ВКЛЮЧИТЬ OnCmd()
        public string connectionString = "Server=Nazarov-S\\SQLEXPRESS;Database=klinkerDataBase;Integrated Security=SSPI;";*/


        int COUNT = 70000;      
        Double maxWeight = 35.0;
        Double minWeight = 3.0;
        string comPort = "COM7";
        string modbusPort = "COM8";
        string cameraUrl = "http://172.16.29.5/ISAPI/Streaming/channels/101/picture";
        public string connectionString = "Server=TAROZI-KLINKER;Database=klinkerDataBase;Integrated Security=SSPI;";

        //Многопоточность
        Thread thread1;
        //Thread thread2;
        //Thread thread3;
        //Thread thread4;

        string weightIndicatorTest;
        string bruttoTest;

        public Form1()
        {
            //iniFileReading();
            InitializeComponent(); // Initialize the form components first
            //port = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
            //port.Open();
            //StartProcessing();
            //CreateTimersAndLaunch();

            myTimer.Tick += myTimer_Tick;
            myTimer.Interval = 50;
            qrCodeTextBoxDoNull_timer.Tick += qrCodeTextBoxDoNull_timer_Tick;
            qrCodeTextBoxDoNull_timer.Interval = 15000;

            thread1 = new Thread(()=> 
            {
                port = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                while (true)
                {
                    try
                    {
                        if (!port.IsOpen)
                        {
                            port.Open();
                        }
                        Reading();
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabel1.Text = $"An error occurred Com7: {ex.Message}";
                        if (port.IsOpen) { port.Close(); }
                    }
                    if (port.IsOpen)
                    {
                        Invoke((Action)(()=>
                        {
                            serialPort_label.Text = "порт открыт";
                        }));
                        
                    }
                    else if (!port.IsOpen)
                    {
                        Invoke((Action)(() =>
                        {
                            serialPort_label.Text = "порт закрыт";
                        }));                        
                    }
                    else
                    {
                        Invoke((Action)(() =>
                        {
                            serialPort_label.Text = "что-то!";
                        }));
                    }
                    Thread.Sleep(1000);
                }
            });

            /*thread2 =new Thread(()=> {
                while (true)
                {                    
                    Invoke((Action)(() => {
                        conditionsChecking();
                    }));                 
                    //Thread.Sleep(100);
                }
            });

            thread3 = new Thread(async () => {
                while (true)
                {                  
                    Invoke((Action)(() =>
                    {
                        HttpClientUsing();
                    }));                    
                    Thread.Sleep(100);
                }
            });

            thread4 = new Thread(() => {
                while (true)
                {                  
                    Invoke((Action)(() =>
                    {
                        updateDataGridFromDataBase();
                    }));                   
                    Thread.Sleep(1000);
                }
            });*/

            /*Task.Run(async () => {
                while (true)
                {
                    Invoke((Action)(() => {
                        HttpClientUsing();
                    }));
                    //
                    await Task.Delay(200);
                }
            });*/
         
            //alwaysUpdate += new News(this.updateDataGridFromDataBase);
            //httpClientUpdate += new News(this.HttpClientUsing);
            //weightIndicatorUpdate += new News(this.getDataFromWeightIndicator);

        }

        private void qrCodeTextBoxDoNull_timer_Tick(object sender, EventArgs e)
        {
            if (weightIndicator_label.Text=="0,00"|| weightIndicator_label.Text == "0,05")
            {
                Invoke((Action)(() => qrCodeText_textBox.Text = "Не определен!"));
            }
            
        }

        private async void запуститьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (EN = true)
            { 
                myTimer.Start();                
                thread1.Start();
                thread1.IsBackground = true;
                qrCodeTextBoxDoNull_timer.Start();
                //thread2.Start();
                //thread2.IsBackground = true;
                //thread3.Start();
                //thread3.IsBackground = true;
                //thread4.Start();
                //thread4.IsBackground = true;
            } 
            else
            { 
                myTimer.Stop();                
                thread1.Abort();
                //thread2.Abort();
            }
        }
       
        private async  void myTimer_Tick(object sender, EventArgs e)
        {
            //if (alwaysUpdate != null)
            //alwaysUpdate();
            //if (httpClientUpdate != null)
            //httpClientUpdate();
            //if (weightIndicatorUpdate != null)
            //weightIndicatorUpdate();
            try
            {
                HttpClientUsing();               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Проблема с камерой");
            }
            try
            {
               updateDataGridFromDataBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с базой данных");
            }
            try
            {               
                conditionsChecking();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Проблема с сопоставлением");
                return;
            }
        }

        private void conditionsChecking()
        {
            try
            {                
                brutto_textBox.Text = weightIndicatorTest;
                weightIndicator_label.Text = bruttoTest;
                if (string.IsNullOrEmpty(weightIndicatorTest))
                {
                    brutto_textBox.Text = " ";
                    weightIndicator_label.Text = " ";
                }
                if (stabRegisters==" ")
                {
                    StabIndicator_panel.BackColor = Color.Green;
                }
                else
                {
                    StabIndicator_panel.BackColor = Color.Red;
                }
                if (stabRegisters == " " && microsimData.Equals("0,00"))
                {
                    NullIndicator_panel.BackColor = Color.Green;
                }
                else 
                {
                    NullIndicator_panel.BackColor = Color.Red;
                }
               
                //if (stabRegisters.Equals(" ") && microsimDoubleData >= maxWeight&& qrCodeText_textBox.Text!= "Не определен!")
                if (stabRegisters.Equals(" ") && microsimDoubleData >= maxWeight)
                    {
                    try
                    {                        
                        if (canWriteData)
                        {
                           /* if (qrCodeText_textBox.Text == "Не определен!")
                            {
                                Thread.Sleep(5000);
                                MessageBox.Show("hhhhhhhhhhhhhh");
                            }*/
                            date = DateTime.Now;
                            SaveImageToFile(date);
                            Thread.Sleep(100);
                            writeDataToDatabase(date);
                            try
                            {
                                OnCmd(); //turn on traffic light
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabel1.Text = $"An error occurred0: {ex.Message}";
                            }
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = $"Dont saved!";
                        }
                    }
                    catch (Exception ex){ MessageBox.Show($"{ex}"); }
                }
                Invoke((Action)(() => {
                    sensor_label.Text = microsimDoubleData.ToString();
                    oldWeight_label.Text = (0.2*(double)oldWeight).ToString();
                    }));
                if (0.2 * (double)oldWeight >= microsimDoubleData&&oldWeight!=0)
                {
                    canWriteData = true;
                    oldWeight = 0;
                    Invoke((Action)(() => qrCodeText_textBox.Text = "Не определен!"));
                    //writeDataTimer.Stop();    
                }
            }
            catch (Exception ex)
            {
                modbusClient.Disconnect();
                toolStripStatusLabel1.Text = $"An error occurred1: {ex.Message}";
                return;
            }
            //Thread.Sleep(100);
        }
   
        private void Reading() 
        {
            try
            {
                ssuz = port.ReadLine();              
                if (isWriting)
                {
                    port.WriteLine("B");
                    isWriting = false;
                    toolStripStatusLabel1.Text = "Tara tarozi";
                }
                if (!string.IsNullOrEmpty(ssuz) && ssuz.Length == 14)
                {
                    microsimData = ssuz.Substring(2, 7).Trim().Replace(".", ",");
                    stabRegisters = ssuz.Substring(9, 1);                    
                }
                Double.TryParse(microsimData, out microsimDoubleData);
                Invoke((Action)(() =>
                    {                        
                        weightIndicatorTest = microsimData;
                        bruttoTest = microsimData.Replace("-", "");
                    }));
                port.DiscardInBuffer();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"An error occurred3: {ex.Message}";
                if (port.IsOpen)
                {
                    port.DiscardInBuffer();
                    port.Close();
                }                
            }
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            SaveImageToFile(date);
            writeDataToDatabase(date);
            MessageBox.Show("Test completed!");
        }

        private async Task HttpClientUsing()
        // getting image from ip-camera
        {
            try
            {
                string username = "admin";
                string password = "qwertyu12345";
                if (!string.IsNullOrEmpty(cameraUrl))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var byteArray = new System.Text.ASCIIEncoding().GetBytes($"{username}:{password}");
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                        HttpResponseMessage response = await client.GetAsync(cameraUrl);
                        //response.EnsureSuccessStatusCode();

                        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                        using (MemoryStream memstream = new MemoryStream(imageBytes))
                        {
                            Bitmap img = new Bitmap(memstream);
                            try
                            {
                                Invoke((Action)(() =>
                                {
                                    qrCode_pictureBox.Image = img;
                                    qrCode_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                }));
                                IBarcodeReader reader = new BarcodeReader();
                                var result = reader.Decode(img);
                                string lastChar = result.Text.Substring(result.Text.Length - 1);//**********
                                if (result != null && lastChar == "A" || lastChar == "B")//**********
                                //if (result != null)
                                {
                                    Invoke((Action)(() => 
                                    {                                        
                                        qrCodeText_textBox.Text = result.Text; 
                                    }));
                                }
                                await Task.Delay(200);
                            }
                            catch
                            {
                                //Invoke((Action)(() => qrCodeText_textBox.Text = "2Не определен!"));
                                return;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Invoke((Action)(() => toolStripStatusLabel1.Text = $"An error occurred4: {ex.Message}"));
                return;
            }
            Task.Delay(20);
            
        }

        private void qrCodeText_textBox_TextChanged(object sender, EventArgs e)
        {
            checkLicencePlateFromDataBase(qrCodeText_textBox.Text);
            string lastChar = qrCodeText_textBox.Text.Substring(qrCodeText_textBox.Text.Length - 1);
            if (lastChar == "A")
            {
                destination_textBox.Text = "силос-склад";
            }
            else if(lastChar == "B")
            {
                destination_textBox.Text = "склад-силос";
            }
            else
            {
                destination_textBox.Text = "";
            }
        } 

        private void brutto_textBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                netto_textBox.Text = (Convert.ToDecimal(brutto_textBox.Text) - Convert.ToDecimal(tara_textBox.Text)).ToString();
            }            
            catch
            {
                netto_textBox.Text = "0,00";
            }
        }

        /// <summary>//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// FINISHED METHODS
        /// </summary>

        private void запуститьToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            EN = запуститьToolStripMenuItem.Checked;
            if (EN) { запуститьToolStripMenuItem.Text = "Остановить"; } else { запуститьToolStripMenuItem.Text = "Запустить"; }
        }

        async public void OnCmd()
        {
            modbusClient = new ModbusClient(modbusPort);
            //turn on traffic light
            modbusClient.Baudrate = 9600;
            modbusClient.Parity = System.IO.Ports.Parity.None;
            modbusClient.StopBits = System.IO.Ports.StopBits.One;
            modbusClient.UnitIdentifier = 16; 
            try 
            {
                modbusClient.Connect();
                modbusClient.WriteSingleRegister(512, 1);
                //modbusClient.WriteSingleRegister(512, 0);
                modbusClient.Disconnect();
            }
            catch (Exception ex) 
            {
                toolStripStatusLabel1.Text = $"ModbusPort OnCmd not worked!: {ex.Message}";
                return;
            }
                                  
 
            await Task.Delay(100);
        }

        private void ReadModbusRegisters()
        {
            try
            {
                modbusClient = new ModbusClient(modbusPort);
                modbusClient.Baudrate = 9600;
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.UnitIdentifier = 16;
                modbusClient.Connect();

                while (true)
                {
                    int[] readValues = modbusClient.ReadHoldingRegisters(513, 1);
                    if (readValues.Length > 0)
                    {
                        int value = readValues[0];
                        Invoke((Action)(() =>
                        {
                            sensor_label.Text = value.ToString();
                        }));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Invoke((Action)(() =>
                {
                    toolStripStatusLabel1.Text = ($"An error occurred5: {ex.Message}");
                }));
            }
            finally
            {
                // Отключение от Modbus сервера
                modbusClient.Disconnect();
            }

        }

        private async Task updateDataGridFromDataBase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = @"SELECT MAX(ID) FROM klinkerTable1";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    object result = checkCommand.ExecuteScalar();
                    if (result != DBNull.Value && Convert.ToInt32(result) > lastMaxID)
                    {
                        lastMaxID = Convert.ToInt32(result);

                        string query = @"SELECT TOP 100 ID, date, licencePlate, tara, netto, brutto, destination
                                     FROM klinkerTable1
                                     ORDER BY ID DESC";

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        licencePlate_dataGridView.DataSource = dataTable;
                        licencePlate_dataGridView.Columns["dddd"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                        licencePlate_dataGridView.Columns["ID"].DataPropertyName = "ID";
                        licencePlate_dataGridView.Columns["dddd"].DataPropertyName = "date";
                        licencePlate_dataGridView.Columns["plateNumber"].DataPropertyName = "licencePlate";
                        licencePlate_dataGridView.Columns["tara"].DataPropertyName = "tara";
                        licencePlate_dataGridView.Columns["netto"].DataPropertyName = "netto";
                        licencePlate_dataGridView.Columns["brutto"].DataPropertyName = "brutto";
                        licencePlate_dataGridView.Columns["destination"].DataPropertyName = "destination";
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ($"An error occurred6: {ex.Message}");
                //MessageBox.Show($"An error occurred: {ex.Message}");
                return;
            }
            await Task.Delay(100);
        }

        private async void SaveImageToFile(DateTime date)
        {
            string username = "admin";
            string password = "qwertyu12345";

            try
            {
                if (!string.IsNullOrEmpty(cameraUrl))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var byteArray = new System.Text.ASCIIEncoding().GetBytes($"{username}:{password}");
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                        int maxRetries = 3;
                        int delay = 2000; // Delay in milliseconds

                        for (int i = 0; i < maxRetries; i++)
                        {
                            HttpResponseMessage response = await client.GetAsync(cameraUrl);

                            if (response.IsSuccessStatusCode)
                            {
                                byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                                using (MemoryStream memstream = new MemoryStream(imageBytes))
                                {
                                    Bitmap img = new Bitmap(memstream);
                                    try
                                    {
                                        string directoryPath = @"D:\images";
                                        if (!Directory.Exists(directoryPath))
                                        {
                                            Directory.CreateDirectory(directoryPath);
                                        }

                                        //string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
                                        string fileName = date.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
                                        string filePath = Path.Combine(directoryPath, fileName);
                                        img.Save(filePath, ImageFormat.Jpeg);

                                        infoLabel.Text = "Image saved!";
                                        //toolStripStatusLabel1.Text = "Image successfully saved!";
                                        return;
                                    }
                                    catch (Exception ex)
                                    {
                                        infoLabel.Text = "Error saving image!";
                                        toolStripStatusLabel1.Text = $"An error occurred while saving image: {ex.Message}";
                                        return;
                                    }
                                }
                            }
                            else if (response.StatusCode == HttpStatusCode.ServiceUnavailable)
                            {
                                await Task.Delay(delay); // Wait before retrying
                            }
                            else
                            {
                                infoLabel.Text = "retrieve image!";
                                toolStripStatusLabel1.Text = $"Error retrieving image: {response.StatusCode}";
                                return;
                            }
                        }
                        infoLabel.Text = "after multiple attempts!";
                        toolStripStatusLabel1.Text = "Image retrieval failed after multiple attempts!";
                    }
                }
            }
            catch (Exception ex)
            {
                infoLabel.Text = "Not saved!";
                toolStripStatusLabel1.Text = $"An error occurred7: {ex.Message}";
            }
        }

        private async void SaveImageToFile1()
        {
            try
            {

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
                                string directoryPath = @"D:\images";
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
                                string filePath = Path.Combine(directoryPath, fileName);
                                img.Save(filePath, ImageFormat.Jpeg);
                                infoLabel.Text = "Image saved!";
                            }
                            catch
                            {
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                infoLabel.Text = "Not saved!";
                toolStripStatusLabel1.Text = $"An error occurred8: {ex.Message}";
                return;
            }
        }

        private void checkLicencePlateFromDataBase(string licencePlate)
        {
            string licencePlateToSearch = licencePlate;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT tara FROM licencePlateList1 WHERE licencePlate = @licencePlate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@licencePlate", licencePlateToSearch);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tara_textBox.Text = reader[0].ToString();
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
                toolStripStatusLabel1.Text = $"An error occurred9: {ex.Message}";
                return;
            }
        }

        private void writeDataToDatabase(DateTime date)
        {
            //DateTime date = DateTime.Now;
            string photoName = date.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
            decimal taraNum;
            decimal nettoNum;
            decimal bruttoNum;
            try
            {
                if (!decimal.TryParse(tara_textBox.Text, out taraNum))
                {
                    taraNum = 0.00m;
                }
                if (!decimal.TryParse(brutto_textBox.Text, out bruttoNum))
                {
                    bruttoNum = 0.00m;
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"An error occurred10: {ex.Message}";
                return;
            }
            var rows = new List<object[]>
                {
                    new object[] {date, $"{qrCodeText_textBox.Text}", taraNum, bruttoNum, destination_textBox.Text, photoName},
                };

            foreach (var row in rows)
            {
                //saveToDataBase(date, qrCodeText_textBox.Text, taraNum, nettoNum, bruttoNum, destination_textBox.Text, photoName);
                saveToDataBase(date, qrCodeText_textBox.Text, taraNum, bruttoNum, destination_textBox.Text, photoName);
            }
        }

        private void saveToDataBase(DateTime date, string licencePlate, decimal tara,  decimal brutto, string destination, string photo)
        {
            decimal nettoValue=brutto-tara;
            oldWeight = brutto;
            canWriteData = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO klinkerTable1 (date, licencePlate, tara, netto, brutto, destination,photo) " +
                                   "VALUES ( @Date, @LicencePlate, @Tara, @Netto, @Brutto, @Destination, @fileName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@LicencePlate", licencePlate);
                        command.Parameters.AddWithValue("@Tara", tara);
                        command.Parameters.AddWithValue("@Netto", nettoValue);
                        command.Parameters.AddWithValue("@Brutto", brutto);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@fileName", photo);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            //MessageBox.Show("Data inserted successfully.");
                            return;
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "No rows inserted.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"An error occurred11: {ex.Message}";
                return;
            }
        }

        /// <summary>//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// NOT CRITICAL METHODS
        /// </summary>
        private void записьНастроекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.Show();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void checkConnectionWithDataBase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Соединение с базой данных успешно установлено.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Не удалось установить соединение с базой данных.");
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }

        }

        async public void OffCmd()//*************
        {
            modbusClient = new ModbusClient(modbusPort);
            modbusClient.Baudrate = 9600;
            modbusClient.Parity = System.IO.Ports.Parity.None;
            modbusClient.StopBits = System.IO.Ports.StopBits.One;
            modbusClient.UnitIdentifier = 16;

            modbusClient.Connect();
            modbusClient.WriteSingleRegister(512, 0);
            modbusClient.Disconnect();
            await Task.Delay(100);
        }

        private void Form1_Load(object sender, EventArgs e)///////////////
        {
            qrCodeText_textBox.Text = "Не определен!";
            //NULL_button.Visible = false;
            //button1.Visible = false;
            test_button.Visible = false;
            //modbusOn_button.Visible = false;
            //this.NULL_button.Click += new System.EventHandler(this.buttonSendData_Click);

        }

        private void iniFileReading()
        {
            string configFilePath = "config.ini";
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(configFilePath);

                comPort = data["SETTINGS"]["rs232Port"];
                modbusPort = data["SETTINGS"]["rs485Port"];
                connectionString = data["SETTINGS"]["DatabaseName"];
                //maxWeight = Convert.ToDouble(data["SETTINGS"]["ActivationMaxWeight"]);
                COUNT = Convert.ToInt32(data["SETTINGS"]["WritingBeginInterval"]);
                cameraUrl = data["SETTINGS"]["cameraUrl"];

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void licencePlate_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(licencePlate_dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                OpenPhotoById(selectedId);
            }
        }

        private void OpenPhotoById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT photo FROM klinkerTable1 WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string photoFileName = result.ToString();
                        string photoFilePath = Path.Combine(@"D:\images", photoFileName); // Замените на ваш путь к директории с фото

                        if (File.Exists(photoFilePath))
                        {
                            System.Diagnostics.Process.Start(new ProcessStartInfo
                            {
                                FileName = photoFilePath,
                                UseShellExecute = true
                            });
                        }
                        else
                        {
                            MessageBox.Show("Файл не найден: " + photoFilePath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Фото не найдено для данного ID.");
                    }
                }
            }
        }

        private void NULL_button_Click(object sender, EventArgs e)
        {
            isWriting = true;
        }       
    }
}
