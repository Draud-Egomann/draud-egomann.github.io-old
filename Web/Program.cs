using Data;
using Web.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web.Components.Account;
using Blazorise;
using Blazorise.Tailwind;
using Blazorise.Icons.FontAwesome;
using Web.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddBlazorise()
    .AddTailwindProviders()
    .AddFontAwesomeIcons();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options => {
  options.DefaultScheme = IdentityConstants.ApplicationScheme;
  options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(5, 7))));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddSingleton<CultureService>();
builder.Services.AddLocalization(options => options.ResourcesPath = "Translations");
builder.Services.AddScoped<IStringLocalizer<App>, StringLocalizer<App>>();
builder.Services.AddScoped<MockData>();

var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(CultureService.SupportedCultures[0].ToString())
    .AddSupportedCultures(CultureService.SupportedCultures.Select(c => c.ToString()).ToArray())
    .AddSupportedUICultures(CultureService.SupportedCultures.Select(c => c.ToString()).ToArray());

builder.Services.Configure<RequestLocalizationOptions>(options => {
  options.DefaultRequestCulture = new RequestCulture("de-CH");
  options.SupportedCultures = CultureService.SupportedCultures;
  options.SupportedUICultures = CultureService.SupportedCultures;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
  app.UseMigrationsEndPoint();
} else {
  app.UseExceptionHandler("/Error", createScopeForErrors: true);
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

// Use localization
app.UseRequestLocalization(localizationOptions);

app.Run();
