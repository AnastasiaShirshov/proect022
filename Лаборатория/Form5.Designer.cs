namespace Лаборатория
{
    partial class Form5
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analyzatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analyzatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._44П_2022_УП_ШиршоваDataSet2 = new Лаборатория._44П_2022_УП_ШиршоваDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.analyzatorTableAdapter = new Лаборатория._44П_2022_УП_ШиршоваDataSet2TableAdapters.AnalyzatorTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(573, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(573, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(611, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(520, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Описание";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(573, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(611, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(481, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(504, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Анализатор";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.analyzatorDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.analyzatorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 316);
            this.dataGridView1.TabIndex = 17;
            // 
            // analyzatorDataGridViewTextBoxColumn
            // 
            this.analyzatorDataGridViewTextBoxColumn.DataPropertyName = "Analyzator";
            this.analyzatorDataGridViewTextBoxColumn.HeaderText = "Analyzator";
            this.analyzatorDataGridViewTextBoxColumn.Name = "analyzatorDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // analyzatorBindingSource
            // 
            this.analyzatorBindingSource.DataMember = "Analyzator";
            this.analyzatorBindingSource.DataSource = this._44П_2022_УП_ШиршоваDataSet2;
            // 
            // _44П_2022_УП_ШиршоваDataSet2
            // 
            this._44П_2022_УП_ШиршоваDataSet2.DataSetName = "_44П_2022_УП_ШиршоваDataSet2";
            this._44П_2022_УП_ШиршоваDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "Анализаторы";
            // 
            // analyzatorTableAdapter
            // 
            this.analyzatorTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(573, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 56);
            this.button4.TabIndex = 33;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
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
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private _44П_2022_УП_ШиршоваDataSet2 _44П_2022_УП_ШиршоваDataSet2;
        private System.Windows.Forms.BindingSource analyzatorBindingSource;
        private _44П_2022_УП_ШиршоваDataSet2TableAdapters.AnalyzatorTableAdapter analyzatorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn analyzatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}