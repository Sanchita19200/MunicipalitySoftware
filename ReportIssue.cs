using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10097535APPR
{
    public partial class ReportIssue : Form
    {
        public ReportIssue()
        {
            InitializeComponent();
            LoadCategories();
            ConfigureComboBoxSearch();
        }

        // Method to load categories into comboBox2
        private void LoadCategories()
        {
            // Adding municipal service categories
            comboBox2.Items.AddRange(new string[]
            {
                "Roads and Transport",
                "Water and Sanitation",
                "Waste Management",
                "Electricity and Energy",
                "Public Safety and Security",
                "Environmental and Parks",
                "Housing and Community Services",
                "Health and Social Services",
                "Public Infrastructure",
                "Licensing and Permits",
                "Municipal Billing and Accounts",
                "Local Economic Development"
            });
        }

        // Method to enable search functionality in comboBox2
        private void ConfigureComboBoxSearch()
        {
            // Set AutoComplete mode
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any actions when category selection changes
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
