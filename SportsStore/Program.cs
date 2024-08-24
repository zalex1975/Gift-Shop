using SportsStore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<IProductRepository, EFProductRepository>();
builder.Services.AddTransient<IOrderRepository, EFOrderRepository>();
builder.Services.AddMemoryCache();  // ����������� ��������� ������
builder.Services.AddSession();      // ������ ��� ������� � �������� ������
builder.Services.AddScoped<Cart>(x => SessionCart.GetCart(x));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

app.UseDeveloperExceptionPage();    // ����������� ������
app.UseStaticFiles();               // ��������� ����������� ������ (�����. ����, � ������)
app.UseStatusCodePages();           // ������������ ������ ������� � ��������
app.UseSession();                   // ��������� ������������� ��������� ������� � �������
app.UseRouting();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "categoryPaging",
        pattern: "{category}/Page{productPage:int}",
        defaults: new { controller = "Product", action = "List" });

    endpoints.MapControllerRoute(
        name: "paging",
        pattern: "Page{productPage:int}",
        defaults: new { controller = "Product", action = "List", productPage = 1 });

    endpoints.MapControllerRoute(
        name: "category",
        pattern: "{category}",
        defaults: new { controller = "Product", action = "List", productPage = 1 });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "",
        defaults: new { controller = "Product", action = "List", productPage = 1 });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id?}");
});

//SeedData.EnsurePopulated(app);

app.Run();
