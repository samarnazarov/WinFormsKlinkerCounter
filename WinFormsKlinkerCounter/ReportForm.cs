using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System;
using System.IO;



namespace WinFormsKlinkerCounter
{
    public partial class ReportForm : Form
    {
        Form1 form1 = new Form1();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDataGridFromDataBase();
            //MessageBox.Show(begin_dateTimePicker.Value.ToString());
        }

        private void firstUpdateDataGridFromDataBase()
        {
            Form1 form1 = new Form1();
            try
            {
                using (SqlConnection connection = new SqlConnection(form1.connectionString))
                {
                    connection.Open();

                    string query = @"SELECT ID, date, licencePlate, tara, netto, brutto, destination
                             FROM klinkerTable1
                             WHERE date BETWEEN @beginDate AND @endDate
                             ORDER BY ID DESC";
                    /*string query = @"SELECT ID, date, licencePlate, tara, netto, brutto, destination
                             FROM klinkerTable1
                             WHERE date BETWEEN @beginDate AND @endDate
                             AND (@licencePlate IS NULL OR licencePlate = @licencePlate)
                             AND (@destination IS NULL OR destination = @destination)
                             ORDER BY ID DESC";*/

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@beginDate", DateTime.Now.Date.AddDays(0));
                    command.Parameters.AddWithValue("@endDate", DateTime.Now.Date.AddDays(1).AddSeconds(-1)); 
                    //command.Parameters.AddWithValue("@beginDate", begin_dateTimePicker.Value);
                    //command.Parameters.AddWithValue("@endDate", end_dateTimePicker.Value.AddDays(1).AddSeconds(-1)); 
                    //command.Parameters.AddWithValue("@endDate", end_dateTimePicker.Value.ToShortDateString());
                    //command.Parameters.AddWithValue("@licencePlate", licencePlate_comboBox.SelectedItem == null ? DBNull.Value : (object)licencePlate_comboBox.SelectedItem);
                    //command.Parameters.AddWithValue("@destination", destination_comboBox.SelectedItem == null ? DBNull.Value : (object)destination_comboBox.SelectedItem);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    licencePlate_dataGridView.DataSource = dataTable;
                    licencePlate_dataGridView.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                    licencePlate_dataGridView.Columns["ID"].DataPropertyName = "ID";
                    licencePlate_dataGridView.Columns["Date"].DataPropertyName = "date";
                    licencePlate_dataGridView.Columns["plateNumber"].DataPropertyName = "licencePlate";
                    licencePlate_dataGridView.Columns["tara"].DataPropertyName = "tara";
                    licencePlate_dataGridView.Columns["netto"].DataPropertyName = "netto";
                    licencePlate_dataGridView.Columns["brutto"].DataPropertyName = "brutto";
                    licencePlate_dataGridView.Columns["destination"].DataPropertyName = "destination";

                    int rowCount = dataTable.Rows.Count;
                    decimal summaryNetto = 0;
                    decimal summaryBrutto = 0;
                    int rowIndex = 1;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        //licencePlate_dataGridView.Columns["ID"].DataPropertyName = rowIndex++;
                        if (row["netto"] != DBNull.Value)
                        {
                            summaryNetto += Convert.ToDecimal(row["netto"]);
                        }
                        if (row["brutto"] != DBNull.Value)
                        {
                            summaryBrutto += Convert.ToDecimal(row["brutto"]);
                        }
                    }
                    licencePlate_comboBox.Text = "Все";
                    destination_comboBox.Text = "Все";
                    begin_dateTimePicker.Value=DateTime.Now.Date.AddDays(0);
                    end_dateTimePicker.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
                    reys_label.Text = rowCount.ToString();
                    summaryNetto_label.Text = summaryNetto.ToString("N2");
                    summaryBrutto_label.Text = summaryBrutto.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return;
            }
        }

        private void updateDataGridFromDataBase()
        {
            Form1 form1 = new Form1();
            try
            {
                using (SqlConnection connection = new SqlConnection(form1.connectionString))
                {
                    connection.Open();
                    /*string query = @"SELECT ID, date, licencePlate, tara, netto, brutto, destination
                             FROM klinkerTable1
                             WHERE date BETWEEN @beginDate AND @endDate
                             ORDER BY ID DESC";*/
                    
                    string query = @"SELECT ID, date, licencePlate, tara, netto, brutto, destination
                    FROM klinkerTable1
                    WHERE date BETWEEN @beginDate AND @endDate
                    AND (@licencePlate IS NULL OR licencePlate = @licencePlate)
                    AND (@destination IS NULL OR destination = @destination)
                    ORDER BY ID DESC";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@beginDate", begin_dateTimePicker.Value);
                    command.Parameters.AddWithValue("@endDate", end_dateTimePicker.Value.AddDays(1).AddSeconds(-1));
                    if (licencePlate_comboBox.Text == "Все")
                    {
                        command.Parameters.AddWithValue("@licencePlate", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@licencePlate", string.IsNullOrEmpty(licencePlate_comboBox.Text) ? (object)DBNull.Value : licencePlate_comboBox.Text);
                    }

                    if (destination_comboBox.Text == "Все")
                    {
                        command.Parameters.AddWithValue("@destination", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@destination", string.IsNullOrEmpty(destination_comboBox.Text) ? (object)DBNull.Value : destination_comboBox.Text);
                    }
                    //command.Parameters.AddWithValue("@licencePlate", licencePlate_comboBox.SelectedValue == null ? DBNull.Value : (object)licencePlate_comboBox.SelectedValue);
                    //command.Parameters.AddWithValue("@destination", destination_comboBox.SelectedValue == null ? DBNull.Value : (object)destination_comboBox.SelectedValue);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    licencePlate_dataGridView.DataSource = dataTable;
                    licencePlate_dataGridView.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                    licencePlate_dataGridView.Columns["ID"].DataPropertyName = "ID";
                    licencePlate_dataGridView.Columns["Date"].DataPropertyName = "date";
                    licencePlate_dataGridView.Columns["plateNumber"].DataPropertyName = "licencePlate";
                    licencePlate_dataGridView.Columns["tara"].DataPropertyName = "tara";
                    licencePlate_dataGridView.Columns["netto"].DataPropertyName = "netto";
                    licencePlate_dataGridView.Columns["brutto"].DataPropertyName = "brutto";
                    licencePlate_dataGridView.Columns["destination"].DataPropertyName = "destination";

                    int rowCount = dataTable.Rows.Count;
                    decimal summaryNetto = 0;
                    decimal summaryBrutto = 0;
                    
                    foreach (DataRow row in dataTable.Rows)
                    {
                       
                        if (row["netto"] != DBNull.Value)
                        {
                            summaryNetto += Convert.ToDecimal(row["netto"]);
                        }
                        if (row["brutto"] != DBNull.Value)
                        {
                            summaryBrutto += Convert.ToDecimal(row["brutto"]);
                        }
                    }

                    reys_label.Text = rowCount.ToString();
                    summaryNetto_label.Text = summaryNetto.ToString("N2");  
                    summaryBrutto_label.Text = summaryBrutto.ToString("N2"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return;
            }
        }

        private void setValuesLicencePlateComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(form1.connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT licencePlate FROM klinkerTable1 ORDER BY licencePlate";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    licencePlate_comboBox.DataSource = dataTable;
                    licencePlate_comboBox.DisplayMember = "licencePlate";
                    licencePlate_comboBox.ValueMember = "licencePlate";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void setValuesDestinationComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(form1.connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT destination FROM klinkerTable1 ORDER BY destination";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    destination_comboBox.DataSource = dataTable;
                    destination_comboBox.DisplayMember = "destination";
                    destination_comboBox.ValueMember = "destination";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            setValuesLicencePlateComboBox();
            setValuesDestinationComboBox();
            firstUpdateDataGridFromDataBase();
        }

        private void excelExport_button_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "klinker "+date.ToString("yyyy-MM-dd_HH-mm-ss") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToExcel(licencePlate_dataGridView, saveFileDialog.FileName);
            }
        }

        private void ExportDataGridViewToExcel(DataGridView dgv, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Add column headers
                worksheet.Cells[1,1].Value = dgv.Columns[0].HeaderText;
                worksheet.Cells[1, 2].Value = dgv.Columns[1].HeaderText;
                worksheet.Cells[1, 3].Value = dgv.Columns[2].HeaderText;
                worksheet.Cells[1, 4].Value = dgv.Columns[3].HeaderText;
                worksheet.Cells[1, 5].Value = dgv.Columns[4].HeaderText;
                worksheet.Cells[1, 6].Value = dgv.Columns[5].HeaderText;
                worksheet.Cells[1, 7].Value = dgv.Columns[6].HeaderText;

                // Add row data
                for (int row = 0; row < dgv.Rows.Count; row++)              
                {
                    worksheet.Cells[row + 2,1].Value = dgv.Rows[row].Cells[0].Value;
                    //worksheet.Cells[row + 2, 2].Value = (dgv.Rows[row].Cells[1].Value);
                    worksheet.Cells[row + 2, 3].Value = dgv.Rows[row].Cells[2].Value;
                    worksheet.Cells[row + 2, 4].Value = dgv.Rows[row].Cells[3].Value;
                    worksheet.Cells[row + 2, 5].Value = dgv.Rows[row].Cells[4].Value;
                    worksheet.Cells[row + 2, 6].Value = dgv.Rows[row].Cells[5].Value;
                    worksheet.Cells[row + 2, 7].Value = dgv.Rows[row].Cells[6].Value;

                    var cellValue = dgv.Rows[row].Cells[1].Value;

                    if (cellValue is DateTime dateTimeValue)
                    {
                        worksheet.Cells[row + 2, 2].Value = dateTimeValue.ToString("yyyy.MM.dd HH:mm:ss");
                    }
                    else
                    {
                        worksheet.Cells[row + 2, 2].Value = cellValue;
                    }
                }

                // Save the Excel file
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }

            MessageBox.Show("Data successfully exported to Excel file.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Form1 form1 = new Form1();
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(form1.connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    licencePlate, 
                    COUNT(*) AS reysCount, 
                    SUM(netto) AS totalNetto, 
                    SUM(brutto) AS totalBrutto
                FROM 
                    klinkerTable1 
                WHERE 
                    date BETWEEN @beginDate AND @endDate 
                GROUP BY 
                    licencePlate
                UNION ALL
                SELECT 
                    'Всего', 
                    COUNT(*) AS reysCount, 
                    SUM(netto) AS totalNetto, 
                    SUM(brutto) AS totalBrutto
                FROM 
                    klinkerTable1 
                WHERE 
                    date BETWEEN @beginDate AND @endDate;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@beginDate", begin_dateTimePicker.Value);
                    command.Parameters.AddWithValue("@endDate", end_dateTimePicker.Value.AddDays(1).AddSeconds(-1));

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return;
            }

            Font font = new Font("Times New Roman", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            e.Graphics.DrawString("ОТЧЕТ ПО ПЕРЕВОЗКЕ КЛИНКЕРА АВТОТРАНСПОРТОМ", font, brush, new PointF(200, 50));
            e.Graphics.DrawString($"с {begin_dateTimePicker.Text} по {end_dateTimePicker.Text}", font, brush, new PointF(300, 70));
            e.Graphics.DrawString("Гаражный                          Кол-во                        Нетто                              Брутто", font, brush, new PointF(110, 120));
            e.Graphics.DrawString("номер                                 рейсов                                                 ", font, brush, new PointF(110, 140));
            e.Graphics.DrawString("___________________________________________________________________________", font, brush, new PointF(100, 150));
            e.Graphics.DrawString("", font, brush, new PointF(110, 180));
            int poinY = 210; // Начальная точка Y для строк данных
            foreach (DataRow row in dataTable.Rows)
            {
                string licencePlate = row["licencePlate"].ToString();
                string reysCount = row["reysCount"].ToString();
                string totalNetto = row["totalNetto"].ToString();
                string totalBrutto = row["totalBrutto"].ToString();

                if (licencePlate.Length == 3)
                {
                    licencePlate = "0" + licencePlate;
                }
                if (reysCount.Length == 1)
                {
                    reysCount = "0" + reysCount;
                }
                if (licencePlate.Equals("Не определен!"))
                {
                    e.Graphics.DrawString($"{licencePlate}                      {reysCount}                                {totalNetto}                                   {totalBrutto}", font, brush, new PointF(110, poinY));
                    poinY += 30;
                }
                else if (licencePlate.Equals("Всего"))
                {
                    e.Graphics.DrawString("", font, brush, new PointF(110, poinY));
                    poinY += 30;
                    e.Graphics.DrawString("___________________________________________________________________________", font, brush, new PointF(100, poinY));
                    poinY += 30;
                    e.Graphics.DrawString($"{licencePlate}                                      {reysCount}                                {totalNetto}                                   {totalBrutto}", font, brush, new PointF(110, poinY));
                    poinY += 30;
                }
                else
                {
                    e.Graphics.DrawString($"{licencePlate}                                       {reysCount}                                {totalNetto}                                   {totalBrutto}", font, brush, new PointF(110, poinY));
                    poinY += 30;
                }
            }
            e.Graphics.DrawString("                          Мастер смены  ____________", font, brush, new PointF(110, 1050));
        }


        private void print_button_Click(object sender, EventArgs e)
        {
            //ReportPreviewForm form1= new ReportPreviewForm();
            //form1.Show();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK);
        }

        
    }
}
