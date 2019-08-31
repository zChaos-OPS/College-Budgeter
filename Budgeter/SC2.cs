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
    [Activity(Label = "SC2")]
    public class SC2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC2);

            //The code for the "Proceed" button
            Button btnScreen3 = FindViewById<Button>(Resource.Id.btnProceedSC2);

            btnScreen3.Click += (sender, e) => {
                Intent Screen3 = new Intent(this, typeof(SC3));
                StartActivity(Screen3);
            };

            // Create your application here
        }
    }
}