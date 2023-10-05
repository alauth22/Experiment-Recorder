using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_A
{
    public partial class frmScienceExperiment : Form 
    {
        public frmScienceExperiment()
        {
            InitializeComponent();
        }

        //Instance of my Experiment class. 
        private Experiment exp; 
        //Declaring my new Dictionary to hold onto each new experiment.  
        private Dictionary<int, Experiment> experiments = new Dictionary<int, Experiment>(); 
        //Declare variable to hold the limit of experiments. 
        const int max_experiments = 50;


        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Methods that validate the total count, experiment number, and experiment description. 
            if (ValidateExpTotalCount() && ValidateExpNumber() && ValidateExpDescription())
            {
                //Handles the constructor AFTER data selection. 
                GetConstructor();
            }

        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            //This method handles validation of all the rest of the data the user will put in after 
            //clicking the "Create" Button. 
            ValidateResultData(exp);

            //This method will validate which color checkbox is checked, if any. 
            if (ValidateCheckedColor())
            {
                ResultColor resultcolor = GetCheckedColor();  //trying to do exp.ResultColor. 
                exp.FinalResultColor = resultcolor;
            }
            else
            {
                MessageBox.Show("Please select a valid color.");
            }


            //Calling the first methods for new data if User decides to change the previous data in "Create".
            if (ValidateExpNumber())
            {
                exp.ExpNum = int.Parse(txtExpNum.Text);
            }

            if (ValidateExpDescription())
            {
                exp.ExpDescription = txtExpDescr.Text;
            }

            exp.StudentName = txtStudentName.Text;
            
            //Message to user confirming the second step is done. 
            MessageBox.Show("This second part is finished!");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //Goal is to save everything to my dictionary.
            //We want the experiment number to be the key and the rest of the data to be the value. 
            //Calling the exp object variable.

            //I want the check if it is in the dictionary under the save button 
            //because here is where we actually put the info into memory. 
            
            //Check if number already exists in the dictionary. This method will give the user
            //the option to keep or override their experiment. 
            CheckDictionary();

            //If all data is completed...
            if (CheckExperimentComplete())
            {
                //if true, then add this class object exp to my dictionary. 
                //Recall the value in this dictionary is the entire information! NOT JUST THE DESCRIPTION!!
                //This will be handy when we have to display our results in the second form. 
                experiments[exp.ExpNum] = exp;
            }
            else
            {
                MessageBox.Show("All data must be completed in order to save.");
            }


            //Iterate through the dictionary and add to the listbox. 
            foreach (int num in experiments.Keys)
            {
                //Added to summary listbox only the experiment number and the experiment description. 
                lbxSummaries.Items.Add(num.ToString() + "\t" + experiments[num].ExpDescription);

            }
        }

        
        //Methods are BELOW!

        private bool ValidateExpTotalCount()
        {
            //First check if we are within the experiment number limit. Be inclusive of 50. 
            if (experiments.Count > 50)
            {
                MessageBox.Show("You have reached the maximum number of experiments allowed, which is 50.");
                //Disable the controls to prevent user from entering more experiments. 
                btnCreate.Enabled = false;
                btnSet.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }

            return true;
        }


        private bool ValidateExpNumber()
        {
            //Check if the experiment number of a number. 
            int experiment_number = 0;
            if (!int.TryParse(txtExpNum.Text, out experiment_number))
            {
                MessageBox.Show("You have placed an invalid value for the number of experiments. Please " +
                                "only type in integer values.");
                return false;
            }

            return true;
        }


        private bool ValidateExpDescription()
        {
            //Check if the experiment description is within 500 characters. 
            string experiment_description = "";
            //Grab the user's description. 
            experiment_description = txtExpDescr.Text;
            if (experiment_description.Length > 500)
            {
                MessageBox.Show("You have exceeded the number of characters allowed, which is 500.");
                return false;
            }
            
            return true;
           
        }


        private void GetConstructor()
        {
            //Declare my variables with user's input. 
            string studentname = txtStudentName.Text;
            string expNumber = txtExpNum.Text;
            string expDescription = txtExpDescr.Text;
            
            //Check if the experiment number is a number. 
            int experiment_number = int.Parse(expNumber);

            //If everything was known. 
            if (!string.IsNullOrWhiteSpace(studentname) && !string.IsNullOrWhiteSpace(expNumber) && !string.IsNullOrWhiteSpace(expDescription))
            {
                exp = new Experiment(experiment_number, studentname, expDescription);
            }
            //If Experiment number and experiment description are provided. 
            else if (!string.IsNullOrWhiteSpace(txtExpNum.Text) && !string.IsNullOrWhiteSpace(txtExpDescr.Text))
            {
                exp = new Experiment(experiment_number, expDescription);
            }
            //If only the student name is provided. 
            else if (!string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                exp = new Experiment(studentname);
            }
            else
            //If nothing was known. 
            {
                exp = new Experiment();
            }
            
            //User confirmation message. 
            MessageBox.Show("This first part is finished!");

        }

        private void ValidateResultData(Experiment exp)
        {
            //First let's validate the weight and volume. 
            double ResultWeight;
            if (double.TryParse(txtResultWeight.Text, out ResultWeight))
            {
                exp.ResultWeight = ResultWeight;
            }
            //If user leaves this textbox blank. 
            else if (txtResultWeight.Text == "")
            {
                exp.ResultWeight = ResultWeight;
            }
            else
            {
                MessageBox.Show("Please enter a valid value for Result Weight.");
            }
            
            double ResultVolume;
            if (double.TryParse(txtResultVolume.Text, out ResultVolume))
            {
                exp.ResultVolume = ResultVolume;
            }
            //If user leaves this textbox blank. 
            else if (txtResultVolume.Text == "")
            {
                exp.ResultVolume = ResultVolume;
            }
            else
            {
                MessageBox.Show("Please enter a valid value for Result Volume.");
            }

        }

        private bool ValidateCheckedColor()
        {
            //If any of these checkboxes are checked, return true. 
            if (chkCrimson.Checked || chkAzure.Checked || chkTaupe.Checked || chkMauve.Checked ||
                chkVermillion.Checked || chkChartreuse.Checked)
            {
                return true;
            }

            return false;
        }

        
        //This method will return the appropriate enum. 
        private ResultColor GetCheckedColor()
        {
            if (chkCrimson.Checked)
            {
                return ResultColor.Crimson;
            }
            else if (chkAzure.Checked)
            {
                return ResultColor.Azure;
            }
            else if (chkTaupe.Checked)
            {
                return ResultColor.Taupe;
            }
            else if (chkMauve.Checked)
            {
                return ResultColor.Mauve;
            }
            else if (chkVermillion.Checked)
            {
                return ResultColor.Vermillion;
            }
            else if (chkChartreuse.Checked)
            {
                return ResultColor.Chartreuse;
            }
            else
            //I made this my default in case nothing was checked. 
            {
                return ResultColor.Crimson;
            }
        }


        private bool CheckExperimentComplete()
        {
            //If all data is filled out and completed. 
            if (!string.IsNullOrWhiteSpace(exp.StudentName) && !string.IsNullOrWhiteSpace(txtExpNum.Text) &&
                !string.IsNullOrWhiteSpace(txtExpDescr.Text)
                && !string.IsNullOrWhiteSpace(txtResultWeight.Text) &&
                !string.IsNullOrWhiteSpace(txtResultVolume.Text) &&
                (chkCrimson.Checked || chkAzure.Checked || chkTaupe.Checked ||
                 chkMauve.Checked || chkVermillion.Checked || chkChartreuse.Checked))
            {
                //return true. 
                return true;
            }

            //If not return false. 
            return false;
        }


        private void CheckDictionary()
        {
            //try to parse the experiment number to int. 
            if (int.TryParse(txtExpNum.Text, out int exp_ID))
            {
                //If the number is already in the dictionary keys. 
                if (experiments.ContainsKey(exp_ID))
                {
                    //Provide the user an option to replace the experiment or not. 
                    DialogResult result = MessageBox.Show("This experiment already exists. Do you want to replace it?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Give that identity the current object that's being saved. 
                        experiments[exp_ID] = exp;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all forms. 
            txtStudentName.Text = "";
            txtExpNum.Text = "";
            txtExpDescr.Text = "";
            txtResultWeight.Text = "";
            txtResultVolume.Text = "";
            lbxSummaries.Items.Clear();
            txtStudentName.Focus();
            chkCrimson.Checked = false;
            chkAzure.Checked = false;
            chkChartreuse.Checked = false;
            chkMauve.Checked = false;
            chkTaupe.Checked = false;
            chkVermillion.Checked = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form entirely. 
            this.Close();
        }

        private void lbxSummaries_DoubleClick(object sender, EventArgs e)
        {
            //Need to grab the dictionary key. 
            //Using that key, grab all the information. Set it equal to a string. 
            int ExperimentNumber = 0;


            //First check if our click is not null. 
            if (lbxSummaries.SelectedItem != null)
            {
                //Get the string value of the selected item first. 
                string selected_item = lbxSummaries.SelectedItem.ToString();
                //Now that we have the entire string value, we need to split it up by \t.
                //And we're going to put it into a local list. delimiter is the \t.
                string[] selected_parts = selected_item.Split('\t');

                //A second if statement to ensure it is greater than one value. 
                if (selected_parts.Length >= 1)
                {
                    //Grab the experiment number which SHOULD be the first index. 
                    string experiment_number = selected_parts[0];

                    //tryparse the index value. 
                    if (int.TryParse(experiment_number, out ExperimentNumber))
                    {
                        //Instance of the second form: Review Form. 
                        Review review_form = new Review();
                        //Populate the label in the Review Form. 
                        review_form.lblReviewSummary.Text = "Name: " + experiments[ExperimentNumber].StudentName + "\n" +
                                                            "Experiment Number: " + experiments[ExperimentNumber].ExpNum.ToString() + "\n" +
                                                            "Experiment Description: " + experiments[ExperimentNumber].ExpDescription + "\n" +
                                                            "Color: " + experiments[ExperimentNumber].FinalResultColor + "\n" +
                                                            "Weight: " + experiments[ExperimentNumber].ResultWeight.ToString() + "\n" +
                                                            "Volume: " + experiments[ExperimentNumber].ResultVolume.ToString()
                                                                .ToString();
                        //Prevent the user from editing the Review Form data. 
                        review_form.lblReviewSummary.Enabled = false;
                        //This will make the Review Form modal. 
                        review_form.ShowDialog();
                    }
                }

            }

            
        }
    }
}
//Done!