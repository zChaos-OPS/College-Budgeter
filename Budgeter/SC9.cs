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
    [Activity(Label = "SC9")]
    public class SC9 : Activity
    {
        private double carInsAmnt = 0;
        private double medicalInsAmnt = 0;
        private double dentalInsAmnt = 0;
        private double lifeInsAmnt = 0;
        private int otherIns = 0;
        private double otherInsAmnt = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC9);

            if (Global.budgetModel.CarInsAmnt != 0)
            {
                carInsAmnt = Global.budgetModel.CarInsAmnt;
                UpdateScreen();
            }
            if (Global.budgetModel.MedicalInsAmnt != 0)
            {
                medicalInsAmnt = Global.budgetModel.MedicalInsAmnt;
                UpdateScreen();
            }
            if (Global.budgetModel.DentalInsAmnt != 0)
            {
                dentalInsAmnt = Global.budgetModel.DentalInsAmnt;
                UpdateScreen();
            }
            if (Global.budgetModel.LifeInsAmnt != 0)
            {
                lifeInsAmnt = Global.budgetModel.LifeInsAmnt;
                UpdateScreen();
            }
            if (Global.budgetModel.OtherIns != 0)
            {
                otherIns = Global.budgetModel.OtherIns;
                UpdateScreen();
            }
            if (Global.budgetModel.OtherInsAmnt != 0)
            {
                otherInsAmnt = Global.budgetModel.OtherInsAmnt;
                UpdateScreen();
            }
            //The code for the "Proceed" button
            Button btnScreen10 = FindViewById<Button>(Resource.Id.btnProceedSC9);

            //Declaring and assigning variables to be used here for Sec6 screen:
            EditText sec6Ans1Amnt, sec6Ans2Amnt, sec6Ans3Amnt, sec6Ans4Amnt, sec6Ans5Amnt;

            sec6Ans1Amnt = (EditText)FindViewById(Resource.Id.txtSec6CarInsAmnt);
            sec6Ans2Amnt = (EditText)FindViewById(Resource.Id.txtSec6MedicalInsAmnt);
            sec6Ans3Amnt = (EditText)FindViewById(Resource.Id.txtSec6DentalInsAmnt);
            sec6Ans4Amnt = (EditText)FindViewById(Resource.Id.txtSec6LifeInsAmnt);
            sec6Ans5Amnt = (EditText)FindViewById(Resource.Id.txtSec6OtherInsAmnt);

            if (carInsAmnt != 0)
            {
                sec6Ans1Amnt.Text = carInsAmnt.ToString();
            }
            if (medicalInsAmnt != 0)
            {
                sec6Ans2Amnt.Text = medicalInsAmnt.ToString();
            }
            if (dentalInsAmnt != 0)
            {
                sec6Ans3Amnt.Text = dentalInsAmnt.ToString();
            }
            if (lifeInsAmnt != 0)
            {
                sec6Ans4Amnt.Text = lifeInsAmnt.ToString();
            }
             if (otherInsAmnt != 0)
            {
                sec6Ans5Amnt.Text = otherInsAmnt.ToString();
            }   

            RadioButton sec6Ans5Opt1, sec6Ans5Opt2;
            sec6Ans5Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec6Qs5OptYes);
            sec6Ans5Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec6Qs5OptNo);

            if (otherIns != 0)
            {
                switch (otherIns)
                {
                    case 1:
                        sec6Ans5Opt1.Checked = true;
                        break;
                    case 2:
                        sec6Ans5Opt2.Checked = true;
                        break;
                }
            }
            sec6Ans5Opt1.Click += rdgrpSec6Ans5Click;
            sec6Ans5Opt2.Click += rdgrpSec6Ans5Click;
            //Declaration and assigning of variables is complete.

            btnScreen10.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the ValidateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                {
                    MoveToSection7();
                }                  
            };

            //The code for the "Back" button
            Button btnScreen8 = FindViewById<Button>(Resource.Id.btnBackSC9);

            btnScreen8.Click += (sender, e) =>
            {
                Intent Screen8 = new Intent(this, typeof(SC8));
                StartActivity(Screen8);
            };
        }
        private void rdgrpSec6Ans5Click(object sender, EventArgs e)
        {
            RadioButton rdGrpSec6Ans5 = (RadioButton)sender;
            otherIns = Convert.ToInt32(rdGrpSec6Ans5.Tag.ToString());

            EditText sec6Ans5OtherInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6OtherInsAmnt);
            Toast.MakeText(this, otherIns.ToString(), ToastLength.Long).Show();

            if (otherIns == 1)
            {
                sec6Ans5OtherInsAmnt.Visibility = ViewStates.Visible;
            }
            else
            {
                sec6Ans5OtherInsAmnt.Visibility = ViewStates.Gone;
            }
            UpdateScreen();
        }
        private bool ValidateScreen()
        {
            //Checks and assignments for the textboxes.
            try
            {
                EditText sec6CarInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6CarInsAmnt);
                if (!string.IsNullOrEmpty(sec6CarInsAmnt.Text)) //Checks if the textbox txtSec6CarInsAmnt has any value.
                {
                carInsAmnt = Convert.ToDouble(sec6CarInsAmnt.Text); //If it does, it asssigns the value of the textbox txtSec6CarInsAmnt to the variable carInsAmnt.
                }
                else
                {
                    carInsAmnt = -1; //If it's empty, the function assigns the variable carInsAmnt a value of "0".
                }

                EditText sec6MedicalInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6MedicalInsAmnt);
                if (!string.IsNullOrEmpty(sec6MedicalInsAmnt.Text)) //Checks if the textbox txtSec6MedicalInsAmnt has any value.
                {
                    medicalInsAmnt = Convert.ToDouble(sec6MedicalInsAmnt.Text); //If it does, it asssigns the value of the textbox txtSec6MedicalInsAmnt to the variable carInsAmnt.
                }
                else
                {
                    medicalInsAmnt = -1; //If it's empty, the function assigns the variable medicalInsAmnt a value of "0".
                }

                EditText sec6DentalInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6DentalInsAmnt);
                if (!string.IsNullOrEmpty(sec6DentalInsAmnt.Text))
                {
                    dentalInsAmnt = Convert.ToDouble(sec6DentalInsAmnt.Text);
                }
                else
                {
                    dentalInsAmnt = -1;
                }

                EditText sec6LifeInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6LifeInsAmnt);
                if (!string.IsNullOrEmpty(sec6LifeInsAmnt.Text))
                {
                    lifeInsAmnt = Convert.ToDouble(sec6LifeInsAmnt.Text);
                }
                else
                {
                    lifeInsAmnt = -1;
                }

                EditText sec6OtherInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6OtherInsAmnt);
                if (!string.IsNullOrEmpty(sec6OtherInsAmnt.Text))
                {
                    otherInsAmnt = Convert.ToDouble(sec6OtherInsAmnt.Text);
                }
                else
                {
                    otherInsAmnt = -1;
                }
            }
            catch
            {
                Toast.MakeText(this, "Please enter a valid 'number' in the textboxes and then click on 'Proceed'", ToastLength.Long).Show();
                return false;
            }


            //The conditions that will be checked at the time of the click of the Proceed Button 
            if (carInsAmnt < 0 || medicalInsAmnt < 0 || dentalInsAmnt < 0 || lifeInsAmnt < 0)
            {
                Toast.MakeText(this, "Please either enter a value in the empty textboxes, or enter in a '0' in them if that specific insurance doesn't apply to you.", ToastLength.Long).Show();
                return false;
            }
            if (otherIns == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 5.", ToastLength.Long).Show();
                return false;
            }
            if (otherIns == 1 && otherInsAmnt < 0)
            {
                Toast.MakeText(this, "Please enter in a valid amount in the textbox from Question 5.", ToastLength.Long).Show();
                return false;
            }
            if (otherIns == 2)
            {
                otherInsAmnt = 0;
                return true;
            }
        UpdateScreen();
        return true;
        }
        private void UpdateScreen ()
        {
            EditText sec6OtherInsAmnt = (EditText)FindViewById(Resource.Id.txtSec6OtherInsAmnt);
            if (otherIns == 1)
            {
                sec6OtherInsAmnt.Visibility = ViewStates.Visible;
            }
            else
            {
                sec6OtherInsAmnt.Visibility = ViewStates.Gone;
            }
        }
        private void MoveToSection7()
        {
            Global.budgetModel.CarInsAmnt = carInsAmnt;
            Global.budgetModel.MedicalInsAmnt = medicalInsAmnt;
            Global.budgetModel.DentalInsAmnt = dentalInsAmnt;
            Global.budgetModel.LifeInsAmnt = lifeInsAmnt;
            Global.budgetModel.OtherIns = otherIns;
            Global.budgetModel.OtherInsAmnt = otherInsAmnt;

            Intent Screen10 = new Intent(this, typeof(SC10));
            StartActivity(Screen10);
        }
    }
}