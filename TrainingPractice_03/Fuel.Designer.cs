namespace TrainingPractice_03
{
    partial class Fuel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxIdFuel = new System.Windows.Forms.TextBox();
            this.textBoxFuelTitle = new System.Windows.Forms.TextBox();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gasStationDataSet = new TrainingPractice_03.GasStationDataSet();
            this.providerDirectoryTableAdapter = new TrainingPractice_03.GasStationDataSetTableAdapters.ProviderDirectoryTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(330, 321);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(308, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 349);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 39);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxIdFuel
            // 
            this.textBoxIdFuel.Enabled = false;
            this.textBoxIdFuel.Location = new System.Drawing.Point(1034, 12);
            this.textBoxIdFuel.Name = "textBoxIdFuel";
            this.textBoxIdFuel.Size = new System.Drawing.Size(181, 22);
            this.textBoxIdFuel.TabIndex = 5;
            // 
            // textBoxFuelTitle
            // 
            this.textBoxFuelTitle.Location = new System.Drawing.Point(1034, 40);
            this.textBoxFuelTitle.Name = "textBoxFuelTitle";
            this.textBoxFuelTitle.Size = new System.Drawing.Size(181, 22);
            this.textBoxFuelTitle.TabIndex = 6;
            // 
            // textBoxFuelPrice
            // 
            this.textBoxFuelPrice.Location = new System.Drawing.Point(1034, 68);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.Size = new System.Drawing.Size(181, 22);
            this.textBoxFuelPrice.TabIndex = 7;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(719, 349);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(151, 39);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(719, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(502, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "от:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "до:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Фильтровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.DisplayMember = "title_provider";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1034, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "id_provider";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ProviderDirectory";
            this.bindingSource1.DataSource = this.gasStationDataSet;
            // 
            // gasStationDataSet
            // 
            this.gasStationDataSet.DataSetName = "GasStationDataSet";
            this.gasStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerDirectoryTableAdapter
            // 
            this.providerDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(954, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Код вида:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Установленная цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(941, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Поставщик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Поиск:";
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.textBoxFuelPrice);
            this.Controls.Add(this.textBoxFuelTitle);
            this.Controls.Add(this.textBoxIdFuel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fuel";
            this.Text = "Виды топлива";
            this.Load += new System.EventHandler(this.Fuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxIdFuel;
        private System.Windows.Forms.TextBox textBoxFuelTitle;
        private System.Windows.Forms.TextBox textBoxFuelPrice;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GasStationDataSet gasStationDataSet;
        private GasStationDataSetTableAdapters.ProviderDirectoryTableAdapter providerDirectoryTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}