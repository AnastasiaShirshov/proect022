namespace Лаборатория
{
    partial class Form7
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
            this._44П_2022_УП_ШиршоваDataSet9 = new Лаборатория._44П_2022_УП_ШиршоваDataSet9();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Лаборатория._44П_2022_УП_ШиршоваDataSet9TableAdapters.UsersTableAdapter();
            this.idUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUSDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 434);
            this.dataGridView1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "Пациетны";
            // 
            // _44П_2022_УП_ШиршоваDataSet9
            // 
            this._44П_2022_УП_ШиршоваDataSet9.DataSetName = "_44П_2022_УП_ШиршоваDataSet9";
            this._44П_2022_УП_ШиршоваDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._44П_2022_УП_ШиршоваDataSet9;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // idUSDataGridViewTextBoxColumn
            // 
            this.idUSDataGridViewTextBoxColumn.DataPropertyName = "idUS";
            this.idUSDataGridViewTextBoxColumn.HeaderText = "idUS";
            this.idUSDataGridViewTextBoxColumn.Name = "idUSDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "ip";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(909, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_2022_УП_ШиршоваDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private _44П_2022_УП_ШиршоваDataSet9 _44П_2022_УП_ШиршоваDataSet9;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _44П_2022_УП_ШиршоваDataSet9TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
    }
}