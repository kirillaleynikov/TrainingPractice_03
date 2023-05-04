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

namespace TrainingPractice_03
{
    enum RowState
    {
        ModifiedNew,
        Existed,
        Deleted,
        Modified
    }
    public partial class Directory : Form
    {   
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Directory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_provider", "Код поставщика");
            dataGridView1.Columns.Add("title_provider", "Название поставщика");
            dataGridView1.Columns.Add("isNew", String.Empty);
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 120;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 150;

        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from ProviderDirectory";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        private void Directory_Load(object sender, EventArgs e)
        {
            CreateColumns();
            dataGridView1.Columns[2].Visible = false;
            RefreshDataGrid(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from ProviderDirectory where concat (id_provider, title_provider) like '%" + textBoxSearch.Text + "%'";
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
                dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
        }
        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[2].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from ProviderDirectory where id_provider = '{id}'";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var idprovider = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var titleprovider = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var changeQuery = $"update ProviderDirectory set title_provider = '{titleprovider}' where id_provider ='{idprovider}'";
                    var command = new SqlCommand (changeQuery, dataBase.GetConnection()); 
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            Update();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProvider addProvider = new AddProvider();
            addProvider.Show();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
            }
        }
        private void Change()
        {
            var id = textBox2.Text;
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var titleProvider = textBox1.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRow].SetValues(id, titleProvider);
                dataGridView1.Rows[selectedRow].Cells[2].Value = RowState.Modified;
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change();
            Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}