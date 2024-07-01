using Microsoft.JSInterop;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
var random = new Random();
app.MapGet("/precipitation", () =>
{
    var cities = new List<string> { "Hồ Chí Minh", "Hà Nội", "Phú Yên", "Đà Nẵng", "Lâm Đồng"};
    var random = new Random();

    //time current
    string Time_cur = DateTime.Now.ToString();
    DateTime dateTime_cur = DateTime.Parse(Time_cur);
    TimeSpan time_cur = dateTime_cur.TimeOfDay;
    string formattedTime_cur = time_cur.ToString("hh\\:mm") + " GMT+7";

    //60p next
    string Time_for = DateTime.Now.AddMinutes(60).ToString();
    DateTime dateTime_for = DateTime.Parse(Time_for);
    TimeSpan time_for = dateTime_for.TimeOfDay;
    string formattedTime_for = time_for.ToString("hh\\:mm") + " GMT+7";


    var precipitations = new List<Precipitation>();
    foreach (var city in cities)
    {
        var precipitation = new Precipitation
        {
            City = city,
            Date = DateOnly.FromDateTime(DateTime.Now),
            Time_cur = formattedTime_cur,
            Time_for = formattedTime_for,
            Amount = random.Next(0, 100)
        };
        precipitations.Add(precipitation);
    }
    return Results.Ok(precipitations);
})
.WithName("GetPrecipitation")
.WithOpenApi();
app.Run();
internal record Precipitation
{
    public string? Time_cur { get; set; }
    public string? Time_for { get; set; }
    public string? City { get; set; }
    public DateOnly Date { get; set; }
    public int Amount { get; set; }
}
