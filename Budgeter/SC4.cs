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
    [Activity(Label = "SC4")]
    public class SC4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC4);

            //The code for the "Proceed" button
            Button btnScreen5 = FindViewById<Button>(Resource.Id.btnProceedSC4);

            btnScreen5.Click += (sender, e) => {
                //Global.budget.SetScreen1Option();
                Intent Screen5 = new Intent(this, typeof(SC5));
                StartActivity(Screen5);
            };

            //The code for the "Back" button
            Button btnScreen3 = FindViewById<Button>(Resource.Id.btnBackSC4);

            btnScreen3.Click += (sender, e) =>
            {
                Intent Screen3 = new Intent(this, typeof(SC3));
                StartActivity(Screen3);

                // Create your application here
            };
        }
    }
}