using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






/// <summary>
///  NOTE:
///     Created by Aidan Kelly 
///     Following Youtube Video 
///         https://www.youtube.com/watch?v=JP5rgXO_5Sk
///         By RJ Code Advance EN
/// </summary>
/// 


namespace modularFlatUi_youtube
{
    public partial class Form1 : Form
    {



        private Form activeForm = null;



        public Form1()
        {
            InitializeComponent();

            //hide sub menus / panels on init load
            hideAllSubPanels();


        }


        private void hideAllSubPanels()
        {
            panelAbout.Visible = false;
            panelContact.Visible = false;
            panelGallery.Visible = false;
            panelMainMenu.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            //hide any already open submenu's
            // quick n dirty hide everything (waste of processing power be more efficient)
            hideAllSubPanels();

            subMenu.Visible = true;
        }




        //BUTTONS --------------------------

        //TODO Main menu button design_name_attribute didnt update for method
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMainMenu);


            if(activeForm != null)
            {
                //resets the active form to empty
                closeActiveForm();
                // just to be sure reset activeForm to null
                activeForm = null;
            }
            


        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAbout);

            showChildFormUsingClose(new Form2());

        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGallery);
            showChildFormUsingClose(new Form3());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            showSubMenu(panelContact);
        }





        // For main menu button
        private void closeActiveForm()
        {
            //what ever form that is currently being shown close it.
            activeForm.Close();
        }






        //switch child form method 
        // note child forms should have the same width 
        // height ratio as the parent panel.

        private void showChildFormUsingClose(Form childForm)
        {
            //check if their is a form their already
            if(activeForm != null)
            {
                //close the currently open form
                   // - remeber with forms you can hide / show aswell
                activeForm.Close();
            }

            //set our form to new active form
            activeForm = childForm;

            //indicate the child form is not of the top level
            //     - this makes it behave more like an control (a control is another word for UI component)
            childForm.TopLevel = false;

            //Remove border of the form 
            // - i assume this is the window_border 
            childForm.FormBorderStyle = FormBorderStyle.None;

            // set dock property to fill
            // makes it so that it fills the whole pannel (much like other controls and components. text,buttons,etc)
            childForm.Dock = DockStyle.Fill;

            //add form to the list of controls within the panel on our main form
            // (the panel in which we intend to put the form)
            panelChildForm.Controls.Add(childForm);

            //associate the form with the container panel
            panelChildForm.Tag = childForm;



            //if you put a logo within the container panel 
            // ensure you set your form to show up infront of that logo
            childForm.BringToFront();


            //show form (as per usual)
            childForm.Show();





        }







       











    }
}
