namespace Лаборатория
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._44П_2022_УП_ШиршоваDataSet = new Лаборатория._44П_2022_УП_ШиршоваDataSet();
            this.servicesTableAdapter = new Лаборатория._44П_2022_УП_ШиршоваDataSetTableAdapters.ServicesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Услуги";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 316);
            this.dataGridView1.TabIndex = 6;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this._44П_2022_УП_ШиршоваDataSet;
            // 
            // _44П_2022_УП_ШиршоваDataSet
            // 
            this._44П_2022_УП_ШиршоваDataSet.DataSetName = "_44П_2022_УП_ШиршоваDataSet";
            this._44П_2022_УП_ШиршоваDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(560, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(574, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(507, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Услуга";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(530, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(574, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(519, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Цена";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(560, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(560, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(661, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(560, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 56);
            this.button4.TabIndex = 19;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(428, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Услуги (Администратор)";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _44П_2022_УП_ШиршоваDataSet _44П_2022_УП_ШиршоваDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private _44П_2022_УП_ШиршоваDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
    }
}