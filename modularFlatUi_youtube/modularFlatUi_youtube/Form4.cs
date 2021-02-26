using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modularFlatUi_youtube
{
    public partial class Form4 : Form
    {


        public static String userData; 

        public Form4()
        {
            InitializeComponent();

            //set data
            labelUserPassedData.Text = userData;

           

        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void labelUserPassedData_Click(object sender, EventArgs e)
        {

        }
    }
}
