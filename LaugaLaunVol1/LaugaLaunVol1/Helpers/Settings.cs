// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace LaugaLaunVol1.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string MorningPayRateKey = "morningpayrate_key";
        private static readonly double MorningPayRateDefault = 1700;

        private const string EveningPayRateKey = "eveningpayrate_key";
        private static readonly double EveningPayRateDefault = 2900;

        private const string TaxDiscountKey = "taxdiscount_key";
        private static readonly double TaxDiscountDefault = 52000;

        private const string SereignaLifeyrirProsentaKey = "sereignalifeyrirprosenta_key";
        private static readonly double SereignaLifeyrirProsentaDefault = 0.0;

        private const string OrlofProsentaKey = "orlofprosenta_key";
        private static readonly double OrlofProsentaDefault = 10.17;

        #endregion


        public static double MorningPayRate
        {
            get
            {
                return AppSettings.GetValueOrDefault<double>(MorningPayRateKey, MorningPayRateDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<double>(MorningPayRateKey, value);
            }
        }

        public static double EveningPayRate
        {
            get
            {
                return AppSettings.GetValueOrDefault<double>(EveningPayRateKey, EveningPayRateDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<double>(EveningPayRateKey, value);
            }
        }

        public static double TaxDiscount
        {
            get
            {
                return AppSettings.GetValueOrDefault<double>(TaxDiscountKey, TaxDiscountDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<double>(TaxDiscountKey, value);
            }
        }

        public static double SereignaLifeyrirProsenta
        {
            get
            {
                return AppSettings.GetValueOrDefault<double>(SereignaLifeyrirProsentaKey, SereignaLifeyrirProsentaDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<double>(SereignaLifeyrirProsentaKey, value);
            }
        }

        public static double OrlofProsenta
        {
            get
            {
                return AppSettings.GetValueOrDefault<double>(OrlofProsentaKey, OrlofProsentaDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<double>(OrlofProsentaKey, value);
            }
        }

    }
}