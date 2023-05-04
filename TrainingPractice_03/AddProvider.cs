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
    public partial class AddProvider : Form
    {
        DataBase dataBase = new DataBase();
        public AddProvider()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSaveProvider_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var titleprovider = textBoxTitleProvider.Text;
            var addQuery = $"insert into ProviderDirectory (title_provider) values ('{titleprovider}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно создана! Обновите таблицу", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection(); 
            this.Close();
        }
    }
}
