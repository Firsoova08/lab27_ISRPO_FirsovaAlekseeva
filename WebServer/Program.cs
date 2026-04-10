var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-232! Автор:Алексеева и Фирсова ");

app.Run();
