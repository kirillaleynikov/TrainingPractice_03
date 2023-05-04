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
    public partial class AddFuel : Form
    {
        DataBase dataBase = new DataBase();
        public AddFuel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var fueltitle = textBox1.Text;
            var fuelprice = textBox2.Text;
            var idprovider = comboBox1.SelectedValue;
            var addQuery = $"insert into TypesOfFuel (title_of_type, price_fuel, provider_id) values ('{fueltitle}', '{fuelprice}', '{idprovider}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно создана! Обновите таблицу", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection();
            this.Close();
        }
        private void AddFuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gasStationDataSet.ProviderDirectory". При необходимости она может быть перемещена или удалена.
            this.providerDirectoryTableAdapter.Fill(this.gasStationDataSet.ProviderDirectory);
        }
    }
}