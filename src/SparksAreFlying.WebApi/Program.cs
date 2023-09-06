using SparksAreFlying.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ISupplierService, JemenaSupplierService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/", (CancellationToken cancellationToken) =>
{
    var file = File.OpenRead("data/jemena-data.csv");
    var service = new JemenaSupplierService();

    var data = service.ParseUsage(file);


    const int startPeakHour = 15;
    const int endPeakHour = 21;

    decimal dailyService = 0.97658M;
    decimal flatTariff = 0.26488M;
    decimal peakTariff = 0.31328M;
    decimal offpeakkTariff = 0.22209M;


    decimal totalFlatCost = 0;
    decimal peakkW = 0;
    decimal offpeakkW = 0;
    

    var usages = new List<UsagePerDay>(data.Count());

    // To get the most recent quarter of results, try: data.OrderByDescending(x => x.Date).Take(28*3)

    foreach (var usage in data)
    {
        var flatCost = usage.TotalFlatUsage * flatTariff;
        totalFlatCost += flatCost;

        (peakkW, offpeakkW) = usage.TotalPeakOffpeakUsage(startPeakHour, endPeakHour);

        var peakCost = peakkW * peakTariff;
        var offpeakCost = offpeakkW * offpeakkTariff;
        var peakOffPeakCost = peakCost + offpeakCost;

        var usagePerDay = new UsagePerDay(usage.Date, flatCost, peakCost, offpeakCost);

        Console.WriteLine(@$"{usage.Date} - Flat:{usage.TotalFlatUsage} @ {flatTariff} = ${flatCost:N2} |
P/OP: P:{peakkW} @ {peakTariff} = ${peakCost:N2} / OP:{offpeakkW} @ {offpeakkTariff} = ${offpeakCost:N2} T: ${peakOffPeakCost}");

        usages.Add(usagePerDay);
    }
    
    var model = new UsageResult("Jemna", usages, dailyService);

    return Results.Json(model, new JsonSerializerOptions { PropertyNamingPolicy = null });
})
.WithName("CheckUsage")
.WithOpenApi();

app.Run();


public record UsagePerDay(DateTime Date, decimal FlatkW, decimal PeakkW, decimal OffPeakkW);
public record UsageResult(string Name, List<UsagePerDay> Usages, decimal dailyService)
{
    public int TotalDays => Usages.Count();
    public decimal TotalServiceCost => dailyService * TotalDays;
    public string TotalServiceCostPretty => TotalServiceCost.ToString("N2");
    public decimal TotalFlatCost => Usages.Sum(u => u.FlatkW);
    public string TotalFlatCostPretty => TotalFlatCost.ToString("N2");
    public decimal AvgFlatCost => TotalFlatCost / TotalDays;
    public string AvgFlatCostPretty => AvgFlatCost.ToString("N2");
    public decimal AvgFlatCostQuarter => AvgFlatCost * 28 * 3;
    public string AvgFlatCostQuarterPretty => AvgFlatCostQuarter.ToString("N2");
    public decimal TotalPeakCost => Usages.Sum(u => u.PeakkW);
    public string TotalPeakCostPretty => TotalPeakCost.ToString("N2");
    public decimal TotalOffPeakCost => Usages.Sum(u => u.OffPeakkW);
    public string TotalOffPeakCostPretty => TotalOffPeakCost.ToString("N2");
    public decimal TotalPeakOffPeakCost => TotalPeakCost + TotalOffPeakCost;
    public string TotalPeakOffPeakCostPretty => TotalPeakOffPeakCost.ToString("N2");
    public decimal AvgPeakOffPeakCost => TotalPeakOffPeakCost / TotalDays;
    public string AvgPeakOffPeakCostPretty => AvgPeakOffPeakCost.ToString("N2");
    public decimal AvgPeakOffPeakCostQuarter => AvgPeakOffPeakCost * 28 * 3;
    public string AvgPeakOffPeakCostQuarterPretty => AvgPeakOffPeakCostQuarter.ToString("N2");
}
