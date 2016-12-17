using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaugaLaunVol1.Model
{
    public class Shift
    {
        public string ShiftDateString { get; set; }
        public DateTime ShiftDate { get; set; }
        public bool IsMorningShift { get; set; }
        public string Weekday { get; set; }
        public string ShiftType { get; set; }

        public Shift(DateTime shiftDate, bool isMorning)
        {
            this.ShiftDate = shiftDate;
            this.ShiftDateString = shiftDate.Date.ToString("dd.MM.yyyy");
            this.IsMorningShift = isMorning;
            Weekday = getDayOfWeekString(shiftDate);
            ShiftType = getShiftTypeString();
        }

        private string getShiftTypeString()
        {
            if (this.IsMorningShift)
            {
                return "Morgunvakt";
            }
            return "Kvöldvakt";
        }

        private string getDayOfWeekString(DateTime shiftDate)
        {
            switch (shiftDate.Date.DayOfWeek)
            {
                case DayOfWeek.Monday:    return "Mánudagur";    break;
                case DayOfWeek.Tuesday:   return "Þriðjudagur";  break;
                case DayOfWeek.Wednesday: return "Miðvikudagur"; break;
                case DayOfWeek.Thursday:  return "Fimmtudagur";  break;
                case DayOfWeek.Friday:    return "Föstudagur";   break;
                case DayOfWeek.Saturday:  return "Laugardagur";  break;
                case DayOfWeek.Sunday:    return "Sunnudagur";   break;
            }
            return "WTF?";
        }
        
    }
}
