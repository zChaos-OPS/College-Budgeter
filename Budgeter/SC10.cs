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
        private int eatingLocationPreference = 0;
        private int mealCostinDollars = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC10);

            if (Global.budgetModel.EatingPlacePreference != 0)
            {
                eatingLocationPreference = Global.budgetModel.EatingPlacePreference;
            }
            if (Global.budgetModel.CostofMealsinDollars != 0)
            {
                mealCostinDollars = Global.budgetModel.CostofMealsinDollars;
            }

            //The code for the "Proceed" button
            Button btnScreen11 = FindViewById<Button>(Resource.Id.btnProceedSC10);
            //Declaring and assigning variables for Sec7Qs1Answers to be used here:
            RadioButton sec7Ans1Opt1, sec7Ans1Opt2, sec7Ans1Opt3, sec7Ans1Opt4, sec7Ans1Opt5;

            sec7Ans1Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans1Opt1);
            sec7Ans1Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans1Opt2);
            sec7Ans1Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans1Opt3);
            sec7Ans1Opt4 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans1Opt4);
            sec7Ans1Opt5 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans1Opt5);

            if (eatingLocationPreference != 0)
            {
                switch (eatingLocationPreference)
                {
                    case 1:
                        sec7Ans1Opt1.Checked = true;
                        break;
                    case 2:
                        sec7Ans1Opt2.Checked = true;
                        break;
                    case 3:
                        sec7Ans1Opt3.Checked = true;
                        break;
                    case 4:
                        sec7Ans1Opt4.Checked = true;
                        break;
                    case 5:
                        sec7Ans1Opt5.Checked = true;
                        break;
                }
            }

            sec7Ans1Opt1.Click += rdgrpSec7Ans1Click;
            sec7Ans1Opt2.Click += rdgrpSec7Ans1Click;
            sec7Ans1Opt3.Click += rdgrpSec7Ans1Click;
            sec7Ans1Opt4.Click += rdgrpSec7Ans1Click;
            sec7Ans1Opt5.Click += rdgrpSec7Ans1Click;
            //Declaration and assigning of variables is complete.
            //Declaring and assigning variables for Sec7Qs2Answers to be used here:
            RadioButton sec7Ans2Opt1, sec7Ans2Opt2, sec7Ans2Opt3;

            sec7Ans2Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans2Opt1);
            sec7Ans2Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans2Opt2);
            sec7Ans2Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec7Ans2Opt3);

            if (mealCostinDollars != 0)
            {
                switch (mealCostinDollars)
                {
                    case 1:
                        sec7Ans2Opt1.Checked = true;
                        break;
                    case 2:
                        sec7Ans2Opt2.Checked = true;
                        break;
                    case 3:
                        sec7Ans2Opt3.Checked = true;
                        break;
                }
            }

            sec7Ans2Opt1.Click += rdgrpSec7Ans2Click;
            sec7Ans2Opt2.Click += rdgrpSec7Ans2Click;
            sec7Ans2Opt3.Click += rdgrpSec7Ans2Click;
            //Declaration and assigning of variables is complete.
            btnScreen11.Click += (sender, e) =>
            {
                if (ValidateScreen())
                {
                    MoveToSection8();
                }
            };

            //The code for the "Back" button
            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnBackSC10);

            btnScreen9.Click += (sender, e) =>
            {
                Intent Screen9 = new Intent(this, typeof(SC9));
                StartActivity(Screen9);
            };
        }
        private void rdgrpSec7Ans1Click(object sender, EventArgs e)
        {
            RadioButton rbSec7Ans1 = (RadioButton)sender;

            eatingLocationPreference = Convert.ToInt32(rbSec7Ans1.Tag.ToString());

            Toast.MakeText(this, eatingLocationPreference.ToString(), ToastLength.Long).Show();
        }
        private void rdgrpSec7Ans2Click(object sender, EventArgs e)
        {
            RadioButton rbSec7Ans2 = (RadioButton)sender;

            mealCostinDollars = Convert.ToInt32(rbSec7Ans2.Tag.ToString());

            Toast.MakeText(this, eatingLocationPreference.ToString(), ToastLength.Long).Show();
        }
        private bool ValidateScreen()
        {
            if (eatingLocationPreference == 0 || mealCostinDollars == 0)
            {
                Toast.MakeText(this, "Please answer all the questions and then click on 'Proceed'", ToastLength.Long).Show();
                return false;
            }
            return true;
        }
        private void MoveToSection8()
        {
            Global.budgetModel.EatingPlacePreference = eatingLocationPreference;
            Global.budgetModel.CostofMealsinDollars = mealCostinDollars;

            Intent Screen11 = new Intent(this, typeof(SC11));
            StartActivity(Screen11);
        }
    }
}