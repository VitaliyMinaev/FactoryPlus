namespace FactoryForm
{
    partial class Form1
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
            this.workshopButton = new System.Windows.Forms.Button();
            this.openPersonButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.personsCompoBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfitFromEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MasterSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CountOfMasterTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CountOfEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CountOfWorkshopsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfitFromMasterTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.factoriesListView = new System.Windows.Forms.ListView();
            this.Unload = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.CalculateProfitButton = new System.Windows.Forms.Button();
            this.ProfitSumTextBox = new System.Windows.Forms.TextBox();
            this.CompareFactoriesButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ProfitFactoryTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ComparedFactory2TextBox = new System.Windows.Forms.TextBox();
            this.ComparedFactory1TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.workshopButton);
            this.panel1.Controls.Add(this.openPersonButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.personsCompoBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ProfitFromEmployeeTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MasterSalaryTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.EmployeeSalaryTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CountOfMasterTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CountOfEmployeeTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CountOfWorkshopsTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProfitFromMasterTextBox);
            this.panel1.Controls.Add(this.TitleTextBox);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(383, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 580);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // workshopButton
            // 
            this.workshopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workshopButton.BackColor = System.Drawing.SystemColors.Control;
            this.workshopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workshopButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workshopButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workshopButton.Location = new System.Drawing.Point(225, 84);
            this.workshopButton.Name = "workshopButton";
            this.workshopButton.Size = new System.Drawing.Size(141, 33);
            this.workshopButton.TabIndex = 36;
            this.workshopButton.Text = "Check workshop";
            this.workshopButton.UseVisualStyleBackColor = false;
            this.workshopButton.Click += new System.EventHandler(this.workshopButton_Click);
            // 
            // openPersonButton
            // 
            this.openPersonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openPersonButton.BackColor = System.Drawing.SystemColors.Control;
            this.openPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openPersonButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openPersonButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openPersonButton.Location = new System.Drawing.Point(90, 539);
            this.openPersonButton.Name = "openPersonButton";
            this.openPersonButton.Size = new System.Drawing.Size(135, 33);
            this.openPersonButton.TabIndex = 35;
            this.openPersonButton.Text = "Get info";
            this.openPersonButton.UseVisualStyleBackColor = false;
            this.openPersonButton.Click += new System.EventHandler(this.openPersonButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(231, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 34;
            this.button2.Text = "Fire person";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.firePersonButton_Click);
            // 
            // personsCompoBox
            // 
            this.personsCompoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personsCompoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personsCompoBox.FormattingEnabled = true;
            this.personsCompoBox.Location = new System.Drawing.Point(19, 502);
            this.personsCompoBox.Name = "personsCompoBox";
            this.personsCompoBox.Size = new System.Drawing.Size(347, 33);
            this.personsCompoBox.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(19, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Hire person";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.hirePersonButton_Click);
            // 
            // ProfitFromEmployeeTextBox
            // 
            this.ProfitFromEmployeeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfitFromEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitFromEmployeeTextBox.Location = new System.Drawing.Point(19, 372);
            this.ProfitFromEmployeeTextBox.Name = "ProfitFromEmployeeTextBox";
            this.ProfitFromEmployeeTextBox.Size = new System.Drawing.Size(347, 30);
            this.ProfitFromEmployeeTextBox.TabIndex = 26;
            this.ProfitFromEmployeeTextBox.TextChanged += new System.EventHandler(this.TextBoxes_Money_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Profit from employee (per month)";
            // 
            // MasterSalaryTextBox
            // 
            this.MasterSalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasterSalaryTextBox.Location = new System.Drawing.Point(19, 316);
            this.MasterSalaryTextBox.Name = "MasterSalaryTextBox";
            this.MasterSalaryTextBox.Size = new System.Drawing.Size(347, 30);
            this.MasterSalaryTextBox.TabIndex = 24;
            this.MasterSalaryTextBox.TextChanged += new System.EventHandler(this.TextBoxes_Money_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(15, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Master salary";
            // 
            // EmployeeSalaryTextBox
            // 
            this.EmployeeSalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeSalaryTextBox.Location = new System.Drawing.Point(19, 255);
            this.EmployeeSalaryTextBox.Name = "EmployeeSalaryTextBox";
            this.EmployeeSalaryTextBox.Size = new System.Drawing.Size(347, 30);
            this.EmployeeSalaryTextBox.TabIndex = 22;
            this.EmployeeSalaryTextBox.TextChanged += new System.EventHandler(this.TextBoxes_Money_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Employee\'s salary";
            // 
            // CountOfMasterTextBox
            // 
            this.CountOfMasterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfMasterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfMasterTextBox.Location = new System.Drawing.Point(19, 197);
            this.CountOfMasterTextBox.Name = "CountOfMasterTextBox";
            this.CountOfMasterTextBox.ReadOnly = true;
            this.CountOfMasterTextBox.Size = new System.Drawing.Size(347, 30);
            this.CountOfMasterTextBox.TabIndex = 18;
            this.CountOfMasterTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Count of masters";
            // 
            // CountOfEmployeeTextBox
            // 
            this.CountOfEmployeeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfEmployeeTextBox.Location = new System.Drawing.Point(19, 142);
            this.CountOfEmployeeTextBox.Name = "CountOfEmployeeTextBox";
            this.CountOfEmployeeTextBox.ReadOnly = true;
            this.CountOfEmployeeTextBox.Size = new System.Drawing.Size(347, 30);
            this.CountOfEmployeeTextBox.TabIndex = 16;
            this.CountOfEmployeeTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Count of employee";
            // 
            // CountOfWorkshopsTextBox
            // 
            this.CountOfWorkshopsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfWorkshopsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfWorkshopsTextBox.Location = new System.Drawing.Point(19, 84);
            this.CountOfWorkshopsTextBox.Name = "CountOfWorkshopsTextBox";
            this.CountOfWorkshopsTextBox.ReadOnly = true;
            this.CountOfWorkshopsTextBox.Size = new System.Drawing.Size(153, 30);
            this.CountOfWorkshopsTextBox.TabIndex = 14;
            this.CountOfWorkshopsTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Count of workshops";
            // 
            // ProfitFromMasterTextBox
            // 
            this.ProfitFromMasterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfitFromMasterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitFromMasterTextBox.Location = new System.Drawing.Point(19, 428);
            this.ProfitFromMasterTextBox.Name = "ProfitFromMasterTextBox";
            this.ProfitFromMasterTextBox.Size = new System.Drawing.Size(347, 30);
            this.ProfitFromMasterTextBox.TabIndex = 12;
            this.ProfitFromMasterTextBox.TextChanged += new System.EventHandler(this.TextBoxes_Money_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTextBox.Location = new System.Drawing.Point(19, 29);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(347, 30);
            this.TitleTextBox.TabIndex = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(231, 464);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(135, 33);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profit from master (per month)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // factoriesListView
            // 
            this.factoriesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factoriesListView.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factoriesListView.GridLines = true;
            this.factoriesListView.HideSelection = false;
            this.factoriesListView.Location = new System.Drawing.Point(14, 36);
            this.factoriesListView.Name = "factoriesListView";
            this.factoriesListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.factoriesListView.Size = new System.Drawing.Size(359, 438);
            this.factoriesListView.TabIndex = 8;
            this.factoriesListView.UseCompatibleStateImageBehavior = false;
            this.factoriesListView.View = System.Windows.Forms.View.List;
            this.factoriesListView.SelectedIndexChanged += new System.EventHandler(this.factoriesListView_SelectedIndexChanged);
            // 
            // Unload
            // 
            this.Unload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Unload.BackColor = System.Drawing.Color.LimeGreen;
            this.Unload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Unload.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Unload.Location = new System.Drawing.Point(620, 622);
            this.Unload.Name = "Unload";
            this.Unload.Size = new System.Drawing.Size(146, 37);
            this.Unload.TabIndex = 13;
            this.Unload.Text = "Save changes";
            this.Unload.UseVisualStyleBackColor = true;
            this.Unload.Click += new System.EventHandler(this.Unload_Click);
            // 
            // Load
            // 
            this.Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Load.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Load.Location = new System.Drawing.Point(467, 622);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(148, 37);
            this.Load.TabIndex = 12;
            this.Load.Text = "Load factories";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(379, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Factories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.CalculateProfitButton);
            this.panel2.Controls.Add(this.ProfitSumTextBox);
            this.panel2.Controls.Add(this.CompareFactoriesButton);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.ProfitFactoryTextBox);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.ComparedFactory2TextBox);
            this.panel2.Controls.Add(this.ComparedFactory1TextBox);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(14, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 229);
            this.panel2.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(260, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 45;
            this.label18.Text = "Factory";
            // 
            // CalculateProfitButton
            // 
            this.CalculateProfitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateProfitButton.BackColor = System.Drawing.SystemColors.Control;
            this.CalculateProfitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CalculateProfitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateProfitButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateProfitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateProfitButton.Location = new System.Drawing.Point(209, 183);
            this.CalculateProfitButton.Name = "CalculateProfitButton";
            this.CalculateProfitButton.Size = new System.Drawing.Size(141, 31);
            this.CalculateProfitButton.TabIndex = 44;
            this.CalculateProfitButton.Text = "Calculate";
            this.CalculateProfitButton.UseVisualStyleBackColor = false;
            this.CalculateProfitButton.Click += new System.EventHandler(this.CalculateProfitButton_Click);
            // 
            // ProfitSumTextBox
            // 
            this.ProfitSumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfitSumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitSumTextBox.Location = new System.Drawing.Point(5, 183);
            this.ProfitSumTextBox.Name = "ProfitSumTextBox";
            this.ProfitSumTextBox.Size = new System.Drawing.Size(198, 30);
            this.ProfitSumTextBox.TabIndex = 43;
            this.ProfitSumTextBox.TextChanged += new System.EventHandler(this.TextBoxes_Money_TextChanged);
            // 
            // CompareFactoriesButton
            // 
            this.CompareFactoriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareFactoriesButton.BackColor = System.Drawing.SystemColors.Control;
            this.CompareFactoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CompareFactoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompareFactoriesButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompareFactoriesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CompareFactoriesButton.Location = new System.Drawing.Point(209, 105);
            this.CompareFactoriesButton.Name = "CompareFactoriesButton";
            this.CompareFactoriesButton.Size = new System.Drawing.Size(141, 30);
            this.CompareFactoriesButton.TabIndex = 37;
            this.CompareFactoriesButton.Text = "Compare";
            this.CompareFactoriesButton.UseVisualStyleBackColor = false;
            this.CompareFactoriesButton.Click += new System.EventHandler(this.CompareFactoriesButton_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(4, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Calculate profit";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(258, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Factory 2";
            // 
            // ProfitFactoryTextBox
            // 
            this.ProfitFactoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfitFactoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitFactoryTextBox.Location = new System.Drawing.Point(5, 144);
            this.ProfitFactoryTextBox.Name = "ProfitFactoryTextBox";
            this.ProfitFactoryTextBox.Size = new System.Drawing.Size(345, 30);
            this.ProfitFactoryTextBox.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(258, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Factory 1";
            // 
            // ComparedFactory2TextBox
            // 
            this.ComparedFactory2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComparedFactory2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComparedFactory2TextBox.Location = new System.Drawing.Point(5, 69);
            this.ComparedFactory2TextBox.Name = "ComparedFactory2TextBox";
            this.ComparedFactory2TextBox.Size = new System.Drawing.Size(345, 30);
            this.ComparedFactory2TextBox.TabIndex = 39;
            // 
            // ComparedFactory1TextBox
            // 
            this.ComparedFactory1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComparedFactory1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComparedFactory1TextBox.Location = new System.Drawing.Point(5, 33);
            this.ComparedFactory1TextBox.Name = "ComparedFactory1TextBox";
            this.ComparedFactory1TextBox.Size = new System.Drawing.Size(345, 30);
            this.ComparedFactory1TextBox.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(4, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Compare factories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.factoriesListView);
            this.Controls.Add(this.Unload);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(796, 767);
            this.Name = "Form1";
            this.Text = "Factory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Unloading);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProfitFromMasterTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView factoriesListView;
        private System.Windows.Forms.Button Unload;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountOfWorkshopsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountOfEmployeeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmployeeSalaryTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProfitFromEmployeeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MasterSalaryTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CountOfMasterTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CompareFactoriesButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ComparedFactory2TextBox;
        private System.Windows.Forms.TextBox ComparedFactory1TextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ProfitFactoryTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button CalculateProfitButton;
        private System.Windows.Forms.TextBox ProfitSumTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox personsCompoBox;
        private System.Windows.Forms.Button openPersonButton;
        private System.Windows.Forms.Button workshopButton;
    }
}