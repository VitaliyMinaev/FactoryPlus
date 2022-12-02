using FactoryForm.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using FactoryForm.Parsers;
using FactoryForm.Helpers;
using static System.Windows.Forms.ListView;
using FactoryForm.Domain.Abstract;

namespace FactoryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInputs()
        {
            TitleTextBox.Text = String.Empty;
            CountOfWorkshopsTextBox.Text = String.Empty;
            CountOfEmployeeTextBox.Text = String.Empty;
            CountOfMasterTextBox.Text = String.Empty;
            EmployeeSalaryTextBox.Text = String.Empty;
            MasterSalaryTextBox.Text = String.Empty;
            ProfitFromEmployeeTextBox.Text = String.Empty;
            ProfitFromMasterTextBox.Text = String.Empty;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var factory = new Factory(TitleTextBox.Text,
                    MoneyParser.ParseStringToCents(EmployeeSalaryTextBox.Text),
                    MoneyParser.ParseStringToCents(MasterSalaryTextBox.Text),
                    MoneyParser.ParseStringToCents(ProfitFromEmployeeTextBox.Text),
                    MoneyParser.ParseStringToCents(ProfitFromMasterTextBox.Text)
               );

               AddFactoryToListView(factory);
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.Message, "Error");

                CountOfEmployeeTextBox.BackColor = System.Drawing.Color.Red;
                CountOfMasterTextBox.BackColor = System.Drawing.Color.Red;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void AddFactoryToListView(Factory factory)
        {
            var listViewFactory = new ListViewItem(factory.Title);
            listViewFactory.Tag = factory;

            factoriesListView.Items.Add(listViewFactory);
        }

        private void factoriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Factory factory = GetSelectedFactory();
            if (factory == null)
            {
                ClearInputs();
                return;
            }

            TitleTextBox.Text = factory.Title;
            CountOfWorkshopsTextBox.Text = factory.CountOfWorkshop.ToString();
            CountOfEmployeeTextBox.Text = factory.CountOfEmployee.ToString();
            CountOfMasterTextBox.Text = factory.CountOfMasters.ToString();
            EmployeeSalaryTextBox.Text = factory.EmployeeSalary.ParseCentsToString();
            MasterSalaryTextBox.Text = factory.MasterSalary.ParseCentsToString();
            ProfitFromEmployeeTextBox.Text = factory.ProfitFromEmployee.ParseCentsToString();
            ProfitFromMasterTextBox.Text = factory.ProfitFromMaster.ParseCentsToString();

            personsCompoBox.DataSource = factory.GetPersons()
                .Select(x => x.Name).ToArray();
        }

        private async void Load_Click(object sender, EventArgs e)
        {
            List<Factory> factories = await DeserializeAsync();

            foreach (Factory item in factories)
            {
                ListViewItem lvi = new ListViewItem(item.Title);
                lvi.Tag = item;

                factoriesListView.Items.Add(lvi);
            }
        }
        private async Task<List<Factory>> DeserializeAsync()
        {
            using (FileStream stream = new FileStream("FactoriesData.json", FileMode.OpenOrCreate))
            {
                List<Factory> factories = await JsonSerializer.DeserializeAsync<List<Factory>>(stream);

                return factories;
            }
        }

        private async void Unload_Click(object sender, EventArgs e)
        {
            var factories = new List<Factory>();

            foreach (ListViewItem item in factoriesListView.Items)
            {
                if (item != null)
                    factories.Add((Factory)item.Tag);
            }

            await SerializeAsync(factories);
        }
        private async Task SerializeAsync(List<Factory> factories)
        {
            using (var stream = new FileStream("FactoriesData.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Factory>>(stream, factories);
            }
        }

        private void FireEmployeeButton_Click(object sender, EventArgs e)
        {
            if (factoriesListView.SelectedItems.Count == 0)
                return;

            var factory = (Factory)factoriesListView.SelectedItems[0].Tag;
            bool status = factory.FireEmployee();
            if (status == false)
            {
                MessageBox.Show("Inappropriate balance between employee and masters", "Error");
            }
            else
            {
                CountOfMasterTextBox.Text = factory.CountOfMasters.ToString();
            }
            CountOfEmployeeTextBox.Text = factory.CountOfEmployee.ToString();
        }

        private void FireMasterButton_Click(object sender, EventArgs e)
        {
            if (factoriesListView.SelectedItems.Count == 0)
                return;

            var factory = (Factory)factoriesListView.SelectedItems[0].Tag;
            bool status = factory.FireMaster();
            if (status == false)
            {
                MessageBox.Show("Inappropriate balance between employee and masters", "Error");
            }
            else
            {
                CountOfMasterTextBox.Text = factory.CountOfMasters.ToString();
            }
            CountOfMasterTextBox.Text = factory.CountOfMasters.ToString();
        }

        /* Validation methods */
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if(textBox.Text.Any(x => char.IsLetter(x)) == true)
            {
                textBox.BackColor = System.Drawing.Color.Red;
                AddBtn.Enabled = false;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
                AddBtn.Enabled = true;
            }
        }
        private void TextBoxes_Money_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            if (text.ValidateString() != true)
            {
                textBox.BackColor = System.Drawing.Color.Red;
                AddBtn.Enabled = false;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
                AddBtn.Enabled = true;
            }
        }

        private void CompareFactoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<Factory, Factory> factories = GetFactoriesByTitleFromListView
                (ComparedFactory1TextBox.Text, ComparedFactory2TextBox.Text);

                Factory firstToCompare = factories.Item1, secondToCompare = factories.Item2;

                int compareResult = firstToCompare.CompareTo(secondToCompare);

                if (compareResult == 1)
                {
                    MessageBox.Show($"{firstToCompare.Title} are greater then {secondToCompare.Title}"
                        , "Result of compare operation");
                }
                else if (compareResult == -1)
                {
                    MessageBox.Show($"{secondToCompare.Title} are greater then {firstToCompare.Title}"
                        , "Result of compare operation");
                }
                else if (compareResult == 0)
                {
                    MessageBox.Show($"{secondToCompare.Title} are equal to {firstToCompare.Title}"
                        , "Result of compare operation");
                }
            }
            catch (InvalidDataException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private Tuple<Factory, Factory> GetFactoriesByTitleFromListView(string factoryTitle1, string factoryTitle2)
        {
            ListViewItemCollection factories = factoriesListView.Items;
            Factory firstFactory = null, secondFactory = null;

            foreach (ListViewItem item in factories)
            {
                var factory = item.Tag as Factory;
                if (factory.Title == factoryTitle1)
                {
                    firstFactory = factory;
                }
                else if (factory.Title == factoryTitle2)
                {
                    secondFactory = factory;
                }
            }

            if (firstFactory == null)
            {
                string exceptionMessage = $"There is not factory with title: {factoryTitle1}";
                throw new InvalidDataException(exceptionMessage);
            }
            else if (secondFactory == null)
            {
                string exceptionMessage = $"There is not factory with title: {factoryTitle2}";
                throw new InvalidDataException(exceptionMessage);
            }

            return new Tuple<Factory, Factory>(firstFactory, secondFactory);
        }

        private void CalculateProfitButton_Click(object sender, EventArgs e)
        {
            string factoryTitle = ProfitFactoryTextBox.Text;
            
            ListViewItemCollection factories = factoriesListView.Items;
            Factory profitFactory = null;

            foreach (ListViewItem item in factories)
            {
                var factory = item.Tag as Factory;
                if (factory.Title == factoryTitle)
                {
                    profitFactory = factory;
                }
            }

            if (profitFactory == null)
            {
                string errorMessage = $"There is not factory with title: {factoryTitle}";
                MessageBox.Show(errorMessage, "Error");
            }

            int investedMoney = MoneyParser.ParseStringToCents(ProfitSumTextBox.Text);
            double profit = profitFactory.CalculateProfit(investedMoney) / 100;

            MessageBox.Show($"Your profit for 1 month: {profit}$", "Profit");
        }

        private void workshopFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var workshopForm = new WorkshopForm();
            workshopForm.Show();
        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var workshopForm = new EmployeeForm();
            workshopForm.Show();
        }

        private void hirePersonButton_Click(object sender, EventArgs e)
        {
            if (factoriesListView.SelectedItems.Count == 0)
                return;

            var factory = (Factory)factoriesListView.SelectedItems[0].Tag;
            if (factory == null)
                return;

            var employeeForm = new EmployeeForm(factory,
                new[] { "work 1", "work 2" });
            
            employeeForm.ShowDialog();
            UpdateInputs();
        }

        private Factory GetSelectedFactory()
        {
            if (factoriesListView.SelectedItems.Count == 0)
               return null;

            var factory = (Factory)factoriesListView.SelectedItems[0].Tag;

            if (factory == null)
                return null;

            return factory;
        }

        private void firePersonButton_Click(object sender, EventArgs e)
        {
            Factory factory = GetSelectedFactory();
            if (factory == null)
                return;

            string nameOfPersonToDelete = (string)personsCompoBox.SelectedItem;

            if (String.IsNullOrEmpty(nameOfPersonToDelete))
                MessageBox.Show("Can not delete user with empty name"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            bool status = factory.FirePerson(nameOfPersonToDelete);
            if(status == true)
            {
                MessageBox.Show("Person was successfully deleted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateInputs();
            }
            else
            {
                MessageBox.Show("Can not delete person!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInputs()
        {
            if (factoriesListView.SelectedItems.Count > 0)
            {
                var factory = (Factory)factoriesListView.SelectedItems[0].Tag;

                if (factory != null)
                {
                    TitleTextBox.Text = factory.Title;
                    CountOfWorkshopsTextBox.Text = factory.CountOfWorkshop.ToString();
                    CountOfEmployeeTextBox.Text = factory.CountOfEmployee.ToString();
                    CountOfMasterTextBox.Text = factory.CountOfMasters.ToString();
                    EmployeeSalaryTextBox.Text = factory.EmployeeSalary.ParseCentsToString();
                    MasterSalaryTextBox.Text = factory.MasterSalary.ParseCentsToString();
                    ProfitFromEmployeeTextBox.Text = factory.ProfitFromEmployee.ParseCentsToString();
                    ProfitFromMasterTextBox.Text = factory.ProfitFromMaster.ParseCentsToString();

                    personsCompoBox.DataSource = factory.GetPersons()
                        .Select(x => x.Name).ToArray();
                }
            }
        }

        private void openPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                Factory factory = GetSelectedFactory();
                if (factory == null)
                    return;

                string nameOfPersonToDelete = (string)personsCompoBox.SelectedItem; if (String.IsNullOrEmpty(nameOfPersonToDelete))
                    MessageBox.Show("Can not delete user with empty name"
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                PersonBase person = factory.GetPersonByName(nameOfPersonToDelete);

                var employeeForm = new EmployeeForm(person, "123");

                employeeForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}