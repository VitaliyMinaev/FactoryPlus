using FactoryForm.Domain;
using FactoryForm.Domain.Abstract;
using System;
using System.Windows.Forms;

namespace FactoryForm
{
    public partial class EmployeeForm : Form
    {
        private Factory _factory;
        private string[] _workshops;
        private bool _isEmployee = true;
        public EmployeeForm()
        {
            InitializeComponent();

            PrepareEmployeeElements();
        }
        public EmployeeForm(Factory currentFactory, string[] workShops)
        {
            InitializeComponent();
            _factory = currentFactory;
            _workshops = workShops;
            PrepareEmployeeElements();
        }
        public EmployeeForm(PersonBase person, string workShopTitle)
        {
            InitializeComponent();
            _workshops = new[] { workShopTitle };
            PrepareEmployeeElements();

            addPersonButton.Enabled = false;
            SetInputsToCurrentUser(person);
        }

        private void SetInputsToCurrentUser(PersonBase person)
        {
            nameTitleBox.Text = person.Name;
            if(person is Employee)
            {
                var employee = (Employee)person;
                PrepareEmployeeElements();
                higherTechnicalEducationRadioButton.Checked = employee.HigherTechnicalEducation;
            }
            else if(person is Master)
            {
                var master = (Master)person;
                PrepareMasterElements();
                certificatesnumericUpDown.Value = master.CountOfCertificates;
            }
        }

        private void PrepareEmployeeElements()
        {
            certificatesnumericUpDown.Enabled = false;
            salaryNumericUpDown.Value = 15000;
            higherTechnicalEducationRadioButton.Enabled = true;
            noHigherTechnicalEducationRadioButton.Enabled = true;
        }
        private void PrepareMasterElements()
        {
            certificatesnumericUpDown.Enabled = true;
            salaryNumericUpDown.Value = 40000;
            higherTechnicalEducationRadioButton.Enabled = false;
            noHigherTechnicalEducationRadioButton.Enabled = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            workshopsCompoBox.DataSource = _workshops;

            salaryNumericUpDown.Value = 150000;
        }

        private void employeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _isEmployee = !_isEmployee;

            PrepareEmployeeElements();
        }

        private void masterRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            PrepareMasterElements();
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            try
            {
                bool operationStatus = false;
                if (_isEmployee == true)
                {
                    var higherTechnicalEducation = higherTechnicalEducationRadioButton.Checked;
                    var employee = new Employee(nameTitleBox.Text, workshopsCompoBox.Text,
                        higherTechnicalEducation);

                    operationStatus = _factory.HireEmployee(employee);
                }
                else
                {
                    var master = new Master(nameTitleBox.Text, workshopsCompoBox.Text, 
                        (int)certificatesnumericUpDown.Value);
                    operationStatus = _factory.HireMaster(master);
                }

                if (operationStatus == false)
                {
                    MessageBox.Show($"Incorrect balance beetween employee and masters!",
                        "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Person: {nameTitleBox.Text} has been successfully added!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
