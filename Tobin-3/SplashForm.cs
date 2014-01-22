/* Project:     Project 3
 * Programmer:  Chris Tobin
 * Date:        4.5.2010
 * Description: Order form for Excelsior Automobile Company
 *
 * Class:       SplashForm
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Close the splash form
            this.Close();
        }
    }
}
