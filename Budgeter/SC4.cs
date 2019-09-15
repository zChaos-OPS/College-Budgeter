using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgeterLib;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Budgeter
{
    [Activity(Label = "SC4")]
    public class SC4 : Activity
    {
        private int shoppingTimes = 0;
        private int shoppingRange = 0;
        private int AvgNoOfClothes = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC4);

            //The code for the "Proceed" button
            Button btnScreen5 = FindViewById<Button>(Resource.Id.btnProceedSC4);

            //Declaring and assigning variables to be used here for Sec1 Qs1:
            RadioButton  sec1Ans1Opt1, sec1Ans1Opt2, sec1Ans1Opt3, sec1Ans1Opt4;
            sec1Ans1Opt1 = (RadioButton) FindViewById (Resource.Id.rdbtnSec1Ans1Opt1);
            sec1Ans1Opt2 = (RadioButton) FindViewById (Resource.Id.rdbtnSec1Ans1Opt2);
            sec1Ans1Opt3 = (RadioButton) FindViewById (Resource.Id.rdbtnSec1Ans1Opt3);
            sec1Ans1Opt4 = (RadioButton) FindViewById (Resource.Id.rdbtnSec1Ans1Opt4);

            sec1Ans1Opt1.Click += rdgrpSec1Ans1Click;
            sec1Ans1Opt2.Click += rdgrpSec1Ans1Click;
            sec1Ans1Opt3.Click += rdgrpSec1Ans1Click;
            sec1Ans1Opt4.Click += rdgrpSec1Ans1Click;
            //Declaration and assigning of variables is complete.

            //Declaring and assigning variables to be used here for Sec1 Qs2:
            RadioButton sec1Ans2Opt1, sec1Ans2Opt2, sec1Ans2Opt3;
            sec1Ans2Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans2Opt1);
            sec1Ans2Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans2Opt2);
            sec1Ans2Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans2Opt3);

            sec1Ans2Opt1.Click += rdgrpSec1Ans2Click;
            sec1Ans2Opt2.Click += rdgrpSec1Ans2Click;
            sec1Ans2Opt3.Click += rdgrpSec1Ans2Click;
            //Declaration and assigning of variables is complete.

            //Declaring and assigning a variable to be used here for Sec1 Qs3:
            EditText sec1AvgAmntofDress;
            sec1AvgAmntofDress = (EditText)FindViewById(Resource.Id.txtSec1AvgNoOfClothes);

            sec1AvgAmntofDress.Click += txtSec1Ans3Click;
            //Declaration and assigning of variable is complete.

            btnScreen5.Click += (sender, e) => 
            {
                //Checks if the screen is validated by the validateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                    MoveToSection2();
            };

            //The code for the "Back" button
            Button btnScreen3 = FindViewById<Button>(Resource.Id.btnBackSC4);

            btnScreen3.Click += (sender, e) =>
            {
                Intent Screen3 = new Intent(this, typeof(SC3));
                StartActivity(Screen3);
            };
        }

        //The function rdgrpSec1Ans1Click finds out which rdbtn for Question 1 was selected by the user.
        private void rdgrpSec1Ans1Click(object sender, EventArgs e)
        {
            RadioButton rbSec1Ans1 = (RadioButton)sender;

            shoppingTimes = Convert.ToInt32(rbSec1Ans1.Tag.ToString());

            Toast.MakeText(this, shoppingTimes.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec1Ans2Click finds out which rdbtn for Question 2 was selected by the user.
        private void rdgrpSec1Ans2Click(object sender, EventArgs e)
        {
            RadioButton rbSec2Ans2 = (RadioButton)sender;

            shoppingRange = Convert.ToInt32(rbSec2Ans2.Tag.ToString());

            Toast.MakeText(this, shoppingRange.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec1Ans2Click finds out which rdbtn for Question 2 was selected by the user.
        private void txtSec1Ans3Click(object sender, EventArgs e)
        {
            EditText txtSec2Ans3 = (EditText)sender;

            AvgNoOfClothes = Convert.ToInt32(txtSec2Ans3.Tag.ToString());

            Toast.MakeText(this, AvgNoOfClothes.ToString(), ToastLength.Long).Show();
        }

        //Checks for errors and if none are found, Validates the screen.
        private Boolean ValidateScreen()
        {
            // ==0 signifies that the user hasn't selected an option and/or has entered in a 0 in a textbox or left the textbox empty.

            /* "&&" is the And operator and "||" is the Or operator. When using an And operator, both or however many conditions you write
            MUST all be true or the condition is false and vice-versa. When using an Or opearator, only one of the both/several conditions MUST be true and the 
            condition will be true and vice-versa.
            */

            //Conditions for Question 1

            //All questions are empty
            if (shoppingTimes == 0 && shoppingRange == 0 && AvgNoOfClothes == 0)
            {
                Toast.MakeText(this, "Please answer all the questions below and then click Proceed.", ToastLength.Long).Show();
                return false;
            }
            //Qs 1 and 2 are empty
            if (shoppingTimes == 0 && shoppingRange == 0)
            {
                Toast.MakeText(this, "Please select options from Questions 1 and 2; then click Proceed.", ToastLength.Long).Show();
                return false;
            }
            //Qs 1 and 3 are empty
            if (shoppingTimes == 0 && AvgNoOfClothes == 0)
            {
                Toast.MakeText(this, "Please answer Questions 1 and 3; then click Proceed.", ToastLength.Long).Show();
                return false;
            }
            //Conditions for Question 2

            //Qs 2 and 3 are empty
            if (shoppingRange == 0 && AvgNoOfClothes == 0)
            {
                Toast.MakeText(this, "Please answer Question 2 and 3; then click Proceed.", ToastLength.Long).Show();                
                return false;
            }
            //All conditions for Qs3 are already met

            //Qs1 is empty
            if (shoppingTimes == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 1.", ToastLength.Long).Show();
                return false;
            }

            //Qs2 is empty
            if (shoppingRange == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 2.", ToastLength.Long).Show();
                return false;
            }
            //Qs3 is empty
            if (AvgNoOfClothes == 0)
            {
                Toast.MakeText(this, "Please enter in the average amount of dresses you buy per shopping session.", ToastLength.Long).Show();
                return false;
            }
            return true;
        }
        //Moves on to Section2
        private void MoveToSection2()
        {
            Intent Screen5 = new Intent(this, typeof(SC5));
            StartActivity(Screen5);
        }
    }
}