using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaugaLaunVol1.Model
{
    class SalaryCalculator
    {
        private ObservableCollection<Shift> _shifts;

        public SalaryCalculator(ObservableCollection<Shift> shifts)
        {
            this._shifts = shifts;
        }

        public double CalculateSalary(ObservableCollection<Shift> shifts)
        {

            return 0.0;
        }
    }
}
