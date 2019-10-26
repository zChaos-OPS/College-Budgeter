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
        private int carInsAmnt = 0;
        private int medicalInsAmnt = 0;
        private int dentalInsAmnt = 0;
        private int lifeInsAmnt = 0;
        private int otherIns = 0;
        private int otherInsAmnt = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC9);

            //The code for the "Proceed" button
            Button btnScreen10 = FindViewById<Button>(Resource.Id.btnProceedSC9);

            //Declaring and assigning variables to be used here for Sec6 screen:
            EditText sec6Ans1Amnt, sec6Ans2Amnt, sec6Ans3Amnt, sec6Ans4Amnt, sec6Ans5Amnt;
            sec6Ans1Amnt = (EditText)FindViewById(Resource.Id.txtSec6CarInsAmnt);
            sec6Ans2Amnt = (EditText)FindViewById(Resource.Id.txtSec6MedicalInsAmnt);
            sec6Ans3Amnt = (EditText)FindViewById(Resource.Id.txtSec6DentalInsAmnt);
            sec6Ans4Amnt = (EditText)FindViewById(Resource.Id.txtSec6LifeInsAmnt);
            sec6Ans5Amnt = (EditText)FindViewById(Resource.Id.txtSec6OtherInsAmnt);

            RadioButton sec6Ans5Opt1, sec6Ans5Opt2;
            sec6Ans5Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec6Qs5OptYes);
            sec6Ans5Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec6Qs5OptNo);

            sec6Ans5Opt1.Click += rdgrpSec6Ans5Click;
            sec6Ans5Opt2.Click += rdgrpSec6Ans5Click;
            //Declaration and assigning of variables is complete.

            btnScreen10.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the validateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                    MoveToSection7();
            };

            //The code for the "Back" button
            Button btnScreen5 = FindViewById<Button>(Resource.Id.btnBackSC9);

            btnScreen5.Click += (sender, e) =>
            {
                Intent Screen5 = new Intent(this, typeof(SC5));
                StartActivity(Screen5);

                // Create your application here
            };
        }
        private void rdgrpSec6Ans5Click(object sender, EventArgs e)
        {
            RadioButton rbSec6Ans5 = (RadioButton)sender;
            otherIns = Convert.ToInt32(rbSec6Ans5.Tag.ToString());
            EditText sec6Ans5Amnt = (EditText)FindViewById<EditText>(Resource.Id.txtSec6OtherInsAmnt);
            Toast.MakeText(this, otherIns.ToString(), ToastLength.Long).Show();

            if (otherIns == 1)
            {
                sec6Ans5Amnt.Visibility = ViewStates.Visible;
            }
            else
            {
                sec6Ans5Amnt.Visibility = ViewStates.Gone;
            }
        }
        private Boolean ValidateScreen()
        {
            if (carInsAmnt == 0 || medicalInsAmnt == 0 || dentalInsAmnt == 0 || lifeInsAmnt == 0 || otherInsAmnt == 0)
            {
                Toast.MakeText(this, "Please either enter a value in the empty textboxes, or enter in a '0' in them if that specific insurance doesn't apply to you.", ToastLength.Long).Show();
                return false;
            }
            if (otherIns == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 5.", ToastLength.Long).Show();
                return false;
            }
            return true;
        }
        private void MoveToSection7()
        {
            Intent Screen10 = new Intent(this, typeof(SC10));
            StartActivity(Screen10);
        }
    }
}