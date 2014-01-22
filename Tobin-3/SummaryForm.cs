/* Project:     Project 3
 * Programmer:  Chris Tobin
 * Date:        4.5.2010
 * Description: Order form for Excelsior Automobile Company
 *
 * Class:       SummaryForm
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
    public partial class SummaryForm : Form
    {
        // Declare class-level variables
        private string expeditedShippingString, carModelString, carStyleString, 
            carColorString, carOptionsString;
        

        public SummaryForm()
        {
            InitializeComponent();
        }

        public string ExpeditedShipping
        {
            set
            {
                expeditedShippingString = value;
            }
        }

        public string CarModel
        {
            set
            {
                carModelString = value;
            }
        }

        public string CarStyle
        {
            set
            {
                carStyleString = value;
            }
        }

        public string CarColor
        {
            set
            {
                carColorString = value;
            }
        }

        public string CarOptions
        {
            set
            {
                carOptionsString = value;
            }
        }

        private void SummaryForm_Activated(object sender, EventArgs e)
        {
           // Display the strings in their appropriate labels
            expeditedShippingLabel.Text = expeditedShippingString;
            carModelLabel.Text = carModelString;
            carStyleLable.Text = carStyleString;
            carColorLabel.Text = carColorString;
            
            // Determine if options were selected
            if (carOptionsString == "")
            {
                carOptionsLabel.Text = "None Selected";

            }
            else
            {
                carOptionsLabel.Text = carOptionsString;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Display the print preview dialog box
            printPreviewDialog1.Document = printOrderSummaryDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void printOrderSummaryDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set the printing properties
            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float verticalPrintPositionFloat = e.MarginBounds.Top;
            float horizontalPrintPositionFloat = e.MarginBounds.Left;
            float lineHeightfloat = printFont.GetHeight();
            string printLineString;

            // Display the heading
            printLineString = "Excelsior Factory Order Summary";
            e.Graphics.DrawString(printLineString, headingFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;
            
            // Display the current date in short format
            printLineString = DateTime.Now.ToShortDateString();
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat * 2;

            // Display whether the order has expedited shipping
            printLineString = "Expedited Shipping: " + expeditedShippingString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the car model for the order
            printLineString = "Car Model: " + carModelString;   
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;
            
            // Display the car style for the order
            printLineString = "Car Style: " + carStyleString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the car color for the order 
            printLineString = "Car Color: " + carColorString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;
            
            // Display "Car Options"
            printLineString = "Car Options: ";
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;
        
            // Determine if options were selected
            if (carOptionsString != "")
            {
                // Display the selected car options for the order
                printLineString = carOptionsString;
                e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                    150, verticalPrintPositionFloat);
                verticalPrintPositionFloat += lineHeightfloat;
            }

            else
            {
                // Display "None Selected" if user does not want options
                printLineString = "None Selected";
                e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                    150, verticalPrintPositionFloat);
                verticalPrintPositionFloat += lineHeightfloat;
            }
        }
    }
}
