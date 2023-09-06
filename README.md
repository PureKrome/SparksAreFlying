# SparksAreFlying
⚡⚡⚡Compare your Electricity usage between Flat rate and Peak/OffPeak rates ⚡⚡⚡

To get started,

- `git clone https://github.com/PureKrome/SparksAreFlying.git`
- edit the values in `Program.cs`
  - `dailyService`
  - `flatTariff`
  - `peakTariff`
  - `offpeakkTariff`
  - `startPeakHour`
  - `endPeakHour`

  This doesn't take into consideration Flat rates that are on 2/multistages. e.g.
  - first 900 kWh are Tariff 1.
  - the rest are Tariff 2.
  - 

  # TODO / Future Plans

  Hopefully someone can be inspired by this and add a quick FrontEnd to this so we can have people easily enter their own values in, via a webpage instead of hardcodig into this quick and nasty website.
  
  Also for them to upload their CSV files.

  I'am also assuming each Supplier probably has their own CSV format. 

  -end doc-