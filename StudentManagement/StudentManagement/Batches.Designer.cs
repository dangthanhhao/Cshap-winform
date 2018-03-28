namespace StudentManagement
{
    partial class Batches
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
            this.dtgBatches = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.studentManagementDataSet = new StudentManagement.StudentManagementDataSet();
            this.batchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchesTableAdapter = new StudentManagement.StudentManagementDataSetTableAdapters.BatchesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBatches
            // 
            this.dtgBatches.AutoGenerateColumns = false;
            this.dtgBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.batchNameDataGridViewTextBoxColumn});
            this.dtgBatches.DataSource = this.batchesBindingSource;
            this.dtgBatches.Location = new System.Drawing.Point(12, 12);
            this.dtgBatches.Name = "dtgBatches";
            this.dtgBatches.Size = new System.Drawing.Size(464, 276);
            this.dtgBatches.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentManagementDataSet
            // 
            this.studentManagementDataSet.DataSetName = "StudentManagementDataSet";
            this.studentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchesBindingSource
            // 
            this.batchesBindingSource.DataMember = "Batches";
            this.batchesBindingSource.DataSource = this.studentManagementDataSet;
            // 
            // batchesTableAdapter
            // 
            this.batchesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNameDataGridViewTextBoxColumn
            // 
            this.batchNameDataGridViewTextBoxColumn.DataPropertyName = "BatchName";
            this.batchNameDataGridViewTextBoxColumn.HeaderText = "BatchName";
            this.batchNameDataGridViewTextBoxColumn.Name = "batchNameDataGridViewTextBoxColumn";
            // 
            // Batches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgBatches);
            this.Name = "Batches";
            this.Text = "Batches";
            this.Load += new System.EventHandler(this.Batches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBatches;
        private System.Windows.Forms.Button button1;
        private StudentManagementDataSet studentManagementDataSet;
        private System.Windows.Forms.BindingSource batchesBindingSource;
        private StudentManagementDataSetTableAdapters.BatchesTableAdapter batchesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNameDataGridViewTextBoxColumn;
    }
}