using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TrainingPractice_03
{
    enum RowState3
    {
        ModifiedNew,
        Existed,
        Deleted,
        Modified
    }
    public partial class Remains : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Remains()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_remain", "Код вида");
            dataGridView1.Columns.Add("type_id", "Название");
            dataGridView1.Columns.Add("dateOfDay", "Установленная цена");
            dataGridView1.Columns.Add("dayStartVolume", "Код поставщика");
            dataGridView1.Columns.Add("salesVolume", "Код поставщика");
            dataGridView1.Columns.Add("isNew", String.Empty);
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 120;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 150;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 150;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 150;
        }

        private void Remains_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT TypesOfFuel.id_type, TypesOfFuel.title_of_type, TypesOfFuel.price_fuel, Remains.id_remain, Remains.type_id, Remains.dateOfDay, Remains.dayStartVolume, Remains.salesVolume FROM TypesOfFuel INNER JOIN dbo.Remains ON dbo.TypesOfFuel.id_type = dbo.Remains.type_id",
                dataBase.GetConnection());
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Код вида топлива";
            dataGridView1.Columns[1].HeaderText = "Название топлива";
            dataGridView1.Columns[2].HeaderText = "Цена топлива";
            dataGridView1.Columns[3].HeaderText = "Код учёта";
            dataGridView1.Columns[4].HeaderText = "Код вида топлива (проверка)";
            dataGridView1.Columns[5].HeaderText = "Дата";
            dataGridView1.Columns[6].HeaderText = "Объём на начало дня (л)";
            dataGridView1.Columns[7].HeaderText = "Объём продажи (л)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            exApp.Columns.ColumnWidth = 30;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            exApp.Cells.HorizontalAlignment = 3;
            exApp.Cells[1, 1] = "Код вида топлива";
            exApp.Cells[1, 2] = "Название топлива";
            exApp.Cells[1, 3] = "Цена топлива";
            exApp.Cells[1, 4] = "Код учёта";
            exApp.Cells[1, 5] = "Код вида топлива (проверка)";
            exApp.Cells[1, 6] = "Дата";
            exApp.Cells[1, 7] = "Объём на начало дня (л)";
            exApp.Cells[1, 8] = "Объём продажи (л)";
            exApp.Visible = true;
        }
    }
}
