using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace SparksAreFlying.Services
{
    public class JemenaSupplierService : ISupplierService
    {
        public IEnumerable<Usage> ParseUsage(Stream stream)
        {
            // Read in the stream.
            using (var reader = new StreamReader(stream))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<UsageJemenaMap>();
                    var data = csv.GetRecords<Usage>();

                    return data.ToList();
                }
            }
        }

        private class UsageJemenaMap : ClassMap<Usage>
        {
            public UsageJemenaMap()
            {
                Map(m => m.Date)
                    .TypeConverterOption.Format("dd/MM/yyyy")
                    .Name("DATE");
                Map(m => m.T0000_0030).Name("00:00 - 00:30");
                Map(m => m.T0030_0100).Name("00:30 - 01:00");
                Map(m => m.T0100_0130).Name("01:00 - 01:30");
                Map(m => m.T0130_0200).Name("01:30 - 02:00");
                Map(m => m.T0200_0230).Name("02:00 - 02:30");
                Map(m => m.T0230_0300).Name("02:30 - 03:00");
                Map(m => m.T0300_0330).Name("03:00 - 03:30");
                Map(m => m.T0330_0400).Name("03:30 - 04:00");
                Map(m => m.T0400_0430).Name("04:00 - 04:30");
                Map(m => m.T0430_0500).Name("04:30 - 05:00");
                Map(m => m.T0500_0530).Name("05:00 - 05:30");
                Map(m => m.T0530_0600).Name("05:30 - 06:00");
                Map(m => m.T0600_0630).Name("06:00 - 06:30");
                Map(m => m.T0630_0700).Name("06:30 - 07:00");
                Map(m => m.T0700_0730).Name("07:00 - 07:30");
                Map(m => m.T0730_0800).Name("07:30 - 08:00");
                Map(m => m.T0800_0830).Name("08:00 - 08:30");
                Map(m => m.T0830_0900).Name("08:30 - 09:00");
                Map(m => m.T0900_0930).Name("09:00 - 09:30");
                Map(m => m.T0930_1000).Name("09:30 - 10:00");
                Map(m => m.T1000_1030).Name("10:00 - 10:30");
                Map(m => m.T1030_1100).Name("10:30 - 11:00");
                Map(m => m.T1100_1130).Name("11:00 - 11:30");
                Map(m => m.T1130_1200).Name("11:30 - 12:00");
                Map(m => m.T1200_1230).Name("12:00 - 12:30");
                Map(m => m.T1230_1300).Name("12:30 - 13:00");
                Map(m => m.T1300_1330).Name("13:00 - 13:30");
                Map(m => m.T1330_1400).Name("13:30 - 14:00");
                Map(m => m.T1400_1430).Name("14:00 - 14:30");
                Map(m => m.T1430_1500).Name("14:30 - 15:00");
                Map(m => m.T1500_1530).Name("15:00 - 15:30");
                Map(m => m.T1530_1600).Name("15:30 - 16:00");
                Map(m => m.T1600_1630).Name("16:00 - 16:30");
                Map(m => m.T1630_1700).Name("16:30 - 17:00");
                Map(m => m.T1700_1730).Name("17:00 - 17:30");
                Map(m => m.T1730_1800).Name("17:30 - 18:00");
                Map(m => m.T1800_1830).Name("18:00 - 18:30");
                Map(m => m.T1830_1900).Name("18:30 - 19:00");
                Map(m => m.T1900_1930).Name("19:00 - 19:30");
                Map(m => m.T1930_2000).Name("19:30 - 20:00");
                Map(m => m.T2000_2030).Name("20:00 - 20:30");
                Map(m => m.T2030_2100).Name("20:30 - 21:00");
                Map(m => m.T2100_2130).Name("21:00 - 21:30");
                Map(m => m.T2130_2200).Name("21:30 - 22:00");
                Map(m => m.T2200_2230).Name("22:00 - 22:30");
                Map(m => m.T2230_2300).Name("22:30 - 23:00");
                Map(m => m.T2300_2330).Name("23:00 - 23:30");
                Map(m => m.T2330_2400).Name("23:30 - 00:00");

            }
        }
    }
}
