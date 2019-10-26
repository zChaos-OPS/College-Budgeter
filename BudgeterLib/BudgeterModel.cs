using System;

namespace BudgeterLib
{
    public class BudgeterModel
    {
        //Screen 4 Stuff
        public int ShoppingTimesPerMonth { get; set; }
        public int ClothingRange { get; set; }
        public int AvgNoOfClothes { get; set; }
        //Screen 4 Stuff Ends

        //Screen 5 Stuff
        public int Walk { get; set; }
        public int Bicycle { get; set; }
        public bool PersonalVehicle { get; set; }
        public bool UsePersoanalVehicle { get; set; }
        public double CarExpAmnt { get; set; }
        public double PetGasAmnt { get; set; }
        public double MaintenanceAmnt { get; set; }
        public double MiscAmnt { get; set; }
        public string TransportService { get; set; }
        public double UberAmnt { get; set; }
        public string PassType { get; set; }
        public double DailyPayAmnt { get; set; }
        public double PassAmnt { get; set; }
        //Sreen 5 Stuff Ends

        //Screen 6 Stuff

        //Screen 6 Stuff Ends

        //Screen 7 Stuff

        //Screen 7 Stuff Ends

        //Screen 8 Stuff

        //Screen 8 Stuff Ends

        //Screen 9 Stuff
        public double CarInsAmnt { get; set; }
        public double MedicalInsAmnt { get; set; }
        public double DentalInsAmnt { get; set; }
        public double LifeInsAmnt { get; set; }
        public double OtherInsAmnt { get; set; }
        //Screen 9 Stuff Ends

        //Screen 10 Stuff
        public string EatingLocation { get; set; }
        public string MealCost { get; set; }
        //Screen 10 Stuff Ends

        //Screen 11 Stuff
        public string KitchenMaintenance { get; set; }
        public string ToiletMaintenance { get; set; }
        public string RoomMaintenance { get; set; }
        public bool BackyardExists { get; set; }
        public string BackyardMaintenance { get; set; }
        //Screen 11 Stuff Ends

        //Screen 12 Stuff
        public bool OnlineSubscriptions { get; set; }
        public bool PreferredWay { get; set; }
        public int NoofOnlineSubscriptions { get; set; }
        public int TotalAmntofAllOnlineSubscriptions { get; set; }
        //Screen 12 Stuff Ends

        //Sreen 13 Stuff
        public double Sec1Total { get; set; }
        public double Sec2Total { get; set; }
        public double Sec3Total { get; set; }
        public double Sec4Total { get; set; }
        public double Sec5Total { get; set; }
        public double Sec6Total { get; set; }
        public double Sec7Total { get; set; }
        public double Sec8Total { get; set; }
        public double Sec9Total { get; set; }
        public double AllSecsTotal { get; set; }
        //Screen 13 Stuff Ends
    }
}
