using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class DailyData
    {
        public int DailyDataId { get; set; }
        public DateTime Date { get; set; }
        public int WorkingSDC { get; set; }
        public int Appointments { get; set; }
        public int Presentations { get; set; }
        public int SuccessfulPresentations { get; set; }
        public int Attendance { get; set; }
        public int Members { get; set; }
        public int NinthKyus { get; set; }
        public int Classes { get; set; }
        public float EquipmentSales { get; set; }
        public int Interviews { get; set; }

        public SdcDetails SdcDetailsID { get; set; }
    }
}