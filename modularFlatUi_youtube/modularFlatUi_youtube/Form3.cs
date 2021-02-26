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
    public partial class Form3 : Form
    {

        public static string f3userData;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnFormMoveData_Click(object sender, EventArgs e)
        {

            
            //getdata 
            String userNote = textBoxUserDataMultiLine.Text;

            if(userNote.Length <= 0)
            {
                //show a message window
                MessageBox.Show("Put some data in the text field");
            }
            else
            {
                //set data in form4
                Form4.userData = userNote;

                Form4 f4 = new Form4();

                //will open in a new window
                f4.Show();

            }
            
            
            

        }
    }
}
