namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCategories = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productsBindingSource1 = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            productsBindingSource = new BindingSource(components);
            dataGridViewProducts = new DataGridView();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            productsBindingSource2 = new BindingSource(components);
            productsBindingSource3 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.BackgroundColor = Color.RosyBrown;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { Column1, nameDataGridViewTextBoxColumn1 });
            dataGridViewCategories.DataSource = productsBindingSource3;
            dataGridViewCategories.Location = new Point(418, 76);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 62;
            dataGridViewCategories.Size = new Size(370, 295);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductId";
            Column1.HeaderText = "ProductId";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // productsBindingSource1
            // 
            productsBindingSource1.DataMember = "Products";
            productsBindingSource1.DataSource = categoryBindingSource;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.BackgroundColor = Color.MistyRose;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = categoryBindingSource;
            dataGridViewProducts.Location = new Point(12, 76);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.Size = new Size(370, 295);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            categoryIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(676, 404);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // productsBindingSource2
            // 
            productsBindingSource2.DataMember = "Products";
            productsBindingSource2.DataSource = categoryBindingSource;
            // 
            // productsBindingSource3
            // 
            productsBindingSource3.DataMember = "Products";
            productsBindingSource3.DataSource = categoryBindingSource;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewProducts);
            Controls.Add(dataGridViewCategories);
            Name = "MainForm";
            Text = "Products and Categories";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCategories;
        private DataGridView dataGridViewProducts;
        private Button buttonSave;
        private BindingSource productsBindingSource;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource1;
        private BindingSource productsBindingSource2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private BindingSource productsBindingSource3;
    }
}
