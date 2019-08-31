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
    [Activity(Label = "SC10")]
    public class SC10 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SC10);

            //The code for the "Procced" button
            Button btnScreen11 = FindViewById<Button>(Resource.Id.btnProceedSC10);

            btnScreen11.Click += (sender, e) =>
            {
                //Global.budget.SetScreen1Option();
                Intent Screen11 = new Intent(this, typeof(SC11));
                StartActivity(Screen11);
            };

            Button btnScreen9 = FindViewById<Button>(Resource.Id.btnBackSC10);

            btnScreen9.Click += (sender, e) =>
            {
                Intent Screen9 = new Intent(this, typeof(SC9));
                StartActivity(Screen9);

                // Create your application here
            };
        }
    }
}