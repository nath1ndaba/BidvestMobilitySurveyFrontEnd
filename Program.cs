using BidvestMobilitySurveyFrontEnd;
using BidvestMobilitySurveyFrontEnd.APIs;
using DotNetEnv;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;
using Refit;

Env.Load();
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddScoped<SurveyApi>();

var API_URL = builder.Configuration.GetValue<string>("API_URL");
builder.Services.AddRefitClient<SurveyApi>(BidvestMobilitySurveyFrontEnd.Helpers.Extensions.GetRefitSettings())
    //.ConfigureHttpClient(c => c.BaseAddress = new Uri(MobilityConfig.API_URL));
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(API_URL));

  //.ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7237/api/v1"));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});

await builder.Build().RunAsync();
