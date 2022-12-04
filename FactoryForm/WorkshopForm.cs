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
    public partial class WorkshopForm : Form
    {
        private List<Workshop> _workshops;
        private Factory _factory;
        public WorkshopForm()
        {
            InitializeComponent();
        }
        public WorkshopForm(Factory currentFactory, IEnumerable<Workshop> workshops)
        {
            InitializeComponent();
            _workshops = workshops.ToList();
            _factory = currentFactory;
        }

        private void WorkshopForm_Load(object sender, EventArgs e)
        {
            var lvi = new ListViewItem();
            foreach (var item in _workshops)
            {
                AddWorkshopToListView(item);
            }
        }

        private void AddWorkshopToListView(Workshop workshop)
        {
            var listViewFactory = new ListViewItem(workshop.WorkShopId);
            listViewFactory.Tag = workshop;

            workshopsListView.Items.Add(listViewFactory);
        }
        private Workshop GetSelectedWorkshop()
        {
            if (workshopsListView.SelectedItems.Count == 0)
                return null;

            var workshop = (Workshop)workshopsListView.SelectedItems[0].Tag;

            return workshop;
        }

        private void workshopsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Workshop workshop = GetSelectedWorkshop();
            if (workshop == null)
            {
                return;
            }

            idTextBox.Text = workshop.WorkShopId;
            countOfWorkSpaceTextBox.Text = workshop.CountOfWorkers.ToString();
            maxCapacityTextBox.Text = workshop.MaxCapacity.ToString();
            maxMasterCapacityTextBox.Text = workshop.MaxCountOfMasters.ToString();
            maxEmployeeCapacityTextBox.Text = workshop.MaxCountOfEmployee.ToString();
            currentCountOfMastersTextBox.Text = workshop.CurrentMastersCount.ToString();
            currentCountOfEmployeeTextBox.Text = workshop.CurrentEmployeeCount.ToString();
            currentSelfCostOfDetailTextBox.Text = workshop.CurrentDetailSelfCost.ToString();
            countOfDetailtsPerMasterTextBox.Text = workshop.MaxCountOfDetailsPerMaster.ToString();
            countOfDetailtsPerEmployeeTextBox.Text = workshop.MaxCountOfDetailsPerEmployee.ToString();
            selfcostOfDetailTextBox.Text = workshop.DetailSelfCost.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var workshop = new Workshop(int.Parse(countOfWorkSpaceTextBox.Text),
                    int.Parse(maxCapacityTextBox.Text),
                    int.Parse(maxMasterCapacityTextBox.Text),
                    int.Parse(maxEmployeeCapacityTextBox.Text),
                    int.Parse(currentCountOfMastersTextBox.Text),
                    int.Parse(currentCountOfEmployeeTextBox.Text),
                    int.Parse(currentSelfCostOfDetailTextBox.Text),
                    int.Parse(countOfDetailtsPerMasterTextBox.Text),
                    int.Parse(countOfDetailtsPerEmployeeTextBox.Text),
                    int.Parse(selfcostOfDetailTextBox.Text));

                AddWorkshopToListView(workshop);
                _factory.AddWorkshop(workshop);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var workshop = GetSelectedWorkshop();
            if (workshop == null)
                return;

            var newList = new List<Workshop>();
            foreach (ListViewItem item in workshopsListView.Items)
            {
                if (item.Text != workshop.WorkShopId)
                {
                    newList.Add((Workshop)item.Tag);
                }
            }

            workshopsListView.Clear();
            foreach (var item in newList)
            {
                AddWorkshopToListView(item);
            }

            _factory.RemoveWorkshop(workshop);
        }
    }
}
