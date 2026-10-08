namespace baitap3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;

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
            groupBoxLeft = new GroupBox();
            lblCode = new Label();
            txtCode = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblUnit = new Label();
            cmbUnit = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeleteRow = new Button();
            btnDeleteAll = new Button();
            groupBoxRight = new GroupBox();
            listViewItems = new ListView();
            colCode = new ColumnHeader();
            colName = new ColumnHeader();
            colUnit = new ColumnHeader();
            colPrice = new ColumnHeader();
            groupBoxLeft.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLeft
            // 
            groupBoxLeft.Controls.Add(lblCode);
            groupBoxLeft.Controls.Add(txtCode);
            groupBoxLeft.Controls.Add(lblName);
            groupBoxLeft.Controls.Add(txtName);
            groupBoxLeft.Controls.Add(lblUnit);
            groupBoxLeft.Controls.Add(cmbUnit);
            groupBoxLeft.Controls.Add(lblPrice);
            groupBoxLeft.Controls.Add(txtPrice);
            groupBoxLeft.Controls.Add(btnAdd);
            groupBoxLeft.Controls.Add(btnUpdate);
            groupBoxLeft.Controls.Add(btnDeleteRow);
            groupBoxLeft.Controls.Add(btnDeleteAll);
            groupBoxLeft.Location = new Point(12, 12);
            groupBoxLeft.Name = "groupBoxLeft";
            groupBoxLeft.Size = new Size(320, 426);
            groupBoxLeft.TabIndex = 0;
            groupBoxLeft.TabStop = false;
            groupBoxLeft.Text = "Input";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(13, 27);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(88, 25);
            lblCode.TabIndex = 0;
            lblCode.Text = "Mã vật tư";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(13, 55);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(290, 31);
            txtCode.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Tên vật tư";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 31);
            txtName.TabIndex = 1;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(13, 142);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(99, 25);
            lblUnit.TabIndex = 2;
            lblUnit.Text = "Đơn vị tính";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cmbUnit.Location = new Point(12, 170);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(290, 33);
            cmbUnit.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 206);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(120, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Đơn giá nhập";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 234);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(290, 31);
            txtPrice.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(162, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Location = new Point(6, 328);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(140, 38);
            btnDeleteRow.TabIndex = 6;
            btnDeleteRow.Text = "Xóa dòng";
            btnDeleteRow.UseVisualStyleBackColor = true;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(162, 328);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(140, 38);
            btnDeleteAll.TabIndex = 7;
            btnDeleteAll.Text = "Xóa toàn bộ";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // groupBoxRight
            // 
            groupBoxRight.Location = new Point(338, 12);
            groupBoxRight.Name = "groupBoxRight";
            groupBoxRight.Size = new Size(450, 426);
            groupBoxRight.TabIndex = 1;
            groupBoxRight.TabStop = false;
            groupBoxRight.Text = "List";
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { colCode, colName, colUnit, colPrice });
            listViewItems.FullRowSelect = true;
            listViewItems.Location = new Point(8, 22);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(432, 396);
            listViewItems.TabIndex = 8;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            listViewItems.SelectedIndexChanged += listViewItems_SelectedIndexChanged;
            // 
            // colCode
            // 
            colCode.Text = "Mã VT";
            colCode.Width = 90;
            // 
            // colName
            // 
            colName.Text = "Tên VT";
            colName.Width = 160;
            // 
            // colUnit
            // 
            colUnit.Text = "Đơn vị";
            colUnit.Width = 80;
            // 
            // colPrice
            // 
            colPrice.Text = "Đơn giá";
            colPrice.Width = 96;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            // put listView inside the right group box
            groupBoxRight.Controls.Add(listViewItems);
            Controls.Add(groupBoxLeft);
            Controls.Add(groupBoxRight);
            Name = "Form1";
            Text = "Item List Manager";
            groupBoxLeft.ResumeLayout(false);
            groupBoxLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
