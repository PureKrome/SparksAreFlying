namespace SparksAreFlying.Services
{
    public class Usage
    {
        public DateTime Date { get; set; }
        public decimal T0000_0030 { get; set; }
        public decimal T0030_0100 { get; set; }
        public decimal T0100_0130 { get; set; }
        public decimal T0130_0200 { get; set; }
        public decimal T0200_0230 { get; set; }
        public decimal T0230_0300 { get; set; }
        public decimal T0300_0330 { get; set; }
        public decimal T0330_0400 { get; set; }
        public decimal T0400_0430 { get; set; }
        public decimal T0430_0500 { get; set; }
        public decimal T0500_0530 { get; set; }
        public decimal T0530_0600 { get; set; }
        public decimal T0600_0630 { get; set; }
        public decimal T0630_0700 { get; set; }
        public decimal T0700_0730 { get; set; }
        public decimal T0730_0800 { get; set; }
        public decimal T0800_0830 { get; set; }
        public decimal T0830_0900 { get; set; }
        public decimal T0900_0930 { get; set; }
        public decimal T0930_1000 { get; set; }
        public decimal T1000_1030 { get; set; }
        public decimal T1030_1100 { get; set; }
        public decimal T1100_1130 { get; set; }
        public decimal T1130_1200 { get; set; }
        public decimal T1200_1230 { get; set; }
        public decimal T1230_1300 { get; set; }
        public decimal T1300_1330 { get; set; }
        public decimal T1330_1400 { get; set; }
        public decimal T1400_1430 { get; set; }
        public decimal T1430_1500 { get; set; }
        public decimal T1500_1530 { get; set; }
        public decimal T1530_1600 { get; set; }
        public decimal T1600_1630 { get; set; }
        public decimal T1630_1700 { get; set; }
        public decimal T1700_1730 { get; set; }
        public decimal T1730_1800 { get; set; }
        public decimal T1800_1830 { get; set; }
        public decimal T1830_1900 { get; set; }
        public decimal T1900_1930 { get; set; }
        public decimal T1930_2000 { get; set; }
        public decimal T2000_2030 { get; set; }
        public decimal T2030_2100 { get; set; }
        public decimal T2100_2130 { get; set; }
        public decimal T2130_2200 { get; set; }
        public decimal T2200_2230 { get; set; }
        public decimal T2230_2300 { get; set; }
        public decimal T2300_2330 { get; set; }
        public decimal T2330_2400 { get; set; }
        public decimal TotalFlatUsage =>
            T0000_0030 + T0030_0100 +
            T0100_0130 + T0130_0200 +
            T0200_0230 + T0230_0300 +
            T0300_0330 + T0330_0400 +
            T0400_0430 + T0430_0500 +
            T0500_0530 + T0530_0600 +
            T0600_0630 + T0630_0700 +
            T0700_0730 + T0730_0800 +
            T0830_0900 + T0930_1000 +
            T1000_1030 + T1030_1100 +
            T1100_1130 + T1100_1130 +
            T1200_1230 + T1230_1300 +
            T1300_1330 + T1330_1400 +
            T1400_1430 + T1430_1500 +
            T1500_1530 + T1530_1600 +
            T1600_1630 + T1630_1700 +
            T1700_1730 + T1730_1800 +
            T1800_1830 + T1830_1900 +
            T1900_1930 + T1930_2000 +
            T2000_2030 + T2030_2100 +
            T2100_2130 + T2130_2200 +
            T2200_2230 + T2230_2300 +
            T2300_2330 + T2330_2400;

        public (decimal TotalPeakkW, decimal TotalOffpeakkW) TotalPeakOffpeakUsage(int startPeakHour, int endPeakHour)
        {
            decimal peakkW = 0;
            decimal offpeakkW = 0;

            if (startPeakHour >= 0 && 0 <= endPeakHour)
            {
                peakkW += T0000_0030 + T0030_0100;
            }
            else
            {
                offpeakkW += T0000_0030 + T0030_0100;
            }

            if (startPeakHour >= 1 && 1 <= endPeakHour)
            {
                peakkW += T0100_0130 + T0130_0200;
            }
            else
            {
                offpeakkW += T0100_0130 + T0130_0200;
            }

            if (startPeakHour >= 2 && 2 <= endPeakHour)
            {
                peakkW += T0200_0230 + T0230_0300;
            }
            else
            {
                offpeakkW += T0200_0230 + T0230_0300;
            }

            if (startPeakHour >= 3 && 3 <= endPeakHour)
            {
                peakkW += T0300_0330 + T0330_0400;
            }
            else
            {
                offpeakkW += T0300_0330 + T0330_0400;
            }

            if (startPeakHour >= 4 && 4 <= endPeakHour)
            {
                peakkW += T0400_0430 + T0430_0500;
            }
            else
            {
                offpeakkW += T0300_0330 + T0330_0400;
            }

            if (startPeakHour >= 5 && 5 <= endPeakHour)
            {
                peakkW += T0500_0530 + T0530_0600;
            }
            else
            {
                offpeakkW += T0000_0030 + T0030_0100;
            }

            if (startPeakHour >= 6 && 6 <= endPeakHour)
            {
                peakkW += T0600_0630 + T0630_0700;
            }
            else
            {
                offpeakkW += T0600_0630 + T0630_0700;
            }

            if (startPeakHour >= 7 && 7 <= endPeakHour)
            {
                peakkW += T0700_0730 + T0730_0800;
            }
            else
            {
                offpeakkW += T0700_0730 + T0730_0800;
            }

            if (startPeakHour >= 8 && 8 <= endPeakHour)
            {
                peakkW += T0800_0830 + T0830_0900;
            }
            else
            {
                offpeakkW += T0800_0830 + T0830_0900;
            }

            if (startPeakHour >= 9 && 9 <= endPeakHour)
            {
                peakkW += T0900_0930 + T0930_1000;
            }
            else
            {
                offpeakkW += T0900_0930 + T0930_1000;
            }

            if (startPeakHour >= 10 && 10 <= endPeakHour)
            {
                peakkW += T1000_1030 + T1030_1100;
            }
            else
            {
                offpeakkW += T1000_1030 + T1030_1100;
            }

            if (startPeakHour >= 11 && 11 <= endPeakHour)
            {
                peakkW += T1100_1130 + T1130_1200;
            }
            else
            {
                offpeakkW += T1100_1130 + T1130_1200;
            }

            if (startPeakHour >= 12 && 12 <= endPeakHour)
            {
                peakkW += T1200_1230 + T1230_1300;
            }
            else
            {
                offpeakkW += T1200_1230 + T1230_1300;
            }

            if (startPeakHour >= 13 && 13 <= endPeakHour)
            {
                peakkW += T1300_1330 + T1330_1400;
            }
            else
            {
                offpeakkW += T1300_1330 + T1330_1400;
            }

            if (startPeakHour >= 14 && 14 <= endPeakHour)
            {
                peakkW += T1400_1430 + T1430_1500;
            }
            else
            {
                offpeakkW += T1400_1430 + T1430_1500;
            }

            if (startPeakHour >= 15 && 15 <= endPeakHour)
            {
                peakkW += T1500_1530 + T1530_1600;
            }
            else
            {
                offpeakkW += T1500_1530 + T1530_1600;
            }

            if (startPeakHour >= 16 && 16 <= endPeakHour)
            {
                peakkW += T1600_1630 + T1630_1700;
            }
            else
            {
                offpeakkW += T1600_1630 + T1630_1700;
            }

            if (startPeakHour >= 17 && 17 <= endPeakHour)
            {
                peakkW += T1700_1730 + T1730_1800;
            }
            else
            {
                offpeakkW += T1700_1730 + T1730_1800;
            }

            if (startPeakHour >= 18 && 18 <= endPeakHour)
            {
                peakkW += T1800_1830 + T1830_1900;
            }
            else
            {
                offpeakkW += T1800_1830 + T1830_1900;
            }

            if (startPeakHour >= 19 && 19 <= endPeakHour)
            {
                peakkW += T1900_1930 + T1930_2000;
            }
            else
            {
                offpeakkW += T1900_1930 + T1930_2000;
            }

            if (startPeakHour >= 20 && 20 <= endPeakHour)
            {
                peakkW += T2000_2030 + T2030_2100;
            }
            else
            {
                offpeakkW += T2000_2030 + T2030_2100;
            }

            if (startPeakHour >= 21 && 21 <= endPeakHour)
            {
                peakkW += T2100_2130 + T2130_2200;
            }
            else
            {
                offpeakkW += T2100_2130 + T2130_2200;
            }

            if (startPeakHour >= 22 && 22 <= endPeakHour)
            {
                peakkW += T2200_2230 + T2230_2300;
            }
            else
            {
                offpeakkW += T2200_2230 + T2230_2300;
            }

            if (startPeakHour >= 23 && 23 <= endPeakHour)
            {
                peakkW += T2300_2330 + T2330_2400;
            }
            else
            {
                offpeakkW += T2300_2330 + T2330_2400;
            }

            return (peakkW, offpeakkW);
        }
    }
}
