﻿using System;
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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC5);

            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnProceedSC5);

            btnScreen9.Click += (sender, e) => {
                //Global.budget.SetScreen1Option();
                Intent Screen9 = new Intent(this, typeof(SC9));
                StartActivity(Screen9);
            };

            // Create your application here
        }
    }
}