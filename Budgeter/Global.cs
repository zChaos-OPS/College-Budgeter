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
    public static class Global
    {
        public static BudgeterProvider budgetProvider = new BudgeterProvider();
        public static BudgeterModel budgetModel = new BudgeterModel();
    }
}