/*
 * Rocco Lepore
 * 9/30/2019
 * Paylocity Coding Challenge
 */
using System;
using System.Windows.Forms;

namespace RoccoLeporePaylocityCodingChallenge2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            double totalCost = 0;//total benefit cost
            double paycheck = 2000;//total of each pay check
            double numPay = 26;//number of paychecks the employee recieves each year
            double benefitCost = 1000;//amount of money the benefit cost for the entire year
            double numDependents;//number of dependents that the employee has
            double dependentCost = 500;//cost incured for each dependent
            double totalDependentCost;//total cost of all the dependents
            double discountAmount;//discount
            double costPerPay;//amount taken out of every paycheck
            double finalCheck;

            //checks to see if a name was entered into the employee textbox. If not the calculations do not run.
            if (String.IsNullOrWhiteSpace(txtEmployee.Text))
            {
                MessageBox.Show("Please enter an employee before clicking the preview button.");
                return;
            }
            //doesn't let program run if numbers are entered into the name fields
            int outParse;
            if (int.TryParse(txtEmployee.Text, out outParse) || int.TryParse(txtSpouse.Text, out outParse) || int.TryParse(txtOther.Text, out outParse))
            {
                MessageBox.Show("Please do not enter any numbers into any of the text boxes");
                return;
            }

            numDependents = calcNumDependents();
            discountAmount = calcDiscount();

            totalDependentCost = numDependents * dependentCost;
            totalCost = ((benefitCost + totalDependentCost) * (1 - discountAmount));
            costPerPay = (totalCost / numPay);
            finalCheck = paycheck - costPerPay;

            //rounds values after calculations have already been made
            totalCost = Math.Round(totalCost, 2);
            costPerPay = Math.Round(costPerPay, 2);
            finalCheck = Math.Round(finalCheck, 2);

            lblAns.Text = "Number of Dependents: " + numDependents + "\n"
                + "Benefit Cost: $" + totalCost + "\n"
                + "Total Discount: " + (discountAmount * 100) + "%\n"
                + "Deduction from Paycheck: $" + costPerPay + "\n"
                + "Paycheck Total: $" + finalCheck;
        }

        //method that calulates the number of dependents
        public double calcNumDependents()
        {
            double ans = 0;
            //looks to see if textbox is empty. If not than add 1 to the total 
            if (!(String.IsNullOrEmpty(txtSpouse.Text)))
            {
                ans = ans + 1;
            }
            // looks to see if textbox is empty. If not splits the lines up into an array and then counts them
            if (!(String.IsNullOrEmpty(txtOther.Text)))
            {
                string[] lines = splitOtherTxt();
                int count = lines.Length;
                ans = ans + count;
            }
            return ans;
        }

        //calculates the total discount given based on all the names entered
        public double calcDiscount()
        {
            double ans = 0;
            //checks if the  Employee name starts with the letter a. If so adds discount
            if (txtEmployee.Text.Trim().StartsWith("A") || txtEmployee.Text.Trim().StartsWith("a"))
            {
                ans = ans + .1;
            }
            //checks if the  Spouse name starts with the letter 'A'. If so adds discount
            if (txtSpouse.Text.Trim().StartsWith("A") || txtSpouse.Text.Trim().StartsWith("a"))
            {
                ans = ans + .1;
            }
            //splits up the "Other Dependents" text box 
            if (!(String.IsNullOrEmpty(txtOther.Text)))
            {
                string[] lines = splitOtherTxt();
                //checks to see if each line starts with the letter 'A'. If so adds to discount
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToString().Trim().StartsWith("A") || lines[i].ToString().Trim().StartsWith("a"))
                    {
                        ans = ans + .1;
                    }
                }
            }
            return ans;
        }

        public string[] splitOtherTxt()
        {
            return txtOther.Text.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
