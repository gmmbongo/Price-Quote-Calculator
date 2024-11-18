// Program 1
// CIS 199-01
// Due Date: 9/26/2024
// By: Glodi Mbongo

/*This Program serve as Price Quote Calculator designed for Smith's Auto Repairs. The program collects the client’s name, car type, work hours,
parts cost, staff assigned, and senior citizen status (via a TextBox where the user enters 1 for Yes or 0 for No).
It then calculates the total repair cost, applying a discount if the client is a senior citizen, and displays the result.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getQuoteBtn_Click(object sender, EventArgs e)
        {
            // Declare constants for the fixed values
            const double consultationFee = 100;  //Fixed consultation fee
            const double laborChargeHour = 75;  //Fixed labor charge per hour
            const double seniorDiscount = 0.10; // 105 Discount for senior citizens

            // declare variable
            int workHours;   // Variable of work Work Hours
            double partsCost;   // Variable of Parts Cost
            int StaffAssigned;    // Variable of Staff Assigned 
            int isSeniorCitizen;   // Variable of Senior Citizen
            double totalCost;      // Variables total Cost

            // Get inputs from the text boxes
            // Collecting the client's name and car type as strings
            string clientName = txtClientName.Text;  // Client's name
            string carType = txtCarType.Text;        // Type of car 

            // Parsing numerical inputs for work hours, parts cost, and staff assigned
            workHours = int.Parse(txtWorkHours.Text);  // Number of hours of work
            partsCost = double.Parse(txtPartsCost.Text);   // Cost of the parts used
            StaffAssigned = int.Parse(txtStaffAssigned.Text);   // Number of staff working on the job


            isSeniorCitizen = int.Parse(txtSeniorCitizen.Text); // Senior citizen status is entered as 1 (Yes) or 0 (No) in the text box

            // Calculate total cost before applying any discount
            totalCost = consultationFee + (laborChargeHour * workHours * StaffAssigned) + partsCost;

            // Apply the senior citizen discount if the client is a senior citizen
            if (isSeniorCitizen == 1)
            {
                // Subtract 10% from total if applicable
                totalCost -= totalCost * seniorDiscount;
            }
            // Display the calculated total cost in the label, formatted to 2 decimal places
            lblTotalCost.Text = $"${totalCost:F2}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkHours_TextChanged(object sender, EventArgs e)
        {
            // This methode handles errors when the user typethe wrong format in the Work Hour textbox
            try
            {
                int workHours = int.Parse(txtWorkHours.Text);
            }
            catch
            {
                // Message when the user types the wrong format and clear the input field
                MessageBox.Show("Error: Please Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWorkHours.Text = "";
            }
        }

        private void txtPartsCost_TextChanged(object sender, EventArgs e)
        {
            // This methode handles errors when the user typethe wrong format in the Part Cost textbox
            try
            {
                int partsCost = int.Parse(txtPartsCost.Text);
            }
            catch
            {
                // Message when the user types the wrong format and clear the input field
                MessageBox.Show("Error: Please Enter a valid number of Cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartsCost.Text = "";
            }
        }

        private void txtStaffAssigned_TextChanged(object sender, EventArgs e)
        {
            {
                // This methode handles errors when the user typethe wrong format in the Staff Assigned textbox
                try
                {
                    int staffAssigned = int.Parse(txtStaffAssigned.Text);
                }
                catch
                {
                    // Message when the user types the wrong format and clear the input field
                    MessageBox.Show("Error: Please Enter a valid number of Staff member assigned to the job .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStaffAssigned.Text = "";
                }
            }
        }

    }
}
