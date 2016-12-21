using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LaugaLaunVol1.Helpers;

namespace LaugaLaunVol1.Calculator.Model
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public double MorningPayRate
        {
            get { return Settings.MorningPayRate; }
            set
            {
                if (Settings.MorningPayRate == value)
                {
                    return;
                }
                Settings.MorningPayRate = value;
                OnPropertyChanged();
            }
        }

        public double EveningPayRate
        {
            get { return Settings.EveningPayRate; }
            set
            {
                if (Settings.EveningPayRate == value)
                {
                    return;
                }
                Settings.EveningPayRate = value;
                OnPropertyChanged();
            }
        }

        public double TaxDiscount
        {
            get { return Settings.TaxDiscount; }
            set
            {
                if (Settings.TaxDiscount == value)
                {
                    return;
                }
                Settings.TaxDiscount = value;
                OnPropertyChanged();
            }
        }

        public double SereignaLifeyrirProsenta
        {
            get { return Settings.SereignaLifeyrirProsenta; }
            set
            {
                if (Settings.SereignaLifeyrirProsenta == value)
                {
                    return;
                }
                Settings.SereignaLifeyrirProsenta = value;
                OnPropertyChanged();
            }
        }

        public double OrlofProsenta
        {
            get { return Settings.OrlofProsenta; }
            set
            {
                if (Settings.OrlofProsenta == value)
                {
                    return;
                }
                Settings.OrlofProsenta = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
