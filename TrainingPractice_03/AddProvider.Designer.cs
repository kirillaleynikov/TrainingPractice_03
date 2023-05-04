namespace TrainingPractice_03
{
    partial class AddProvider
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
            this.textBoxTitleProvider = new System.Windows.Forms.TextBox();
            this.buttonSaveProvider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitleProvider
            // 
            this.textBoxTitleProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitleProvider.Location = new System.Drawing.Point(315, 45);
            this.textBoxTitleProvider.Multiline = true;
            this.textBoxTitleProvider.Name = "textBoxTitleProvider";
            this.textBoxTitleProvider.Size = new System.Drawing.Size(286, 29);
            this.textBoxTitleProvider.TabIndex = 1;
            // 
            // buttonSaveProvider
            // 
            this.buttonSaveProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveProvider.Location = new System.Drawing.Point(195, 97);
            this.buttonSaveProvider.Name = "buttonSaveProvider";
            this.buttonSaveProvider.Size = new System.Drawing.Size(257, 42);
            this.buttonSaveProvider.TabIndex = 2;
            this.buttonSaveProvider.Text = "Сохранить";
            this.buttonSaveProvider.UseVisualStyleBackColor = true;
            this.buttonSaveProvider.Click += new System.EventHandler(this.buttonSaveProvider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название поставщика:";
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveProvider);
            this.Controls.Add(this.textBoxTitleProvider);
            this.Name = "AddProvider";
            this.Text = "Добавить поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitleProvider;
        private System.Windows.Forms.Button buttonSaveProvider;
        private System.Windows.Forms.Label label2;
    }
}