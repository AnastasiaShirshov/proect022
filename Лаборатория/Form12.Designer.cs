namespace Лаборатория
{
    partial class Form12
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
            this.label3 = new System.Windows.Forms.Label();
            this._44П_2022_УП_ШиршоваDataSet11 = new Лаборатория._44П_2022_УП_ШиршоваDataSet11();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new Лаборатория._44П_2022_УП_ШиршоваDataSet11TableAdapters.ServicesTableAdapter();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 335);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Услуги";
            // 
            // _44П_2022_УП_ШиршоваDataSet11
            // 
            this._44П_2022_УП_ШиршоваDataSet11.DataSetName = "_44П_2022_УП_ШиршоваDataSet11";
            this._44П_2022_УП_ШиршоваDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this._44П_2022_УП_ШиршоваDataSet11;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
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
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private _44П_2022_УП_ШиршоваDataSet11 _44П_2022_УП_ШиршоваDataSet11;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private _44П_2022_УП_ШиршоваDataSet11TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}