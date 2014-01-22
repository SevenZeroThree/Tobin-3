/* Project:     Project 3
 * Programmer:  Chris Tobin
 * Date:        4.5.2010
 * Description: Order form for Excelsior Automobile Company
 *
 * Class:       Excelsior Order Form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tobin_3
{
    public partial class ExcelsiorOrderForm : Form
    {
        public ExcelsiorOrderForm()
        {
            InitializeComponent();
        }

        private void ExcelsiorOrderForm_Load(object sender, EventArgs e)
        {
            // Add car models to the car models combo box at program startup
            carModelComboBox.Items.Add("Aristocrat");
            carModelComboBox.Items.Add("Conquistador");
            carModelComboBox.Items.Add("Invincible");
            carModelComboBox.Items.Add("Mammoth");
            carModelComboBox.Items.Add("Supernova");
            
            // Add car colors to the car colors combo box at program startup
            carColorComboBox.Items.Add("Black");
            carColorComboBox.Items.Add("Forrest Green");
            carColorComboBox.Items.Add("Gold");
            carColorComboBox.Items.Add("Midnight Blue");
            carColorComboBox.Items.Add("Red");
            carColorComboBox.Items.Add("Royal Blue");
            carColorComboBox.Items.Add("Silver");
            carColorComboBox.Items.Add("White");      
            
            // Add car options to the car options list box at program startup
            carOptionsListBox.Items.Add("Satellite Radio");
            carOptionsListBox.Items.Add("Blu-Ray Disc System");
            carOptionsListBox.Items.Add("Wine Refrigerator");
            carOptionsListBox.Items.Add("Massaging Seats");
            carOptionsListBox.Items.Add("Alligator Skin Trim");
            carOptionsListBox.Items.Add("Ultra Anti-Theft System");
            carOptionsListBox.Items.Add("360 Camera System");

            // Set form defaults
            carModelComboBox.SelectedItem = "Aristocrat";
            carColorComboBox.SelectedItem = ("White");
            hardTopRadioButton.Checked = true;
        }
        
        private void summarizeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare an instance of the summaryform class
            SummaryForm aSummaryForm = new SummaryForm();

            // Determine if expedited shipping is desired and send it to the summary form
            if (expeditedShippingCheckBox.Checked)
            {
                aSummaryForm.ExpeditedShipping = "Yes";
            }
            else
            {
                aSummaryForm.ExpeditedShipping = "No";
            }

            // Send the car model to the summary form
            aSummaryForm.CarModel = carModelComboBox.SelectedItem.ToString();

            // Determine the car style and send it to the summary form
            if (hardTopRadioButton.Checked)
            {
                aSummaryForm.CarStyle = "Hard Top";
            }
            else
            {
                aSummaryForm.CarStyle = "Convertible";
            }

            // Loop to determine what options were selected and send them to the summary form
            string listOfOptionsString = "";
            for (int countInteger = 0; countInteger < carOptionsListBox.Items.Count; countInteger++)
            {
                if (carOptionsListBox.GetSelected(countInteger))
                {
                    listOfOptionsString = listOfOptionsString + 
                        carOptionsListBox.Items[countInteger].ToString() + "\n";
                }
            }
            aSummaryForm.CarOptions = listOfOptionsString;

            // Determine the color
            
            // Declare local variables
            int colorIndexInteger = 0;
            bool colorFoundBoolean = false;

            // Handle a blank car color 
            if (carColorComboBox.Text != "")
            {
                // Loop to be sure color selected has been entered in the list
                while (colorIndexInteger < carColorComboBox.Items.Count && !colorFoundBoolean)
                {
                    if (carColorComboBox.Items[colorIndexInteger].ToString().ToUpper()
                        == carColorComboBox.Text.ToUpper())
                    {
                        colorFoundBoolean = true;
                        aSummaryForm.CarColor = carColorComboBox.SelectedItem.ToString();
                        
                        // Display the summary form
                        aSummaryForm.ShowDialog();
                    }
                    colorIndexInteger++;
                }
                if (!colorFoundBoolean)
                {
                    MessageBox.Show("Color not found. Please add the custom color before displaying the order summary.",
                        "Color not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carColorComboBox.Focus();
                }              
            }
            else
            {
                MessageBox.Show("Please select a car color.", "No color selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                carColorComboBox.Focus();
            }
        }

        private void addColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add a custom color to the list if it is not already there
            
            // Declare local variables
            int colorIndexInteger = 0;
            bool colorFoundBoolean = false;

            // Loop to test for duplicates
            if (carColorComboBox.Text != "")
            {
                while (colorIndexInteger < carColorComboBox.Items.Count && !colorFoundBoolean)
                {
                    if (carColorComboBox.Items[colorIndexInteger].ToString().ToUpper()
                        == carColorComboBox.Text.ToUpper())
                    {
                        string messageString;
                        messageString = "Duplicate color found. Please select the color from the list or add a color that is not present.";
                        MessageBox.Show(messageString, "Duplicate color found",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        colorFoundBoolean = true;
                        carColorComboBox.Focus();
                    }
                    colorIndexInteger++;
                }
                if (!colorFoundBoolean)
                {
                    // Add the color to the list
                    carColorComboBox.Items.Add(carColorComboBox.Text);
                    carColorComboBox.Text = "";
                    carColorComboBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a color to add.", "No color has been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                carColorComboBox.Focus();
            }
        }

        private void removeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove a user-selected color from the list
            
            // Declare local variables
            int colorIndexInteger = 0;
            bool colorFoundBoolean = true;

            // Loop to test for duplicates
            if (carColorComboBox.Text != "")
            {
                while (colorIndexInteger < carColorComboBox.Items.Count && !colorFoundBoolean)
                {
                    if (carColorComboBox.Items[colorIndexInteger].ToString().ToUpper()
                        == carColorComboBox.Text.ToUpper())
                    {
                        string messageString;
                        messageString = "Color not found. Please select a color from the list to remove.";
                        MessageBox.Show(messageString, "No color found",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        colorFoundBoolean = false;
                        carColorComboBox.Focus();
                    }
                    colorIndexInteger++;
                }
                if (colorFoundBoolean)
                {
                    // Remove the color from the list
                    carColorComboBox.Items.Remove(carColorComboBox.Text);
                    carColorComboBox.Text = "";
                    carColorComboBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a color to remove.", "No color found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare an instance of the aboutbox1 class
            AboutBox1 aboutForm = new AboutBox1();
            
            // Display the about form
            aboutForm.ShowDialog();
        }
        
        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the form
            expeditedShippingCheckBox.Checked = false;
            carModelComboBox.SelectedItem = ("Aristocrat");
            carColorComboBox.SelectedItem = ("White");
            hardTopRadioButton.Checked = true;
            carOptionsListBox.SelectedIndex = -1;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // End the program
            this.Close();
        }
    }
}
