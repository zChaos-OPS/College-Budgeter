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
            budget.noofdressespermonth = monthlydress;
            budget.clothingrange = range;
        }

        public void SetScreen2Option(bool walk)
        {
            budget.walk = walk;
        }
    }
}
