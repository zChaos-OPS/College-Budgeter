using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgeterLib;

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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC5);

            //The code for the "Proceed" button
            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnProceedSC5);

            btnScreen9.Click += (sender, e) =>
            {
                Intent Screen5 = new Intent(this, typeof(SC9));
                StartActivity(Screen5);
            };

            //The code for the "Back" button
            Button btnScreen3 = FindViewById<Button>(Resource.Id.btnBackSC4);

            btnScreen3.Click += (sender, e) =>
            {
                Intent Screen3 = new Intent(this, typeof(SC4));
                StartActivity(Screen3);
            };
        }
    }
}