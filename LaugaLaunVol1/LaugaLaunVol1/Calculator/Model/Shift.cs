using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaugaLaunVol1.Calculator.Model
{
    public class Shift
    {
        public string ShiftDateString { get; set; }
        public DateTime ShiftDate { get; set; }
        public bool IsMorningShift { get; set; }
        public bool IsWeekend { get; set; }
        public string Weekday { get; set; }
        public string ShiftType { get; set; }
        public double MorningHours { get; set; }
        public double EveningHours { get; set; }

        public Shift(DateTime shiftDate, bool isMorning)
        {
            this.ShiftDate = shiftDate;
            this.ShiftDateString = shiftDate.Date.ToString("dd.MM.yyyy");
            this.IsMorningShift = isMorning;
            this.IsWeekend = getIsWeekend();
            this.Weekday = getDayOfWeekString(shiftDate);
            this.ShiftType = getShiftTypeString();
            SetHours();
        }

        private void SetHours()
        {
            this.EveningHours = 0;
            this.MorningHours = 0;
            if (IsWeekend)
            {
                this.EveningHours = IsMorningShift ? 7 : 8;
            }
            else
            {
                if (IsMorningShift)
                {
                    //Overtime paid from 17:00 to 08:00
                    this.MorningHours = 6.75; //from 08:00 to 14:45
                    this.EveningHours = 1.75; //from 06:15 to 08:00
                }
                else
                {
                    this.MorningHours = 2.25; //from 14:45 to 17:00
                    this.EveningHours = 5.75; //from 17:00 to 22:45
                }
            }
        }

        private bool getIsWeekend()
        {
            switch (this.ShiftDate.Date.DayOfWeek)
            {
                case DayOfWeek.Saturday: return true;
                case DayOfWeek.Sunday: return true;
            }
            return false;
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
                case DayOfWeek.Monday:    return "Mánudagur";    
                case DayOfWeek.Tuesday:   return "Þriðjudagur";  
                case DayOfWeek.Wednesday: return "Miðvikudagur"; 
                case DayOfWeek.Thursday:  return "Fimmtudagur";  
                case DayOfWeek.Friday:    return "Föstudagur";   
                case DayOfWeek.Saturday:  return "Laugardagur";
                case DayOfWeek.Sunday:    return "Sunnudagur";   
            }
            return "WTF?";
        }
        
    }
}
