namespace ProductInventory
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnView = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Price Unit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 23);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(102, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(363, 23);
            txtDescription.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(102, 88);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(363, 23);
            txtUnitPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(102, 136);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(363, 23);
            txtQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(102, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(348, 227);
            btnView.Name = "btnView";
            btnView.Size = new Size(117, 23);
            btnView.TabIndex = 9;
            btnView.Text = "View Products";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(603, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(250, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(481, 242);
            dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 47);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(603, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(363, 23);
            txtSearch.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 541);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnView;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtSearch;
    }
}
