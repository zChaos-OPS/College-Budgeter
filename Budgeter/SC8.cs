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
    [Activity(Label = "SC8")]
    public class SC8 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC8);

            //The code for the "Proceed" button
            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnProceedSC8);




            //The code for the "Back" button
            Button btnScreen7 = FindViewById<Button>(Resource.Id.btnBackSC8);

            btnScreen7.Click += (sender, e) =>
            {
                Intent Screen7 = new Intent(this, typeof(SC7));
                StartActivity(Screen7);
            };

            // Create your application here
        }
    }
}