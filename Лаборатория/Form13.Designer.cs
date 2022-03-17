namespace Лаборатория
{
    partial class Form13
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
            this._44П_2022_УП_ШиршоваDataSet12 = new Лаборатория._44П_2022_УП_ШиршоваDataSet12();
            this.analyzatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analyzatorTableAdapter = new Лаборатория._44П_2022_УП_ШиршоваDataSet12TableAdapters.AnalyzatorTableAdapter();
            this.analyzatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzatorBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 316);
            this.dataGridView1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Анализаторы";
            // 
            // _44П_2022_УП_ШиршоваDataSet12
            // 
            this._44П_2022_УП_ШиршоваDataSet12.DataSetName = "_44П_2022_УП_ШиршоваDataSet12";
            this._44П_2022_УП_ШиршоваDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // analyzatorBindingSource
            // 
            this.analyzatorBindingSource.DataMember = "Analyzator";
            this.analyzatorBindingSource.DataSource = this._44П_2022_УП_ШиршоваDataSet12;
            // 
            // analyzatorTableAdapter
            // 
            this.analyzatorTableAdapter.ClearBeforeFill = true;
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
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private _44П_2022_УП_ШиршоваDataSet12 _44П_2022_УП_ШиршоваDataSet12;
        private System.Windows.Forms.BindingSource analyzatorBindingSource;
        private _44П_2022_УП_ШиршоваDataSet12TableAdapters.AnalyzatorTableAdapter analyzatorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn analyzatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}