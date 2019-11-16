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
    [Activity(Label = "SC7")]
    public class SC7 : Activity
    {
        private int internetService = 0;
        private int internetSpeed = 0;
        private int mobileData = 0;
        private int cablePlan = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC7);

            if (Global.budgetModel.InternetServiceLikeComcast != 0)
            {
                internetService = Global.budgetModel.InternetServiceLikeComcast;
                UpdateScreen();
            }
            if (Global.budgetModel.InternetSpeed != 0)
            {
                internetSpeed = Global.budgetModel.InternetSpeed;
                UpdateScreen();
            }
            if (Global.budgetModel.MobileDataInGB != 0)
            {
                mobileData = Global.budgetModel.MobileDataInGB;
                UpdateScreen();
            }
            if (Global.budgetModel.CablePlan != 0)
            {
                cablePlan = Global.budgetModel.CablePlan;
                UpdateScreen();
            }

            //The code for the "Proceed" button
            Button btnScreen8 = FindViewById<Button>(Resource.Id.btnProceedSC7);

            //Declaring and assigning variables to be used here for Sec4 Qs1:
            RadioButton sec4Ans1OptYes, sec4Ans1OptNo;
            sec4Ans1OptYes = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs1Opt1);
            sec4Ans1OptNo = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs1Opt2);

            if (internetService != 0)
            {
                switch (internetService)
                {
                    case 1:
                        sec4Ans1OptYes.Checked = true;
                        break;
                    case 2:
                        sec4Ans1OptNo.Checked = true;
                        break;
                }
            }

            sec4Ans1OptYes.Click += rdgrpSec4Ans1Click;
            sec4Ans1OptNo.Click += rdgrpSec4Ans1Click;
            //Declaration and assigning of variables is complete.

            //Declaring and assigning variables to be used here for Sec4 Qs2:
            RadioButton sec4Ans2OptHigh, sec4Ans2OptMedium, sec4Ans2OptLow;
            sec4Ans2OptHigh = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs2Opt1);
            sec4Ans2OptMedium = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs2Opt2);
            sec4Ans2OptLow = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs2Opt3);

            if (internetSpeed != 0)
            {
                switch (internetSpeed)
                {
                    case 1:
                        sec4Ans2OptHigh.Checked = true;
                        break;
                    case 2:
                        sec4Ans2OptMedium.Checked = true;
                        break;
                    case 3:
                        sec4Ans2OptLow.Checked = true;
                        break;
                }
            }

            sec4Ans2OptHigh.Click += rdgrpSec4Ans2Click;
            sec4Ans2OptMedium.Click += rdgrpSec4Ans2Click;
            sec4Ans2OptLow.Click += rdgrpSec4Ans2Click;
            //Declaration and assigning  variables is complete.

            //Declaring and assigning variables to be used here for Sec4 Qs3:
            RadioButton sec4Ans3NoInternet, sec4Ans3LessThan1GB, sec4Ans31To5GB, sec4Ans35To10GB, sec4Ans3MoreThan10GB,sec4Ans3UnlimitedPlan;
            sec4Ans3NoInternet = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs3Opt1);
            sec4Ans3LessThan1GB = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs3Opt2);
            sec4Ans31To5GB = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs3Opt3);
            sec4Ans35To10GB = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs3Opt4);
            sec4Ans3MoreThan10GB = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs3Opt5);
            sec4Ans3UnlimitedPlan = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs3Opt6);

            if (mobileData != 0)
            {
                switch (mobileData)
                {
                    case 1:
                        sec4Ans3NoInternet.Checked = true;
                        break;
                    case 2:
                        sec4Ans3LessThan1GB.Checked = true;
                        break;
                    case 3:
                        sec4Ans31To5GB.Checked = true;
                        break;
                    case 4:
                        sec4Ans35To10GB.Checked = true;
                        break;
                    case 5:
                        sec4Ans3MoreThan10GB.Checked = true;
                        break;
                    case 6:
                        sec4Ans3UnlimitedPlan.Checked = true;
                        break;
                }
            }

            sec4Ans3NoInternet.Click += rdgrpSec4Ans3Click;
            sec4Ans3LessThan1GB.Click += rdgrpSec4Ans3Click;
            sec4Ans31To5GB.Click += rdgrpSec4Ans3Click;
            sec4Ans35To10GB.Click += rdgrpSec4Ans3Click;
            sec4Ans3MoreThan10GB.Click += rdgrpSec4Ans3Click;
            sec4Ans3UnlimitedPlan.Click += rdgrpSec4Ans3Click;
            //Declaration and assigning of variables is complete.

            //Declaring and assigning variables to be used here for Sec4 Qs4:
            RadioButton sec4Ans4YesWithInternetPlan, sec4Ans4YesWithMobilePlan, sec4Ans4YesButNotWithInternetOrMobilePlan, sec4Ans4NoCablePlan;
            sec4Ans4YesWithInternetPlan = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs4Opt1);
            sec4Ans4YesWithMobilePlan = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs4Opt2);
            sec4Ans4YesButNotWithInternetOrMobilePlan = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs4Opt3);
            sec4Ans4NoCablePlan = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs4Opt4);

            if (cablePlan != 0)
            {
                switch (cablePlan)
                {
                    case 1:
                        sec4Ans4YesWithInternetPlan.Checked = true;
                        break;
                    case 2:
                        sec4Ans4YesWithMobilePlan.Checked = true;
                        break;
                    case 3:
                        sec4Ans4YesButNotWithInternetOrMobilePlan.Checked = true;
                        break;
                    case 4:
                        sec4Ans4NoCablePlan.Checked = true;
                        break;
                }
            }

            sec4Ans4YesWithInternetPlan.Click += rdgrpSec4Ans4Click;
            sec4Ans4YesWithMobilePlan.Click += rdgrpSec4Ans4Click;
            sec4Ans4YesButNotWithInternetOrMobilePlan.Click += rdgrpSec4Ans4Click;
            sec4Ans4NoCablePlan.Click += rdgrpSec4Ans4Click;
            //Declaration and assigning of variables is complete.

            btnScreen8.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the ValidateScreen function and if good carries out the MovetoSection2 function.
                if (ValidateScreen())
                    MoveToSection5();
            };
            
            //The code for the "Back" button
            Button btnScreen5 = FindViewById<Button>(Resource.Id.btnBackSC7);

            btnScreen5.Click += (sender, e) =>
            {
                Intent Screen5 = new Intent(this, typeof(SC5));
                StartActivity(Screen5);
            };
        }

        //The function rdgrpSec4Ans1Click determines which radio button the user clicked on for Question 1.
        private void rdgrpSec4Ans1Click(object sender, EventArgs e)
        {
            RadioButton rdbtnSec4Ans1 = (RadioButton)sender;

            internetService = Convert.ToInt32(rdbtnSec4Ans1.Tag.ToString());

            Toast.MakeText(this, internetService.ToString(), ToastLength.Long).Show();
            UpdateScreen();
        }

        //The function rdgrpSec4Ans2Click determines which radio button the user clicked on for Question 2.
        private void rdgrpSec4Ans2Click(object sender, EventArgs e)
        {
            RadioButton rdbtnSec4Ans2 = (RadioButton)sender;

            internetSpeed = Convert.ToInt32(rdbtnSec4Ans2.Tag.ToString());

            Toast.MakeText(this, internetSpeed.ToString(), ToastLength.Long).Show();
            UpdateScreen();
        }

        //The function rdgrpSec4Ans3Click determines which radio button the user clicked on for Question 3.
        private void rdgrpSec4Ans3Click(object sender, EventArgs e)
        {
            RadioButton rdbtnSec4Ans3 = (RadioButton)sender;

            mobileData = Convert.ToInt32(rdbtnSec4Ans3.Tag.ToString());

            Toast.MakeText(this, mobileData.ToString(), ToastLength.Long).Show();
            UpdateScreen();
        }

        //The function rdgrpSec4Ans4Click determines which radio button the user clicked on for Question 4.
        private void rdgrpSec4Ans4Click(object sender, EventArgs e)
        {
            RadioButton rdbtnSec4Ans4 = (RadioButton)sender;

            cablePlan = Convert.ToInt32(rdbtnSec4Ans4.Tag.ToString());

            Toast.MakeText(this, cablePlan.ToString(), ToastLength.Long).Show();
            UpdateScreen();
        }

        //Checks for errors and if none are found, Validates the screen.
        private bool ValidateScreen()
        {
            if (internetService == 0 || mobileData == 0 || cablePlan == 0)
            {
                Toast.MakeText(this, "Please select an option from each of the questions baove, and then click on 'Proceed'", ToastLength.Long).Show();
                return false;
            }
            if (internetService == 1 && internetSpeed == 0)
            {
                Toast.MakeText(this, "Please select an option from Question 2.", ToastLength.Long).Show();
                return false;
            }
            if (internetService == 2 && internetSpeed == 0)
            {
                return true;
            }
            UpdateScreen();
            return true;
        }

        //The function UpdateScreen() updates the screen according to the option(s) the user selects.
        private void UpdateScreen()
        {
            TextView sec4Qs2 = (TextView)FindViewById(Resource.Id.txtvSec4Qs2);
            TextView sec4Qs3 = (TextView)FindViewById(Resource.Id.txtvSec4Qs3);
            TextView sec4Qs4 = (TextView)FindViewById(Resource.Id.txtvSec4Qs4);
            RadioGroup rdgrpSec4Ans2 = (RadioGroup)FindViewById(Resource.Id.rdgrpSec4Qs2Ans);
            if (internetService == 1)
            {
                sec4Qs2.Visibility = ViewStates.Visible;
                rdgrpSec4Ans2.Visibility = ViewStates.Visible;

                sec4Qs3.Text = "3. In your mobile plan, how much data (in GB) will you have?";
                sec4Qs4.Text = "4. Will you have a cable plan?";
            }
            else
            {
                sec4Qs2.Visibility = ViewStates.Gone;
                rdgrpSec4Ans2.Visibility = ViewStates.Gone;

                sec4Qs3.Text = "2. In your mobile plan, how much data (in GB) will you have?";
                sec4Qs4.Text = "3. Will you have a cable plan?";
            }

            RadioButton sec4Ans2OptHigh, sec4Ans2OptMedium, sec4Ans2OptLow;
            sec4Ans2OptHigh = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs2Opt1);
            sec4Ans2OptMedium = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs2Opt2);
            sec4Ans2OptLow = (RadioButton)FindViewById(Resource.Id.rdbtnSec4Qs2Opt3);

            if (internetService == 2)
            {
                sec4Ans2OptHigh.Checked = false;
                sec4Ans2OptMedium.Checked = false;
                sec4Ans2OptLow.Checked = false;
            }
        }

        //Moves on to Section 5.
        private void MoveToSection5()
        {
            Global.budgetModel.InternetServiceLikeComcast = internetService;
            Global.budgetModel.InternetSpeed = internetSpeed;
            Global.budgetModel.MobileDataInGB = mobileData;
            Global.budgetModel.CablePlan = cablePlan;

            Intent Screen8 = new Intent(this, typeof(SC8));
            StartActivity(Screen8);
        }
    }
}