using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Budgeter
{
    [Activity(Label = "SC10")]
    public class SC10 : Activity
    {
        private int eatingPreferences = 0;
        private int eatingBudget = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC10);

            //The code for the "Proceed" button
            Button btnScreen11 = FindViewById<Button>(Resource.Id.btnProceedSC10);

            //Declaring and assigning variables to be used here for Sec7 Qs1:
            RadioButton sec7Qs1Opt1, sec7Qs1Opt2, sec7Qs1Opt3, sec7Qs1Opt4, sec7Qs1Opt5;
            sec7Qs1Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt1);
            sec7Qs1Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt2);
            sec7Qs1Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt3);
            sec7Qs1Opt4 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt4);
            sec7Qs1Opt5 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt5);

            sec7Qs1Opt1.Click += rdgrpSec7Qs1AnsClick;
            sec7Qs1Opt2.Click += rdgrpSec7Qs1AnsClick;
            sec7Qs1Opt3.Click += rdgrpSec7Qs1AnsClick;
            sec7Qs1Opt4.Click += rdgrpSec7Qs1AnsClick;
            sec7Qs1Opt5.Click += rdgrpSec7Qs1AnsClick;
            //Declaration and assigning of variables is complete.

            //Declaring and assigning variables to be used here for Sec1 Qs2:
            RadioButton sec7Ans2Opt1, sec7Ans2Opt2, sec7Ans2Opt3;
            sec7Ans2Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt1);
            sec7Ans2Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt2);
            sec7Ans2Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Qs1Opt3);
           

            sec7Ans2Opt1.Click += rdgrpSec7Qs2AnsClick;
            sec7Ans2Opt2.Click += rdgrpSec7Qs2AnsClick;
            sec7Ans2Opt3.Click += rdgrpSec7Qs2AnsClick;

            //Declaration and assigning of variable is complete.

            //The code for the "Proceed" button
           
            btnScreen11.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the validateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                    MoveToSection8();
            };

            //The code for the "Back" button
            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnBackSC10);

            btnScreen9.Click += (sender, e) =>
            {
                Intent Screen9 = new Intent(this, typeof(SC9));
                StartActivity(Screen9);
            };
        }
        //The function rdgrpSec1Ans1Click finds out which rdbtn for Question 1 was selected by the user.
        private void rdgrpSec7Qs1AnsClick(object sender, EventArgs e)
        {
            RadioButton rbSec7Ans1 = (RadioButton)sender;

            eatingPreferences = Convert.ToInt32(rbSec7Ans1.Tag.ToString());

            Toast.MakeText(this, eatingPreferences.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec1Ans2Click finds out which rdbtn for Question 2 was selected by the user.
        private void rdgrpSec7Qs2AnsClick(object sender, EventArgs e)
        {
            RadioButton rbSec7Ans2 = (RadioButton)sender;

            eatingBudget = Convert.ToInt32(rbSec7Ans2.Tag.ToString());

            Toast.MakeText(this, eatingBudget.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec1Ans2Click finds out which rdbtn for Question 2 was selected by the user.
        private Boolean ValidateScreen()
        {
            // ==0 signifies that the user hasn't selected an option and/or has entered in a 0 in a textbox or left the textbox empty.

            /* "&&" is the And operator and "||" is the Or operator. When using an And operator, both or however many conditions you write
            MUST all be true or the condition is false and vice-versa. When using an Or opearator, only one of the both/several conditions MUST be true and the 
            condition will be true and vice-versa.
            */

            //Conditions for Question 1

            //All questions are empty
            if (eatingPreferences == 0 && eatingBudget == 0)
            {
                Toast.MakeText(this, "Please answer all the questions below and then click Proceed.", ToastLength.Long).Show();
                return false;
            }
            //Qs1 is empty
            if (eatingPreferences == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 1.", ToastLength.Long).Show();
                return false;
            }

            //Conditions for Question 2

            //Qs 2 is empty
            if (eatingBudget == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 2.", ToastLength.Long).Show();
                return false;
            }
            return true;
        }
        //Moves on to Section8
        private void MoveToSection8()
        {
            Intent Screen11 = new Intent(this, typeof(SC11));
            StartActivity(Screen11);
        }
    }

}
           


            