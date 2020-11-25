using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceReference3;

namespace test_clientapp
{
    public partial class Form1 : Form
    {
        //create BMI int for holding result
        int BMI;
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            //create a new client
            BMICalcClient client = new BMICalcClient();
            //set height and weight as doubles for calculatebmi method
            double Height = double.Parse(tbHeight.Text);
            double Weight = double.Parse(tbWeight.Text);
           

            //if user is a female, call calculatebmi method as such
            if (rbFemale.Checked == true)
            {
                lbResultDescription.Text = client.BMIResultAsync(Height, Weight, "Female").Result;
            } else
            {
               lbResultDescription.Text = client.BMIResultAsync(Height, Weight, "Male").Result;
            }

            
            client.CloseAsync();
        }

    }
}
