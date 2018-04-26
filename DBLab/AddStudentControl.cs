using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;



namespace DBLabs
{
    public partial class AddStudentControl : UserControl
    {
        private DBConnection dbconn;

        public AddStudentControl()
        {
            /*
             * Constructor the control
             * 
             * You DONT need to edit this constructor.
             * 
             */
            InitializeComponent();
        }

        public void AddStudentControlSettings(ref DBConnection dbconn)
        {
            /*
             * Since UserControls cannot take arguments to the constructor 
             * this function is called after the constructor to perform this.
             * 
             * You DONT need to edit this function.
             * 
             */
            this.dbconn = dbconn; 
        }

        private void LoadAddStudentControl(object sender, EventArgs e)
        {
            /*
             * This function contains all code that needs to be executed when the control is first loaded
             * 
             * You need to edit this code. 
             * Example: Population of Comboboxes and gridviews etc.
             * 
             */
        }
        public void ResetAddStudentControl()
        {
            /*
             * This function contains all code that needs to be executed when the control is reloaded
             * 
             * You need to edit this code. 
             * Example: Emptying textboxes and gridviews
             * 
             */
        }

        private void AddStudentGB_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "Data Source = www4.idt.mdh.se;" + "Database=" + username + "_db;" + "User ID=" + username + ";" + "Password=" + password;
            string Query = "SELECT * FROM Students.StudentID;";




        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillBy(this.dataSet1.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
