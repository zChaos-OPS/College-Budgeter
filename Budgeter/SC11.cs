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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC11);

            Button btnScreen12 = FindViewById<Button>(Resource.Id.btnProceedSC11);

            btnScreen12.Click += (sender, e) =>
            {
                Intent Screen12 = new Intent(this, typeof(SC12));
                StartActivity(Screen12);
            };

                Button btnScreen10 = FindViewById<Button>(Resource.Id.btnBackSC11);

            btnScreen10.Click += (sender, e) =>
            {
                Intent Screen10 = new Intent(this, typeof(SC10));
                StartActivity(Screen10);
                // Create your application here
            };
        }
    }
}