using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    enum RowState2
    {
        ModifiedNew,
        Existed,
        Deleted,
        Modified
    }
    public partial class Fuel : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Fuel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_type", "Код вида");
            dataGridView1.Columns.Add("title_of_type", "Название");
            dataGridView1.Columns.Add("price_fuel", "Установленная цена");
            dataGridView1.Columns.Add("provider_id", "Код поставщика");
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
        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from TypesOfFuel";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        private void Fuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gasStationDataSet.ProviderDirectory". При необходимости она может быть перемещена или удалена.
            this.providerDirectoryTableAdapter.Fill(this.gasStationDataSet.ProviderDirectory);
            comboBox1.Text = "";
            CreateColumns();
            dataGridView1.Columns[4].Visible = false;
            RefreshDataGrid(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from TypesOfFuel where concat (id_type, title_of_type, price_fuel, provider_id) like '%" + textBoxSearch.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        private void Filter(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string Ot = textBox1.Text;
            string Do = textBox2.Text;
            string searchString = $"select * from TypesOfFuel where price_fuel >= {Ot} and price_fuel <= {Do}";
            SqlCommand command = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState2.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState2.Deleted;
        }
        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState2)dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == RowState2.Existed)
                {
                    continue;
                }
                if (rowState == RowState2.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from TypesOfFuel where id_type = '{id}'";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState2.Modified)
                {
                    var idtype = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var titleoftype = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var pricefuel = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var providerid = dataGridView1.Rows[index].Cells[3].Value;
                    var changeQuery = $"update TypesOfFuel set title_of_type = '{titleoftype}', price_fuel = '{pricefuel}', provider_id = '{providerid}' where id_type ='{idtype}'";
                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            Update();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFuel addFuel = new AddFuel();
            addFuel.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBoxIdFuel.Text = row.Cells[0].Value.ToString();
                textBoxFuelTitle.Text = row.Cells[1].Value.ToString();
                textBoxFuelPrice.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
            }
        }
        private void Change()
        {
            var idFuel = textBoxIdFuel.Text;
            var FuelTitle = textBoxFuelTitle.Text;
            var FuelPrice = textBoxFuelPrice.Text;
            var ProviderID = comboBox1.SelectedValue;

            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRow].SetValues(idFuel, FuelTitle, FuelPrice, ProviderID);
                dataGridView1.Rows[selectedRow].Cells[4].Value = RowState2.Modified;
            }
            textBoxIdFuel.Text = "";
            textBoxFuelTitle.Text = "";
            textBoxFuelPrice.Text = "";
            comboBox1.Text = "";
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
            Update();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter(dataGridView1);
        }
    }
}