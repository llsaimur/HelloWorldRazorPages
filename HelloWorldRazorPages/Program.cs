var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();


var env = app.Services.GetRequiredService<IWebHostEnvironment>();

if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});


app.Run();
