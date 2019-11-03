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
        private int walk = 0;
        private int bicycle = 0;
        private int personalVehicle = 0;
        private int usePersonalVehicle = 0;
        private double carExpAmnt = 0;
        private double petGasAmnt = 0;
        private double carMaintenance = 0;
        private double otherAmnt = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC5);

            if (Global.budgetModel.Walk != 0)
            {
                walk = Global.budgetModel.Walk;
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
            RadioButton sec2Ans2OptYes, sec2Ans2OptNo;

            sec2Ans2OptYes = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs2Opt1);
            sec2Ans2OptNo = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs2Opt2);

            sec2Ans2OptYes.Click += rdSec2Ans2Click;
            sec2Ans2OptNo.Click += rdSec2Ans2Click;
            //Declaration and assigning of variables is complete for Sec2Qs2

            //Declaring variables for Sec2Qs3
            RadioButton sec2Ans3OptYes, sec2Ans3OptNo;

            sec2Ans3OptYes = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs3Opt1);
            sec2Ans3OptNo = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs3Opt2);

            sec2Ans3OptYes.Click += rdSec2Ans3Click;
            sec2Ans3OptNo.Click += rdSec2Ans3Click;
            //Declaration and assigning of variables is complete for Sec2Qs3

            //Declaring variables for Sec2Qs4
            RadioButton sec2Ans4OptYes, sec2Ans4OptNo;

            sec2Ans4OptYes = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs4Opt1);
            sec2Ans4OptNo = (RadioButton)FindViewById(Resource.Id.rdbtnSec2Qs4Opt2);

            sec2Ans4OptYes.Click += rdSec2Ans4Click;
            sec2Ans4OptNo.Click += rdSec2Ans4Click;
            //Declaration and assigning of variables is complete for Sec2Qs4

            //Declaring variables for Sec2Qs2
            EditText sec2AnsCarExpAmnt, sec2PetGasAmnt, sec2MaintenanceAmnt, sec2MiscAmnt;

            sec2AnsCarExpAmnt = (EditText)FindViewById(Resource.Id.txtSec2CarExpAmnt);
            sec2PetGasAmnt = (EditText)FindViewById(Resource.Id.txtSec2Pet_GasAmnt);
            sec2MaintenanceAmnt = (EditText)FindViewById(Resource.Id.txtSec2MaintenanceAmnt);
            sec2MiscAmnt = (EditText)FindViewById(Resource.Id.txtSec2OtherAmnt);

            sec2Ans2OptYes.Click += rdSec2Ans2Click;
            sec2Ans2OptNo.Click += rdSec2Ans2Click;
            //Declaration and assigning of variables is complete for Sec2Qs2

            btnScreen9.Click += (sender, e) =>
            {
                //Checks if the screen is validated by the validateScreen function and if good carries out the MovetoSection3 function.
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
        
        private void rdSec2Ans1Click(object sender, EventArgs e)
        {
            RadioButton rdGrpAns1 = (RadioButton)sender;

            walk = Convert.ToInt32(rdGrpAns1.Tag.ToString());

            UpdateScreen();
        }
        private void rdSec2Ans2Click(object sender, EventArgs e)
        {
            RadioButton rdGrpAns2 = (RadioButton)sender;

            bicycle = Convert.ToInt32(rdGrpAns2.Tag.ToString());

            UpdateScreen();
        }
        private void rdSec2Ans3Click(object sender, EventArgs e)
        {
            RadioButton rdGrpAns3 = (RadioButton)sender;

            personalVehicle = Convert.ToInt32(rdGrpAns3.Tag.ToString());

            UpdateScreen();
        }
        private void rdSec2Ans4Click(object sender, EventArgs e)
        {
            RadioButton rdGrpAns4 = (RadioButton)sender;

            usePersonalVehicle = Convert.ToInt32(rdGrpAns4.Tag.ToString());

            UpdateScreen();
        }
        
        private void UpdateScreen()
        {
            TextView sec2Qs2 = (TextView)FindViewById<TextView>(Resource.Id.txtvSec2Qs2);
            RadioGroup rdgrpSec2Qs2Ans = (RadioGroup)FindViewById<RadioGroup>(Resource.Id.rdgrpSec2Qs2Ans);
            if (walk == 1)
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
        private void MoveToSection3()
        {
            Global.budgetModel.Walk = walk;

            Intent Screen9 = new Intent(this, typeof(SC9));
            StartActivity(Screen9);
        }
    }
}