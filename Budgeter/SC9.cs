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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC9);

            //The code for the "Proceed" button
            Button btnScreen10 = FindViewById<Button>(Resource.Id.btnProceedSC9);

            btnScreen10.Click += (sender, e) =>
            {
                //Global.budget.SetScreen1Option();
                Intent Screen10 = new Intent(this, typeof(SC10));
                StartActivity(Screen10);
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
    }
}