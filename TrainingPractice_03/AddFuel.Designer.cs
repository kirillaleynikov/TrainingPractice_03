namespace TrainingPractice_03
{
    partial class AddFuel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gasStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasStationDataSet = new TrainingPractice_03.GasStationDataSet();
            this.providerDirectoryTableAdapter = new TrainingPractice_03.GasStationDataSetTableAdapters.ProviderDirectoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(307, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 29);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(307, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 29);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название топлива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(214, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(86, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Код поставщика:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(307, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.DisplayMember = "title_provider";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "id_provider";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ProviderDirectory";
            this.bindingSource1.DataSource = this.gasStationDataSetBindingSource;
            // 
            // gasStationDataSetBindingSource
            // 
            this.gasStationDataSetBindingSource.DataSource = this.gasStationDataSet;
            this.gasStationDataSetBindingSource.Position = 0;
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
            // AddFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 304);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddFuel";
            this.Text = "Добавить вид топлива";
            this.Load += new System.EventHandler(this.AddFuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gasStationDataSetBindingSource;
        private GasStationDataSet gasStationDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GasStationDataSetTableAdapters.ProviderDirectoryTableAdapter providerDirectoryTableAdapter;
    }
}