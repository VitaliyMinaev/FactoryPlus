using FactoryForm.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryForm
{
    public partial class EmployeeForm : Form
    {
        private Factory _factory;
        private string[] _workshops = { "workshop 1", "workshop 2", "workshop 3" };
        private bool _isEmployee = true;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(Factory currentFactory, string[] workShops)
        {
            InitializeComponent();
            _factory = currentFactory;
            _workshops = workShops;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            workshopsCompoBox.DataSource = _workshops;

            salaryNumericUpDown.Value = 150000;
        }

        private void employeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _isEmployee = !_isEmployee;

            higherEducationPanel.Visible = true;
            salaryNumericUpDown.Value = 15000;
        }

        private void masterRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            higherEducationPanel.Visible = false;
            salaryNumericUpDown.Value = 40000;
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isEmployee == true)
                {
                    var higherTechnicalEducation = higherTechnicalEducationRadioButton.Checked;
                    var employee = new Employee(nameTitleBox.Text, workshopsCompoBox.Text,
                        higherTechnicalEducation);

                    _factory.HireEmployee(employee);
                }
                else
                {
                    var master = new Master(nameTitleBox.Text, workshopsCompoBox.Text, true);
                    _factory.HireMaster(master);
                }

                MessageBox.Show($"Person: {nameTitleBox.Text} has been successfully added!", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}
