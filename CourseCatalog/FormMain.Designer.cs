namespace CourseCatalog
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            lblPrice = new System.Windows.Forms.Label();
            numPrice = new System.Windows.Forms.NumericUpDown();
            lblCertNumber = new System.Windows.Forms.Label();
            txtCertNumber = new System.Windows.Forms.TextBox();
            lblCertDays = new System.Windows.Forms.Label();
            numCertDays = new System.Windows.Forms.NumericUpDown();
            btnAdd = new System.Windows.Forms.Button();
            btnSort = new System.Windows.Forms.Button();
            btnClone = new System.Windows.Forms.Button();
            lstCourses = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCertDays).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(96, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название курса:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(170, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(250, 23);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(12, 48);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(67, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Цена, руб.:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new System.Drawing.Point(170, 45);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new System.Drawing.Size(120, 23);
            numPrice.TabIndex = 3;
            // 
            // lblCertNumber
            // 
            lblCertNumber.AutoSize = true;
            lblCertNumber.Location = new System.Drawing.Point(12, 81);
            lblCertNumber.Name = "lblCertNumber";
            lblCertNumber.Size = new System.Drawing.Size(121, 15);
            lblCertNumber.TabIndex = 4;
            lblCertNumber.Text = "Номер сертификата:";
            // 
            // txtCertNumber
            // 
            txtCertNumber.Location = new System.Drawing.Point(170, 78);
            txtCertNumber.Name = "txtCertNumber";
            txtCertNumber.Size = new System.Drawing.Size(250, 23);
            txtCertNumber.TabIndex = 5;
            // 
            // lblCertDays
            // 
            lblCertDays.AutoSize = true;
            lblCertDays.Location = new System.Drawing.Point(12, 114);
            lblCertDays.Name = "lblCertDays";
            lblCertDays.Size = new System.Drawing.Size(122, 15);
            lblCertDays.TabIndex = 6;
            lblCertDays.Text = "Срок действия, дней:";
            // 
            // numCertDays
            // 
            numCertDays.Location = new System.Drawing.Point(170, 111);
            numCertDays.Maximum = new decimal(new int[] { 3650, 0, 0, 0 });
            numCertDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCertDays.Name = "numCertDays";
            numCertDays.Size = new System.Drawing.Size(120, 23);
            numCertDays.TabIndex = 7;
            numCertDays.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(450, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(238, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Добавить курс";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new System.Drawing.Point(450, 48);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(238, 30);
            btnSort.TabIndex = 9;
            btnSort.Text = "Сортировать по цене";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnClone
            // 
            btnClone.Location = new System.Drawing.Point(450, 86);
            btnClone.Name = "btnClone";
            btnClone.Size = new System.Drawing.Size(238, 30);
            btnClone.TabIndex = 10;
            btnClone.Text = "Клонировать выбранный";
            btnClone.UseVisualStyleBackColor = true;
            btnClone.Click += btnClone_Click;
            // 
            // lstCourses
            // 
            lstCourses.FormattingEnabled = true;
            lstCourses.HorizontalScrollbar = true;
            lstCourses.ItemHeight = 15;
            lstCourses.Location = new System.Drawing.Point(12, 150);
            lstCourses.Name = "lstCourses";
            lstCourses.Size = new System.Drawing.Size(676, 304);
            lstCourses.TabIndex = 11;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 466);
            Controls.Add(lstCourses);
            Controls.Add(btnClone);
            Controls.Add(btnSort);
            Controls.Add(btnAdd);
            Controls.Add(numCertDays);
            Controls.Add(lblCertDays);
            Controls.Add(txtCertNumber);
            Controls.Add(lblCertNumber);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Каталог онлайн-курсов и сертификатов доступа";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCertDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblCertNumber;
        private System.Windows.Forms.TextBox txtCertNumber;
        private System.Windows.Forms.Label lblCertDays;
        private System.Windows.Forms.NumericUpDown numCertDays;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.ListBox lstCourses;
    }
}
