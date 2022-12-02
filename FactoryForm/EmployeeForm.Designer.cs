namespace FactoryForm
{
    partial class EmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.higherEducationPanel = new System.Windows.Forms.Panel();
            this.higherTechnicalEducationRadioButton = new System.Windows.Forms.RadioButton();
            this.noHigherTechnicalEducationRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.masterRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.workshopsCompoBox = new System.Windows.Forms.ComboBox();
            this.nameTitleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Unload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.higherEducationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salaryNumericUpDown);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.higherEducationPanel);
            this.panel1.Controls.Add(this.masterRadioButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.employeeRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.workshopsCompoBox);
            this.panel1.Controls.Add(this.nameTitleBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 351);
            this.panel1.TabIndex = 0;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryNumericUpDown.Location = new System.Drawing.Point(11, 228);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.ReadOnly = true;
            this.salaryNumericUpDown.Size = new System.Drawing.Size(347, 30);
            this.salaryNumericUpDown.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Salary";
            // 
            // higherEducationPanel
            // 
            this.higherEducationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.higherEducationPanel.BackColor = System.Drawing.Color.White;
            this.higherEducationPanel.Controls.Add(this.higherTechnicalEducationRadioButton);
            this.higherEducationPanel.Controls.Add(this.noHigherTechnicalEducationRadioButton);
            this.higherEducationPanel.Controls.Add(this.label4);
            this.higherEducationPanel.Location = new System.Drawing.Point(11, 264);
            this.higherEducationPanel.Name = "higherEducationPanel";
            this.higherEducationPanel.Size = new System.Drawing.Size(347, 61);
            this.higherEducationPanel.TabIndex = 25;
            // 
            // higherTechnicalEducationRadioButton
            // 
            this.higherTechnicalEducationRadioButton.AutoSize = true;
            this.higherTechnicalEducationRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.higherTechnicalEducationRadioButton.Location = new System.Drawing.Point(5, 30);
            this.higherTechnicalEducationRadioButton.Name = "higherTechnicalEducationRadioButton";
            this.higherTechnicalEducationRadioButton.Size = new System.Drawing.Size(58, 24);
            this.higherTechnicalEducationRadioButton.TabIndex = 22;
            this.higherTechnicalEducationRadioButton.Text = "Yes";
            this.higherTechnicalEducationRadioButton.UseVisualStyleBackColor = true;
            // 
            // noHigherTechnicalEducationRadioButton
            // 
            this.noHigherTechnicalEducationRadioButton.AutoSize = true;
            this.noHigherTechnicalEducationRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noHigherTechnicalEducationRadioButton.Location = new System.Drawing.Point(74, 30);
            this.noHigherTechnicalEducationRadioButton.Name = "noHigherTechnicalEducationRadioButton";
            this.noHigherTechnicalEducationRadioButton.Size = new System.Drawing.Size(51, 24);
            this.noHigherTechnicalEducationRadioButton.TabIndex = 24;
            this.noHigherTechnicalEducationRadioButton.Text = "No";
            this.noHigherTechnicalEducationRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Higher education";
            // 
            // masterRadioButton
            // 
            this.masterRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterRadioButton.AutoSize = true;
            this.masterRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterRadioButton.Location = new System.Drawing.Point(11, 178);
            this.masterRadioButton.Name = "masterRadioButton";
            this.masterRadioButton.Size = new System.Drawing.Size(82, 24);
            this.masterRadioButton.TabIndex = 21;
            this.masterRadioButton.Text = "Master";
            this.masterRadioButton.UseVisualStyleBackColor = true;
            this.masterRadioButton.CheckedChanged += new System.EventHandler(this.masterRadioButton_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Choose specific status";
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Checked = true;
            this.employeeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeRadioButton.Location = new System.Drawing.Point(11, 148);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(103, 24);
            this.employeeRadioButton.TabIndex = 19;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            this.employeeRadioButton.CheckedChanged += new System.EventHandler(this.employeeRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Workshop";
            // 
            // workshopsCompoBox
            // 
            this.workshopsCompoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workshopsCompoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workshopsCompoBox.FormattingEnabled = true;
            this.workshopsCompoBox.Location = new System.Drawing.Point(11, 88);
            this.workshopsCompoBox.Name = "workshopsCompoBox";
            this.workshopsCompoBox.Size = new System.Drawing.Size(347, 33);
            this.workshopsCompoBox.TabIndex = 17;
            // 
            // nameTitleBox
            // 
            this.nameTitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTitleBox.Location = new System.Drawing.Point(11, 33);
            this.nameTitleBox.Name = "nameTitleBox";
            this.nameTitleBox.Size = new System.Drawing.Size(347, 30);
            this.nameTitleBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // Unload
            // 
            this.Unload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Unload.BackColor = System.Drawing.SystemColors.Control;
            this.Unload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Unload.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Unload.Location = new System.Drawing.Point(9, 371);
            this.Unload.Name = "Unload";
            this.Unload.Size = new System.Drawing.Size(146, 37);
            this.Unload.TabIndex = 14;
            this.Unload.Text = "Add";
            this.Unload.UseVisualStyleBackColor = false;
            this.Unload.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 420);
            this.Controls.Add(this.Unload);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.higherEducationPanel.ResumeLayout(false);
            this.higherEducationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTitleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workshopsCompoBox;
        private System.Windows.Forms.RadioButton masterRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton noHigherTechnicalEducationRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel higherEducationPanel;
        private System.Windows.Forms.RadioButton higherTechnicalEducationRadioButton;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Unload;
    }
}