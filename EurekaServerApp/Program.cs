using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình chạy đúng cổng 8761
builder.WebHost.UseUrls("http://localhost:8761");

// Thêm dịch vụ Discovery Client
builder.Services.AddDiscoveryClient(builder.Configuration);

var app = builder.Build();

app.UseDiscoveryClient();

// Trang hiển thị xác nhận trạng thái
app.MapGet("/", () => "Eureka Server dang hoat dong thanh cong tren cong 8761!");

app.Run();