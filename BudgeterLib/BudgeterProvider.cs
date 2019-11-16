using System;
using System.Collections.Generic;
using System.Text;

namespace BudgeterLib
{
    public class BudgeterProvider
    {
        BudgeterModel budget = new BudgeterModel();
        public void SetScreen1Option(int monthlydress,string range,int avgNoOfClothes)
        {
            //budget.NoofDressPerMonth = monthlydress;

        }

        public void SetScreen2Option(int walk)
        {
            budget.Walk = walk;
        }
    }
}
