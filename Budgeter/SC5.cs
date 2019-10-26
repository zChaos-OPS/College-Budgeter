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
    [Activity(Label = "SC5")]
    public class SC5 : Activity
    {
        private int Walk = 0;
        private int Bicycle = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC5);

            if (Global.budgetModel.Walk != 0)
            {
                Walk = Global.budgetModel.Walk;
                UpdateScreen();
            }

            //The code for the "Proceed" button
            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnProceedSC5);

            //Declaring variables for Sec2Qs1:
            RadioButton sec2Ans1OptYes, sec2Ans1OptNo;

            sec2Ans1OptYes = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs1Opt1);
            sec2Ans1OptNo = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs1Opt2);

            sec2Ans1OptYes.Click += rdSec2Ans1Click;
            sec2Ans1OptNo.Click += rdSec2Ans1Click;
            //Declaration and assigning of variables is complete for Sec2Qs1

            //Declaring variables for Sec2Qs2


            btnScreen9.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the validateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                {
                    MoveToSection3();
                }
            };

            //The code for the "Back" button
            Button btnScreen4 = FindViewById<Button>(Resource.Id.btnBackSC5);

            btnScreen4.Click += (sender, e) =>
            {
                Intent Screen4 = new Intent(this, typeof(SC4));
                StartActivity(Screen4);

                // Create your application here
            };
        }
        private void MoveToSection3()
        {
            Global.budgetModel.Walk = Walk;
            Intent Screen9 = new Intent(this, typeof(SC9));
            StartActivity(Screen9);
        }

        private void rdSec2Ans1Click(object sender, EventArgs e)
        {
            RadioButton rb2 = (RadioButton)sender;

            Walk = Convert.ToInt32(rb2.Tag.ToString());

            UpdateScreen();
        }

        private void UpdateScreen()
        {
            TextView sec2Qs2 = (TextView)FindViewById<TextView>(Resource.Id.txtvSec2Qs2);
            RadioGroup rdgrpSec2Qs2Ans = (RadioGroup)FindViewById<RadioGroup>(Resource.Id.rdgrpSec2Qs2Ans);
            if (Walk == 1)
            {
                sec2Qs2.Visibility = ViewStates.Gone;

                rdgrpSec2Qs2Ans.Visibility = ViewStates.Gone;
            }
            else
            {
                sec2Qs2.Visibility = ViewStates.Visible;
                rdgrpSec2Qs2Ans.Visibility = ViewStates.Visible;
            }
        }

        private Boolean ValidateScreen()
        {

            return true;
        }
    }
}