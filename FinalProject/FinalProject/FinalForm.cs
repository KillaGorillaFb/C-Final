using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FinalProject
{
    /// <summary>
    /// Developer:  Frankie Barrios
    /// Date:       5/6/2018
    /// Purpose:    Final project - Employee Form
    /// </summary>
    public partial class FinalForm : Form
    {
        string fileName;
        private int salary;

        public FinalForm()
        {
            InitializeComponent();
        }


        private void FinalForm_Load(object sender, EventArgs e)
        {
            mnuItemSaveAs.Enabled = false;
        }//End of Form Load
        
        //Menu Item Open Click Event
        private void mnuItemOpen_Click(object sender, EventArgs e)
        {
            string inputRecord;
            string[] fields;

            try
            {
                openFileDialog1.FileName = fileName;
                openFileDialog1.ShowDialog();
                fileName = openFileDialog1.FileName;
                StreamReader inFile = new StreamReader(fileName);
                inputRecord = inFile.ReadLine();
                while (inputRecord != null)
                {
                    fields = inputRecord.Split(',');
                    EmployeeClass aEmployee = new EmployeeClass();
                    aEmployee.LastName = fields[0];
                    aEmployee.FirstName = fields[1];
                    aEmployee.EmployeeType = fields[2];
                    aEmployee.Salary = Convert.ToInt32(fields[3]);
                    lstBxEmpData.Items.Add(aEmployee);                              
                    inputRecord = inFile.ReadLine();
                }//end of while
                inFile.Close();
                lblMessage.Text = "File Loaded";
                mnuItemSaveAs.Enabled = true;
            }//end of try
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
            }//end of catch 
        }//End of Open Click


        //Menu Item Save Click Event
        private void mnuItemSave_Click(object sender, EventArgs e)
        {

        }//End of Save Click


        //Menu Item Save As Click Event
        private void mnuItemSaveAs_Click(object sender, EventArgs e)
        {
            

        }//End of Save As Click


        //Menu Item Add New Click Event
        private void mnuItemAddNew_Click(object sender, EventArgs e)
        {

        }//End of Add New Click


        //Menu Item Properties Click Event
        private void mnuItemProperties_Click(object sender, EventArgs e)
        {

        }//End of Properties Click


        //Menu Item Delete Click Event
        private void mnuItemDelete_Click(object sender, EventArgs e)
        {

        }//End of Delete Click


        //Menu Item About Click Event
        private void mnuItemAbout_Click(object sender, EventArgs e)
        {

        }//End of About Click

        private void btnAddNewEmp_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            lblMessage.Text = "";            

            if (txtBxLastName.Text == "")
            {
                lblMessage.Text += "Last name is required!";
                isValid = false;
            }//Verifies last name is entered

            if (txtBxFirstName.Text == "")
            {
                lblMessage.Text += " First name is required!";
                isValid = false;
            }//Verifies first name is entered

            if (txtBxEmpType.Text == "")
            {
                lblMessage.Text += " Employee type is required!";
                isValid = false;
            }//Verifies Employee Type is entered
            
            if (txtBxSalary.Text == "")
            {
                lblMessage.Text += " Salary is required!";
                isValid = false;
            }//Verifies salary is entered
            else if (int.TryParse(txtBxSalary.Text, out salary) == false)
            {
                lblMessage.Text += "Salary must be numeric! ";
                isValid = false;
            }//Verified Salary is numeric

            if (isValid)
            {
                EmployeeClass aEmployee = new EmployeeClass(txtBxLastName.Text,
                                                         txtBxFirstName.Text,                                                    
                                                         txtBxEmpType.Text,
                                                         salary);
                lstBxEmpData.Items.Add(aEmployee);
                lblMessage.Text = "Employee has been added successfully!";
                ClearBox();
                mnuItemSaveAs.Enabled = true;
            } //end of isValid          
        }
        void ClearBox()
        {
            txtBxLastName.Clear();
            txtBxFirstName.Clear();
            txtBxEmpType.Clear();
            txtBxSalary.Clear();        
            txtBxLastName.Focus();
        }//End of clearbox

        private void btnDeleteEmpData_Click(object sender, EventArgs e)
        {
            lstBxEmpData.Items.Clear();
        }
    }//End of Class
}//End of Solution
