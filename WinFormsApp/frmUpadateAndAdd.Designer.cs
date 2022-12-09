namespace WinFormsApp
{
    partial class frmUpadateAndAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboManufacture = new System.Windows.Forms.ComboBox();
            this.dtDateRelease = new System.Windows.Forms.DateTimePicker();
            this.mskTxtPrice = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Release";
            // 
            // txtCarId
            // 
            this.txtCarId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarId.Location = new System.Drawing.Point(211, 80);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(303, 23);
            this.txtCarId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 23);
            this.txtName.TabIndex = 6;
            // 
            // cboManufacture
            // 
            this.cboManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManufacture.FormattingEnabled = true;
            this.cboManufacture.Location = new System.Drawing.Point(211, 177);
            this.cboManufacture.Name = "cboManufacture";
            this.cboManufacture.Size = new System.Drawing.Size(303, 23);
            this.cboManufacture.TabIndex = 10;
            // 
            // dtDateRelease
            // 
            this.dtDateRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateRelease.Location = new System.Drawing.Point(211, 265);
            this.dtDateRelease.Name = "dtDateRelease";
            this.dtDateRelease.Size = new System.Drawing.Size(303, 23);
            this.dtDateRelease.TabIndex = 11;
            // 
            // mskTxtPrice
            // 
            this.mskTxtPrice.Location = new System.Drawing.Point(211, 222);
            this.mskTxtPrice.Mask = "###.###";
            this.mskTxtPrice.Name = "mskTxtPrice";
            this.mskTxtPrice.Size = new System.Drawing.Size(303, 23);
            this.mskTxtPrice.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(42, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(308, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpadateAndAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskTxtPrice);
            this.Controls.Add(this.dtDateRelease);
            this.Controls.Add(this.cboManufacture);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpadateAndAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpadateAndAdd";
            this.Load += new System.EventHandler(this.frmUpadateAndAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCarId;
        private TextBox txtName;
        private ComboBox cboManufacture;
        private DateTimePicker dtDateRelease;
        private MaskedTextBox mskTxtPrice;
        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnSave;
    }
}