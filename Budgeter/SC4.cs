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
        private int avgNoOfClothes = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC4);
            if (Global.budgetModel.ShoppingTimesPerMonth != 0)
            {
                shoppingTimes = Global.budgetModel.ShoppingTimesPerMonth;
            }
            if (Global.budgetModel.ClothingRange != 0)
            {
                shoppingRange = Global.budgetModel.ClothingRange;
            }
            if (Global.budgetModel.AvgNoOfClothes != 0)
            {
                avgNoOfClothes = Global.budgetModel.AvgNoOfClothes;
            }
            //The code for the "Proceed" button
            Button btnScreen5 = FindViewById<Button>(Resource.Id.btnProceedSC4);

            //Declaring and assigning variables to be used here for Sec1 Qs1:
            RadioButton sec1Ans1Opt1, sec1Ans1Opt2, sec1Ans1Opt3, sec1Ans1Opt4;
            sec1Ans1Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans1Opt1);
            sec1Ans1Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans1Opt2);
            sec1Ans1Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans1Opt3);
            sec1Ans1Opt4 = (RadioButton)FindViewById(Resource.Id.rdbtnSec1Ans1Opt4);

            if (shoppingTimes != 0)
            {
                switch (shoppingTimes)
                {
                    case 1:
                        sec1Ans1Opt1.Checked = true;
                        break;
                    case 2:
                        sec1Ans1Opt2.Checked = true;
                        break;
                    case 3:
                        sec1Ans1Opt3.Checked = true;
                        break;
                    case 4:
                        sec1Ans1Opt4.Checked = true;
                        break;
                }
            }
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

            if (shoppingRange != 0)
            {
                switch (shoppingRange)
                {
                    case 1:
                        sec1Ans2Opt1.Checked = true;
                        break;
                    case 2:
                        sec1Ans2Opt2.Checked = true;
                        break;
                    case 3:
                        sec1Ans2Opt3.Checked = true;
                        break;
                }
            }

            sec1Ans2Opt1.Click += rdgrpSec1Ans2Click;
            sec1Ans2Opt2.Click += rdgrpSec1Ans2Click;
            sec1Ans2Opt3.Click += rdgrpSec1Ans2Click;
            //Declaration and assigning of variables is complete.

            //Declaring and assigning variables to be used here for Sec1 Qs3:
            EditText sec1Ans3Amnt;
            sec1Ans3Amnt = (EditText)FindViewById(Resource.Id.txtSec1AvgNoOfClothes);

            if (avgNoOfClothes != 0)
            {
                sec1Ans3Amnt.Text = avgNoOfClothes.ToString();
            }
            //Note that since txtSec1AVgNoOfClothes is a TextBox (EditText) we need to use the EditText widget.

            btnScreen5.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the ValidateScreen function and if good carries out the MovetoSection2 function.
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

        //The function rdgrpSec1Ans2Click finds out which rdbtn for Question 2 was selected by the user
        private void rdgrpSec1Ans2Click(object sender, EventArgs e)
        {
            RadioButton rbSec2Ans2 = (RadioButton)sender;

            shoppingRange = Convert.ToInt32(rbSec2Ans2.Tag.ToString());

            Toast.MakeText(this, shoppingRange.ToString(), ToastLength.Long).Show();
        }

        //Checks for errors and if none are found, Validates the screen.
        private bool ValidateScreen()
        {
            // ==0 signifies that the user hasn't selected an option and/or has entered in a 0 in a textbox or left the textbox empty.

            /* "&&" is the And operator and "||" is the Or operator. When using an And operator, both or however many conditions you write
            MUST all be true or the condition is false and vice-versa. When using an Or opearator, only one of the both/several conditions MUST be true and the 
            condition will be true and vice-versa.
            */
            try
            {
                EditText sec1AvgAmntofDress = (EditText)FindViewById(Resource.Id.txtSec1AvgNoOfClothes);
                if (!String.IsNullOrEmpty(sec1AvgAmntofDress.Text))
                {
                    avgNoOfClothes = Convert.ToInt32(sec1AvgAmntofDress.Text);
                }
                else
                {
                    avgNoOfClothes = 0;
                }         
                if (shoppingTimes == 0 || shoppingRange == 0 || avgNoOfClothes == 0)
                {
                    Toast.MakeText(this, "Please answer all the questions below and then click Proceed.", ToastLength.Long).Show();
                    return false;
                }
            }
            catch
            {
                Toast.MakeText(this, "Enter a valid number in the textbox.", ToastLength.Long).Show();
                return false;
            }
            return true;
        }
        //Moves on to Section2
        private void MoveToSection2()
        {
            //Save the screen information to Global model
            Global.budgetModel.ShoppingTimesPerMonth = shoppingTimes;
            Global.budgetModel.ClothingRange = shoppingRange;
            Global.budgetModel.AvgNoOfClothes = avgNoOfClothes;

            Intent Screen5 = new Intent(this, typeof(SC5));
            StartActivity(Screen5);
        }
    }
}