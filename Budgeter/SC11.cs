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
    [Activity(Label = "SC11")]
    public class SC11 : Activity
    {
        private int kitchenMaintences = 0;
        private int toiletMaintences = 0;
        private int roomMaintences = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC11);

            //The code for the "Proceed" button
            Button btnScreen11 = FindViewById<Button>(Resource.Id.btnProceedSC11);

            //Declaring and assigning variables to be used here for Sec8 Qs1:
            RadioButton sec8Qs1Opt1, sec8Qs1Opt2, sec8Qs1Opt3;
            sec8Qs1Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec8Qs1Opt1);
            sec8Qs1Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec8Qs1Opt2);
            sec8Qs1Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec8Qs1Opt3);
           

            sec8Qs1Opt1.Click += rdgrpSec8Qs1AnsClick;
            sec8Qs1Opt2.Click += rdgrpSec8Qs1AnsClick;
            sec8Qs1Opt3.Click += rdgrpSec8Qs1AnsClick;
           
            //Declaration and assigning of variables is complete.

            //Declaring and assigning variables to be used here for Sec8 Qs2:
            RadioButton sec8Ans2Opt1, sec8Ans2Opt2, sec8Ans2Opt3;
            sec8Ans2Opt1 = (RadioButton)FindViewById(Resource.Id.rdbtnSec8Qs1Opt1);
            sec8Ans2Opt2 = (RadioButton)FindViewById(Resource.Id.rdbtnSec8Qs1Opt2);
            sec8Ans2Opt3 = (RadioButton)FindViewById(Resource.Id.rdbtnSec8Qs1Opt3);


            sec8Ans2Opt1.Click += rdgrpSec8Qs2AnsClick;
            sec8Ans2Opt2.Click += rdgrpSec8Qs2AnsClick;
            sec8Ans2Opt3.Click += rdgrpSec8Qs2AnsClick;

            //Declaration and assigning of variable is complete.

            //The code for the "Proceed" button

            btnScreen11.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the validateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                    MoveToSection9();
            };

            //The code for the "Back" buttonC:\GitHub\College-Budgeter\Budgeter\Resources\
            btnScreen11.Click += (sender, e) =>
            {
                Intent Screen10 = new Intent(this, typeof(SC10));
                StartActivity(Screen10);
            };
        }
        //The function rdgrpSec8Ans1Click finds out which rdbtn for Question 1 was selected by the user.
        private void rdgrpSec8Qs1AnsClick(object sender, EventArgs e)
        {
            RadioButton rbSec8Ans1 = (RadioButton)sender;

            kitchenMaintences = Convert.ToInt32(rbSec8Ans1.Tag.ToString());

            Toast.MakeText(this, kitchenMaintences.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec8Ans2Click finds out which rdbtn for Question 2 was selected by the user.
        private void rdgrpSec8Qs2AnsClick(object sender, EventArgs e)
        {
            RadioButton rbSec8Ans2 = (RadioButton)sender;

            toiletMaintences = Convert.ToInt32(rbSec8Ans2.Tag.ToString());

            Toast.MakeText(this, toiletMaintences.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec8Ans3Click finds out which rdbtn for Question 3 was selected by the user.
        private void rdgrpSec8Qs3AnsClick(object sender, EventArgs e)
        {
            RadioButton rbSec8Ans3 = (RadioButton)sender;

            roomMaintences = Convert.ToInt32(rbSec8Ans3.Tag.ToString());

            Toast.MakeText(this, roomMaintences.ToString(), ToastLength.Long).Show();
        }
        //The function rdgrpSec8Ans2Click finds out which rdbtn for Question 2 was selected by the user.
        private Boolean ValidateScreen()
        {
            // ==0 signifies that the user hasn't selected an option and/or has entered in a 0 in a textbox or left the textbox empty.

            /* "&&" is the And operator and "||" is the Or operator. When using an And operator, both or however many conditions you write
            MUST all be true or the condition is false and vice-versa. When using an Or opearator, only one of the both/several conditions MUST be true and the 
            condition will be true and vice-versa.
            */

            //Conditions for Question 1

            //All questions are empty
            if (kitchenMaintences == 0 && toiletMaintences == 0 && roomMaintences == 0)
            {
                Toast.MakeText(this, "Please answer all the questions below and then click Proceed.", ToastLength.Long).Show();
                return false;
            }
            //Qs1 is empty
            if (kitchenMaintences == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 1.", ToastLength.Long).Show();
                return false;
            }

            //Conditions for Question 2

            //Qs 2 is empty
            if (toiletMaintences == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 2.", ToastLength.Long).Show();
                return false;
            }
            //Os 3 is empty
            if (roomMaintences == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 3.", ToastLength.Long).Show();
                return false;
            }
            return true;
        }
        //Moves on to Section9
        private void MoveToSection9()
        {
            Intent Screen12 = new Intent(this, typeof(SC12));
            StartActivity(Screen12);
        }
    }

}



