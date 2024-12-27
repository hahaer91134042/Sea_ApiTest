using Microsoft.Extensions.FileProviders;
using SEA_ApiTest;
using SEA_ApiTest.Models;
using SEA_ApiTest.Utils;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDirectoryBrowser();

var provider = builder.Services.BuildServiceProvider();
Log.start(provider);
Log.print($"--- App start version :  {App.Version} ---");


builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<GmDbList>();

#region Html Encoder
//builder.Services.AddSingleton(
//HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.BasicLatin,
//                                                 UnicodeRanges.CjkUnifiedIdeographs }));
builder.Services.AddSingleton(
HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));
#endregion

#region Json formate
builder.Services.AddRazorPages().AddJsonOptions(options =>
{
    //維持原樣
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    //允許基本拉丁英文及中日韓文字維持原字元
    //options.JsonSerializerOptions.Encoder =
    //    JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.CjkUnifiedIdeographs);
    options.JsonSerializerOptions.Encoder =
    JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

});
#endregion

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(20 * 60);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var fileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "_Log"));
var requestPath = "/log";
Log.print($"file provider path->{fileProvider.Root}");
// Enable displaying browser links.
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = fileProvider,
    RequestPath = requestPath
});

app.UseDirectoryBrowser(new DirectoryBrowserOptions
{
    FileProvider = fileProvider,
    RequestPath = requestPath
});

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
